using QuickRMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRMS.Forms
{
    public partial class License : Form
    {
        internal IEnumerable<Server> Servers { get; private set; }
        internal IEnumerable<KeyValuePair<string, string>> Licenses { get; private set; }
        public License(IEnumerable<Server> servers)
        {
            
            InitializeComponent();
            Servers = servers;
            ReloadTreeViewServers();
            ReloadTreeViewLicenses();

            tb_serverInfo.ScrollBars = ScrollBars.Vertical;
        }

        private void ReloadTreeViewLicenses()
        {
            if (!File.Exists("LicenseText.txt"))
            {
                MessageBox.Show("Информационный файл не найден!", "Ошибка");
                return;
            }
            string s;
            var license = new List<KeyValuePair<string, string>>();
            Regex regexID = new Regex(@"[\(^]\d+");
            Regex regexName = new Regex(@"[\'^][^)]+[\)$]");
            using (var f = new StreamReader("LicenseText.txt", Encoding.UTF8))
            {
                while ((s = f.ReadLine()) != null)
                {
                    var lic = regexID.Match(s).ToString().Remove(0, 1).Trim();
                    license.Add(new KeyValuePair<string, string>(
                        lic,
                        regexName.Match(s).ToString().Remove(0, 1).Trim() + $" ({lic})"));
                }
            }
            Licenses = license;
            tv_License.Nodes.AddRange(Licenses.Select(lic => new TreeNode(lic.Value)).ToArray());
            
        }

        private void ReloadTreeViewServers()
        {
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
                //добавление оставшихся рмсов
                tv_servers.Nodes.AddRange(listServers.Select(serv => new TreeNode(serv.Name)).ToArray());

            }
        }

        #region SEARCH TREEVIEW
        private void tb_Server_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_Server.Text.Length == 0)
            {
                ReloadTreeViewServers();
            }
            else if (tb_Server.Text.Length > 1)
            {
                
                //вариант с пробелами
                var space = tb_Server.Text.ToLower().Split(' ');
                var list = Servers.Select(data => data.Name).ToList();
                tv_servers.Nodes.Clear();
                foreach (var s in space)
                {
                    list = list.Where(data => data.ToLower().Contains(s)).ToList();
                }
                tv_servers.Nodes.AddRange((from data in list select new TreeNode(data)).ToArray());

            }
        }
        private void tb_License_KeyUp(object sender, KeyEventArgs e)
        {
            if (tb_License.Text.Length == 0)
            {
                ReloadTreeViewLicenses();
            }
            else if (tb_License.Text.Length > 1)
            {

                //вариант с пробелами
                var space = tb_License.Text.ToLower().Split(' ');
                var list = Licenses.Select(data => data.Value).ToList();
                tv_License.Nodes.Clear();
                foreach (var s in space)
                {
                    list = list.Where(data => data.ToLower().Contains(s)).ToList();
                }
                tv_License.Nodes.AddRange((from data in list select new TreeNode(data)).ToArray());

            }
        }
        private void pb_Server_Click(object sender, EventArgs e)
        {
            tb_Server.Text = "";
            ReloadTreeViewServers();
        }

        private void pb_License_Click(object sender, EventArgs e)
        {
            tb_License.Text = "";
            ReloadTreeViewLicenses();
        }


        #endregion

        private void btn_SkipLicense_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            Server server = new Server();
            try
            {

                tb_Connection.Text = connection.CheckConnectionSafe(tb_Connection.Text);

                if (Servers.Where(data => data.Connection == tb_Connection.Text).Count() > 0)
                {
                    server = Servers.Where(data => data.Connection == tb_Connection.Text).First();
                }
                else
                {
                    server = new Server()
                    {
                        Connection = tb_Connection.Text,
                        Login = "admin",
                        Password = "restoresto"
                    };
                }
                connection.SkipLicence(server.Connection, server.Login, server.Password, 
                    Licenses.Where(data => data.Value == tv_License.SelectedNode.Text)
                    .Select(data => data.Key)
                    .First());
                MessageBox.Show($"{tv_License.SelectedNode.Text} успешно сброшена","Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось попасть в томкет по адресу:\r\n{tb_Connection.Text}\r\n" +
                        $"Используя логин {server.Login} и пароль {server.Password}\r\n{ex.Message}", "Ошибка");
            }
            
        }

        private void tv_servers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                tb_Connection.Text = Servers.Where(data => data.Name == e.Node.Text)
                    .First()
                    .Connection;
            }
            catch (Exception)
            {
               
            }
        }

        private void tv_servers_DoubleClick(object sender, EventArgs e)
        {
            btn_connection_Click(sender, e);
        }

        private void btn_connection_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            Server server = new Server();
            try
            {

                tb_Connection.Text = connection.CheckConnectionSafe(tb_Connection.Text);

                if (Servers.Where(data => data.Connection == tb_Connection.Text).Count() > 0)
                {
                    server = Servers.Where(data => data.Connection == tb_Connection.Text).First();
                }
                else
                {
                    server = new Server()
                    {
                        Connection = tb_Connection.Text,
                        Login = "admin",
                        Password = "restoresto"
                    };
                }
                var tabl = connection.GetConnections(server.Connection, server.Login, server.Password);
                dgv_connections.Rows.Clear();
                if (tabl != null)
                    foreach (var row in tabl)
                        dgv_connections.Rows.Add(row.ToArray());

                var info = connection.GetRMSInfo(server.Connection, server.Login, server.Password);
                tb_serverInfo.Text = info;
                //MessageBox.Show($"{tv_License.SelectedNode.Text} успешно сброшена", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось попасть в томкет по адресу:\r\n{tb_Connection.Text}\r\n" +
                        $"Используя логин {server.Login} и пароль {server.Password}\r\n{ex.Message}", "Ошибка");
            }
        }

        private void btn_OpenWeb_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            Server server = new Server();
            try
            {

                tb_Connection.Text = connection.CheckConnectionSafe(tb_Connection.Text);
                
                if (Servers.Where(data => data.Connection == tb_Connection.Text).Count() > 0)
                {
                    server = Servers.Where(data => data.Connection == tb_Connection.Text).First();
                }
                else
                {
                    server = new Server()
                    {
                        Connection = tb_Connection.Text,
                        Login = "admin",
                        Password = "restoresto"
                    };
                }
                connection.GetHtmlBrowser(server.Connection, server.Login, server.Password);
            }
            catch (Exception)
            {
                MessageBox.Show($"Не удалось попасть в томкет по адресу:\r\n{tb_Connection.Text}\r\n"+
                        $"Используя логин {server.Login} и пароль {server.Password}","Ошибка");
            }
            
        }
    }
}
