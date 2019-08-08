using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;



namespace TPIMon
{

    class CTPIInfo
    {
        public string ID;
        public double Voltage;
        public string gps_x;
        public string gps_y;
        public string gps_time;
        public bool Online;

        public CTPIInfo()
        {
            ID = String.Empty;
            gps_x = String.Empty;
            gps_y = String.Empty;
            gps_time = String.Empty;
            Online = false;
            Voltage = 0;
        }

        public override String ToString()
        {
            if (ID == String.Empty)
            { return String.Empty; }
            else
            { return Online.ToString() + "\r\n" + ID + "\r\n" + String.Format("{0:0.0}", Voltage) + "\r\n" + gps_x + "\r\n" + gps_y +"\r\n" + gps_time; }
        }

        public String ToTabbedString(String div)
        {
            if (ID == String.Empty)
            { return String.Empty; }
            else
            { return Online.ToString() + div + ID + div + String.Format("{0:0.0}", Voltage) + div + gps_x + div + gps_y + div + gps_time; }
        }
    }





    class CTPIParser
    {

        public string index_page;

        public CTPIParser()
        {
            index_page = String.Empty;
        }
        public CTPIParser(string index_url)
        {
            index_page = String.Empty;
            GetIndexPage(index_url);
            if (index_page == String.Empty)
            {
                index_page = "Ошибка получения страницы " + index_url + " - проверьте настройки сети";
            }
        }

        public void GetIndexPage(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Timeout = TPIMon.Properties.Settings.Default.NET_TIMEOUT;
                WebResponse response = request.GetResponse();
                Stream data = response.GetResponseStream();
                string html = String.Empty;
                using (StreamReader sr = new StreamReader(data))
                {
                    index_page = sr.ReadToEnd();
                }
                if (index_page != String.Empty)
                {
                    index_page = Regex.Replace(index_page, "<.*?>", String.Empty);
                    index_page = Regex.Replace(index_page, "\t", String.Empty);
                    index_page = Regex.Replace(index_page, "\r", String.Empty);
                    index_page = Regex.Replace(index_page, "\n", String.Empty);
                }
                response.Close();
            }
            catch (Exception ex)
            {

            }
        }
        public CTPIInfo ParseHTML(String html)
        {
            CTPIInfo result = new CTPIInfo();

            int tag_begin = 0;
            int tag_end = 0;
            double volt = 9;


            if ((html.Contains("&lt;id&gt;")) && (html.Contains("&lt;/id&gt;")))
            {
                tag_begin = html.IndexOf("&lt;id&gt;") + 10;
                tag_end = html.IndexOf("&lt;/id&gt;");
                result.ID = html.Substring(tag_begin, tag_end - tag_begin);
            }
            else return null;

            if ((html.Contains("&lt;voltage&gt;")) && (html.Contains("&lt;/voltage&gt;")))
            {
                tag_begin = html.IndexOf("&lt;voltage&gt;") + 15;
                tag_end = html.IndexOf("&lt;/voltage&gt;");
                string voltage = html.Substring(tag_begin, tag_end - tag_begin);
                double.TryParse(voltage, out volt);
                result.Voltage = volt / 1000;
            }
            else return null;

            if ((html.Contains("&lt;x&gt;")) && (html.Contains("&lt;/x&gt;")))
            {
                tag_begin = html.IndexOf("&lt;x&gt;") + 9;
                tag_end = html.IndexOf("&lt;/x&gt;");
                result.gps_x = html.Substring(tag_begin, tag_end - tag_begin);
            }
            else return null;

            if ((html.Contains("&lt;y&gt;")) && (html.Contains("&lt;/y&gt;")))
            {
                tag_begin = html.IndexOf("&lt;y&gt;") + 9;
                tag_end = html.IndexOf("&lt;/y&gt;");
                result.gps_y = html.Substring(tag_begin, tag_end - tag_begin);
            }
            else return null;

            if ((html.Contains("&lt;gpstimestamp&gt;")) && (html.Contains("&lt;/gpstimestamp&gt;")))
            {
                tag_begin = html.IndexOf("&lt;gpstimestamp&gt;") + 20;
                tag_end = html.IndexOf("&lt;/gpstimestamp&gt;");
                result.gps_time = html.Substring(tag_begin, tag_end - tag_begin);
            }
            else return null;



            if (index_page.Contains("Modem " + result.ID  + "SIGNONLINE"))
            {
                result.Online = true;
            }

            return result;
        }

    }
}
