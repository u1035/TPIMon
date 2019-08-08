using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;


namespace TPIMon
{
    public partial class Form1 : Form
    {

        GMap.NET.WindowsForms.GMapOverlay markersOverlay;
        Dictionary<string, CTPIInfo> TPIs;
        bool OnlineOnly;
        bool ASUDDOnly;
        CTPIParser parser;
        int TPIOnline;



        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmdStart.Enabled = false;
            textBox1.Clear();
            Process();
            cmdStart.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TPIs = new Dictionary<string, CTPIInfo>();

            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker");
            gMapControl1.Position = new GMap.NET.PointLatLng(43.5908324, 39.7691557);

        }

        private void Process()
        {
            txtInfo.Text="<Выберите табло для отображения подробной информации>";
            textBox1.Clear();
            TPIs.Clear();
            cmbTPISelect.Items.Clear();
            TPIOnline = 0;

            parser = new CTPIParser(TPIMon.Properties.Settings.Default.SERVER + TPIMon.Properties.Settings.Default.MODEM_INDEX);
            if (parser.index_page.StartsWith("Ошибка получения страницы"))
            {
                textBox1.AppendText(parser.index_page);
                return;
            }

            Task[] taskArray = new Task[TPIMon.Properties.Settings.Default.MODEM_NUM];
            for (int i = 0; i < TPIMon.Properties.Settings.Default.MODEM_NUM; i++)
            {
                Application.DoEvents();

                string url = TPIMon.Properties.Settings.Default.SERVER + TPIMon.Properties.Settings.Default.MODEM_PAGE + (string.Format(String.Format("{0,10:000}", i))).Trim();
                taskArray[i] = Task.Factory.StartNew(() => RequestModemPage(url));

                Application.DoEvents();
                //RequestModemPage("http://172.16.160.53:8020/modem/status.jsp?id=RU" + (string.Format(String.Format("{0,10:000}", i))).Trim());

            }

            Task.WaitAll(taskArray);

            if (ASUDDOnly)
            { ShowASUDDTPIs(); }
            else
            { FillMap_data(TPIs); }

            lblTPIsTotal.Text = "Всего ТПИ: " + TPIs.Count.ToString();
            lblTPIsOnline.Text = "ТПИ Онлайн: " + TPIOnline;
        }

        private void RequestModemPage(object url)
        {
            try
            {
               
                    WebRequest request = WebRequest.Create(url.ToString());
                    request.Timeout = TPIMon.Properties.Settings.Default.NET_TIMEOUT;
                    WebResponse response = request.GetResponse();
                    Stream data = response.GetResponseStream();
                    string html = String.Empty;
                    using (StreamReader sr = new StreamReader(data))
                    {
                        html = sr.ReadToEnd();
                    }
                    CTPIInfo info = parser.ParseHTML(html);
                    if (info != null)
                    {
                        textBox1.AppendText("\r\n" + info.ToTabbedString("                       "));
                        lock (TPIs)
                        {
                            TPIs.Add(info.ID, info);
                        }
                    }
                response.Close();
                
            }
            catch (Exception ex)
            {
                if (ex == null)
                { textBox1.Text += "\r\nНе удалось получить страницу " + url; }
                //textBox1.Text += "\r\n" + ex.Message;
            }
        }

       private void FillMap_data(Dictionary<string, CTPIInfo> data)
        {
            gMapControl1.Overlays.Clear();
            markersOverlay.Markers.Clear();

            foreach (CTPIInfo item in data.Values)
            {
                if (item.Online) { TPIOnline++; }

                    if ((item.Online) && (OnlineOnly))
                    { cmbTPISelect.Items.Add(item.ID); }
                    if (!OnlineOnly)
                    { cmbTPISelect.Items.Add(item.ID); }

                    if (item.gps_x != "0.0")
                    {
                        if (item.Online)
                        {
                            GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(Double.Parse(item.gps_y, System.Globalization.CultureInfo.InvariantCulture), Double.Parse(item.gps_x, System.Globalization.CultureInfo.InvariantCulture)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);
                            marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                            marker.ToolTipText = item.ID;
                            markersOverlay.Markers.Add(marker);

                        }
                        else
                        {
                            if (!OnlineOnly)
                            {
                                GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(Double.Parse(item.gps_y, System.Globalization.CultureInfo.InvariantCulture), Double.Parse(item.gps_x, System.Globalization.CultureInfo.InvariantCulture)), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red);
                                marker.ToolTip = new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                                marker.ToolTipText = item.ID;
                                markersOverlay.Markers.Add(marker);

                            }
                        }

                    }
                    else   //Если нет достоверных координат
                    {
                        if (item.Online)
                        {
                            textBox1.AppendText("\r\n !!! ТПИ " + item.ID + " ОНЛАЙН, но не отображено на карте, т.к. передало координаты 0.0 - 0.0. Данные с этого ТПИ можно увидеть выше в этом логе, или выбрав его в списке.");
                        }
                        else
                        {
                            textBox1.AppendText("\r\n !!! ТПИ " + item.ID + " не отображено на карте, т.к. передало координаты 0.0 - 0.0. Данные с этого ТПИ можно увидеть выше в этом логе, или выбрав его в списке.");
                        }
                    }
                
        }

            gMapControl1.Overlays.Add(markersOverlay);
            gMapControl1.ZoomAndCenterMarkers("marker");
            gMapControl1.Update();
        }

        private void gMapControl1_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            cmbTPISelect.SelectedItem = item.ToolTipText;

            txtInfo.Clear();
            txtInfo.AppendText("ТПИ " + item.ToolTipText + "\r\n");
            if (TPIs[item.ToolTipText].Online)
            {
                txtInfo.AppendText("Статус: Онлайн\r\n");
            }
            else
            {
                txtInfo.AppendText("Статус: Оффлайн\r\n");
            }
            txtInfo.AppendText("Напряжение бортовой сети - " + String.Format("{0:0.0}", TPIs[item.ToolTipText].Voltage) + " вольт\r\n");

            txtInfo.AppendText("Координаты:\r\n");
            txtInfo.AppendText("Широта - " + TPIs[item.ToolTipText].gps_y + "\r\n");
            txtInfo.AppendText("Долгота - " + TPIs[item.ToolTipText].gps_x + "\r\n");

            txtInfo.AppendText("Время по внутренним часам - " + TPIs[item.ToolTipText].gps_time + "\r\n");

            picImage.Load("http://172.16.160.53:8020/preview?modem-id=" + item.ToolTipText);
            picImage.Refresh();
        }

        private void chkOnlineOnly_CheckedChanged(object sender, EventArgs e)
        {
            OnlineOnly = chkOnlineOnly.Checked;
            cmbTPISelect.Items.Clear();
            if (ASUDDOnly)
            { ShowASUDDTPIs(); }
            else
            { FillMap_data(TPIs); }
        }

        private void cmbMap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMap.SelectedItem)
            {
                case "Google Maps":
                    gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
                    break;

                case "Yandex maps":
                    gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.YandexMap;
                    break;

                case "Yandex Hybrid maps":
                    gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.YandexHybridMap;
                    break;

                case "OSM maps":
                    gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.OpenStreetMap;
                    break;

            }

            gMapControl1.Update();
        }

        private void cmbTPISelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtInfo.AppendText("ТПИ " + cmbTPISelect.SelectedItem.ToString() + "\r\n");
            if (TPIs[cmbTPISelect.SelectedItem.ToString()].Online)
            {
                txtInfo.AppendText("Статус: Онлайн\r\n");
            }
            else
            {
                txtInfo.AppendText("Статус: Оффлайн\r\n");
            }
            txtInfo.AppendText("Напряжение бортовой сети - " + String.Format("{0:0.0}", TPIs[cmbTPISelect.SelectedItem.ToString()].Voltage) + " вольт\r\n");

            txtInfo.AppendText("Координаты:\r\n");
            txtInfo.AppendText("Широта - " + TPIs[cmbTPISelect.SelectedItem.ToString()].gps_y + "\r\n");
            txtInfo.AppendText("Долгота - " + TPIs[cmbTPISelect.SelectedItem.ToString()].gps_x + "\r\n");

            txtInfo.AppendText("Время по внутренним часам - " + TPIs[cmbTPISelect.SelectedItem.ToString()].gps_time + "\r\n");

            picImage.Load(Properties.Settings.Default.SERVER + Properties.Settings.Default.IMAGE_PREVIEW  + cmbTPISelect.SelectedItem.ToString());
            //picImage.Load("http://172.16.160.53:8020/preview?modem-id=" + cmbTPISelect.SelectedItem.ToString());
            picImage.Refresh();

            cmdShowOnMap.Enabled = true;
        }

        private void cmdShowOnMap_Click(object sender, EventArgs e)
        {
            //gMapControl1.Position = new GMap.NET.PointLatLng(Double.Parse(TPIs[cmbTPISelect.SelectedItem.ToString()].gps_y, System.Globalization.CultureInfo.InvariantCulture), Double.Parse(TPIs[cmbTPISelect.SelectedItem.ToString()].gps_x, System.Globalization.CultureInfo.InvariantCulture));
            try
            {
                gMapControl1.Position = new GMap.NET.PointLatLng(Double.Parse(TPIs[cmbTPISelect.Text].gps_y, System.Globalization.CultureInfo.InvariantCulture), Double.Parse(TPIs[cmbTPISelect.Text].gps_x, System.Globalization.CultureInfo.InvariantCulture));
                gMapControl1.Zoom = 15;
                gMapControl1.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Выберите корректный ID ТПИ из списка.\r\n\r\nЕсли всё-таки это баг - пожалуйста, передайте скриншот этой ошибки разработчику\r\n" + ex.Message, "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdSettings_Click(object sender, EventArgs e)
        {
            frmSettings set = new frmSettings();
            set.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ASUDDOnly = chkASUDDOnly.Checked;
            cmbTPISelect.Items.Clear();
            if (ASUDDOnly)
            { ShowASUDDTPIs(); }            
            else
            { FillMap_data(TPIs); }
        }

        private void ShowASUDDTPIs()
        {
            Dictionary<string, CTPIInfo> asudd_tpis = new Dictionary<string, CTPIInfo>(); ;
            foreach (CTPIInfo item in TPIs.Values)
            {
                if (Properties.Settings.Default.ASUDD_LIST.Contains(item.ID))
                {
                    asudd_tpis.Add(item.ID,item);
                }
            }
            FillMap_data(asudd_tpis);
        }
    }
}
