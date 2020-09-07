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
        static bool mustClose = false;

        internal IEnumerable<Server> Servers { get; private set; }

        public Main()
        {
            InitializeComponent();
            toolStripVersion.Text = TEXT_VERSION;
            lb_version.Text = "";
            TopMost = true;
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

            //1 - ранжирование и объединение 
            //0 - вывод подряд
            if (!Properties.Settings.Default.StructuringList)
                foreach (var name in Servers)
                {
                    tv_servers.Nodes.Add(new TreeNode(name.Name));
                }
            else
            {
                var listServers = Servers.ToList();                             //создание переменной для контроля добавления всех серверов
                var Chains = listServers.Where(serv => serv.isChain == true).ToList();   //выборка чейнов
                foreach (var chain in Chains)
                {
                    tv_servers.Nodes.Add(new TreeNode(chain.Name));             //добавление чейнов
                    listServers.Remove(chain);                                  //удаление добавленного сервера из списка
                    var rms = listServers.Where(serv => serv.coConnection.Length > 5 && chain.Connection.Contains(serv.coConnection)).ToList();  //выборка всех рмс данного чейна
                    foreach (var serv in rms)
                    {
                        tv_servers.Nodes[tv_servers.Nodes.Count - 1].Nodes.Add(new TreeNode(serv.Name));                //добавление рмсов данного чейна
                        listServers.Remove(serv);                               //удаление добавленного сервера из списка
                    }
                }
                foreach (var serv in listServers)
                {
                    tv_servers.Nodes.Add(new TreeNode(serv.Name));             //добавление оставшихся рмсов
                }

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

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            TopMost = Visible = !Visible;
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            TopMost = Visible = !Visible;
            e.Cancel = !mustClose;
        }

        private void toolStripMenuItem_close_Click(object sender, EventArgs e)
        {
            mustClose = true;
            Close();
        }

        #region SEARCH TREEVIEW

        private void pb_Search_Click(object sender, EventArgs e)
        {
            tb_search.Text = "";
            ReloadTreeView();
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
       

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_search.Text.Length == 0)
            {
                ReloadTreeView();
            }
            else if (tb_search.Text.Length > 1)
            {
                //вариант без пробелов
                //tv_servers.Nodes.Clear();
                //tv_servers.Nodes.AddRange((from data in Servers where data.Name.ToLower().Contains(tb_search.Text.ToLower()) select new TreeNode(data.Name)).ToArray());

                //вариант с пробелами
                var space = tb_search.Text.ToLower().Split(' ');
                var listServer = Servers.Select(data => data.Name).ToList();
                tv_servers.Nodes.Clear();
                foreach (var s in space)
                {
                    listServer = listServer.Where(data => data.ToLower().Contains(s)).ToList();
                }
                tv_servers.Nodes.AddRange((from data in listServer select new TreeNode(data)).ToArray());

            }
        } 
        
        #endregion
    }
}
