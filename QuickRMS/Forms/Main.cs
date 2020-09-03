using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickRMS.Classes;

namespace QuickRMS.Forms
{
    public partial class Main : Form
    {
        static string TEXT_VERSION = "Версия: ";

        internal IEnumerable<Server> Servers { get; private set; }

        public Main()
        {
            InitializeComponent();
            toolStripVersion.Text = TEXT_VERSION;
            lb_version.Text = "";

            try
            {

                ReloadTreeView();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Ошибка"); }
        }

        private void toolStrip_btn_Settings_Click(object sender, EventArgs e)
        {
            var formsettings = new Settings();
            formsettings.ShowDialog();
            try
            {

                ReloadTreeView();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Ошибка"); }
        }
        void ReloadTreeView()
        {
            Servers = SqlManager.GetInstance().GetData();
            tv_servers.Nodes.Clear();
            foreach (var name in Servers)
            {
                tv_servers.Nodes.Add(new TreeNode(name.Name));
            }
        }
        private void tb_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void tv_servers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                toolStripVersion.Text = TEXT_VERSION + Servers.Where(data => data.Name == e.Node.Text)
                    .First()
                    .Version;
            }
            catch (Exception)
            {
                toolStripVersion.Text = "Ууууупс...";
            }
        }

        private void toolStrip_btn_check_ButtonClick(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            try
            {
                tb_server.Text += @"/resto";
                tb_server.Text = connection.CheckConnectionSafe(tb_server.Text);
                lb_version.Text = connection.GetServerVersion(tb_server.Text);
                tb_server.ReadOnly = true;
            }
            catch (Exception)
            {
                lb_version.Text = "Ошибка";
            }
        }

        private void lb_version_DoubleClick(object sender, EventArgs e)
        {
            tb_server.ReadOnly = false;
            lb_version.Text = tb_server.Text = "";
        }
    }
}
