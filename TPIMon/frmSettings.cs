using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIMon
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtServer.Text = TPIMon.Properties.Settings.Default.SERVER;
            txtIndexPage.Text = TPIMon.Properties.Settings.Default.SERVER + TPIMon.Properties.Settings.Default.MODEM_INDEX;
            txtModemPage.Text = TPIMon.Properties.Settings.Default.SERVER + TPIMon.Properties.Settings.Default.MODEM_PAGE;
            txtPreview.Text = TPIMon.Properties.Settings.Default.SERVER + TPIMon.Properties.Settings.Default.IMAGE_PREVIEW;
            txtASUDDTPIs.Text = TPIMon.Properties.Settings.Default.ASUDD_LIST;
            numModems.Value = TPIMon.Properties.Settings.Default.MODEM_NUM;
            numTimeout.Value = TPIMon.Properties.Settings.Default.NET_TIMEOUT;
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                TPIMon.Properties.Settings.Default.SERVER = txtServer.Text;
                TPIMon.Properties.Settings.Default.MODEM_INDEX = txtIndexPage.Text.Substring(txtServer.Text.Length);
                TPIMon.Properties.Settings.Default.MODEM_PAGE = txtModemPage.Text.Substring(txtServer.Text.Length);
                TPIMon.Properties.Settings.Default.IMAGE_PREVIEW = txtPreview.Text.Substring(txtServer.Text.Length);
                TPIMon.Properties.Settings.Default.MODEM_NUM = (int)numModems.Value;
                TPIMon.Properties.Settings.Default.NET_TIMEOUT = (int)numTimeout.Value;
                TPIMon.Properties.Settings.Default.ASUDD_LIST = txtASUDDTPIs.Text;

                TPIMon.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, проверьте настройки, либо сбросьте их на изначальные кнопкой \"По умолчанию\"");
            }
            this.Close();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (!txtServer.Text.EndsWith("/")) { txtServer.Text += "/"; }

            txtIndexPage.Text = txtServer.Text + TPIMon.Properties.Settings.Default.MODEM_INDEX;
            txtModemPage.Text = txtServer.Text + TPIMon.Properties.Settings.Default.MODEM_PAGE;
        }

        private void cmdDefault_Click(object sender, EventArgs e)
        {
            txtServer.Text = "http://172.16.160.53:8020/";
            txtIndexPage.Text = "http://172.16.160.53:8020/modem/index.jsp";
            txtModemPage.Text = "http://172.16.160.53:8020/modem/status.jsp?id=RU";
            txtPreview.Text = "http://172.16.160.53:8020/preview?modem-id=";
            txtASUDDTPIs.Text = "RU041 RU042 RU043 RU044 RU045 RU047 RU048 RU050 RU052 RU053 RU055 RU056 RU057 RU058";
            numModems.Value = 100;
            numTimeout.Value = 5000;
        }
    }
}
