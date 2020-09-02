using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace QuickRMS.Forms
{
    public partial class Main : Form
    {
        static string TEXT_VERSION = "Версия: ";

        public Main()
        {
            InitializeComponent();
            toolStripStatus.Text = TEXT_VERSION;
            cb_protocol.Items.AddRange(new string[] { "HTTP", "HTTPS" });
            cb_protocol.SelectedIndex = 0;
            tb_port.Text = "80";
        }

        private void toolStrip_btn_Settings_Click(object sender, EventArgs e)
        {
            var formsettings = new Settings();
            formsettings.Show();
        }

        private void tb_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
