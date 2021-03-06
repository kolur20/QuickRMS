﻿
using QuickRMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QuickRMS.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            tb_namedb.Text = Properties.Settings.Default.NameDataBase;

            btn_help_Click(null, null);


            tb_rms.Text = Properties.Settings.Default.PathRMS;
            tb_rms_ico.Text = Properties.Settings.Default.PathRMSico;
            tb_timer.Text = Properties.Settings.Default.TimeStart.ToString();

            cb_alt_run.Checked = Properties.Settings.Default.AltRunRMS;
        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            try
            {
                bw_animation.RunWorkerAsync();

                tb_strConnection.Text = connection.CheckConnectionSafe(tb_strConnection.Text);
                tb_version.Text = connection.GetServerVersion(tb_strConnection.Text);
                //new Wait().Show();
                bw_animation.CancelAsync();
            }
            catch (Exception)
            {
                tb_version.Text = "Ошибка";
                bw_animation.CancelAsync();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_version.Text.Split('.').Count() != 4)
            {
                tb_version.Text = "Ошибка данных";
                return;
            }
            var server = new Server();
            server.Name = tb_nameConnection.Text;
            server.Connection = tb_strConnection.Text;
            server.Version = tb_version.Text;
            server.coConnection = tb_co.Text;
            server.isChain = cb_chain.Checked;
            server.Login = tb_login.Text;
            server.Password = tb_password.Text;
            try
            {
                SqlManager.GetInstance().Insert(server);
                MessageBox.Show("Добавлено", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            try
            {
                bw_animation.RunWorkerAsync();

                tb_instr.Clear();
                //получение серверов из файла
                var csv = new CsvManager();
                var servers = csv.Import(tb_importfile.Text).ToList<Server>();
                
                //проверка каждого сервера
                var connection = new ConnectionManager();
                var killServers = new List<string>();
                foreach (var server in servers)
                {
                    try
                    {
                        server.Connection = connection.CheckConnectionSafe(server.Connection);
                        server.Version = connection.GetServerVersion(server.Connection);
                    }
                    catch (Exception)
                    {

                        killServers.Add(server.Name);
                        tb_instr.Text += string.Format($"Ошибка: {server.Name} '\n'");
                    }
                }

                foreach (var kill in killServers)
                    servers.RemoveAt(servers.FindIndex(data => data.Name == kill));
                
                //очистка записей в бд при необходимости
                if (cb_removeAll.Checked)
                    SqlManager.GetInstance().RemoveAll();

                //умный импорт
                var serversInDB = SqlManager.GetInstance().GetData().ToList();
                if (cb_safeImport.Checked && serversInDB != null)
                {
                    tb_instr.Text += $"Записей для импорта обработано: {servers.Count} из {servers.Count + killServers.Count} '\n'";
                    //запись новых данных, которых еще нет в базе
                    killServers = new List<string>();
                    foreach (var server in servers)
                        if (serversInDB.Where(data => data.Name == server.Name).Count() != 0)
                            killServers.Add(server.Name);
                    
                    foreach (var kill in killServers)
                        servers.RemoveAt(servers.FindIndex(data => data.Name == kill));
                    SqlManager.GetInstance().Insert(servers);
                    tb_instr.Text += $"Импортировано: {servers.Count} из {servers.Count + killServers.Count} '\n'";
                }
                else
                {
                    //запись новых данных в бд
                    SqlManager.GetInstance().Insert(servers);
                    tb_instr.Text += $"Импортировано: {servers.Count} из {servers.Count + killServers.Count} '\n'";
                }
                bw_animation.CancelAsync();
            }
            catch (Exception ex)
            {
                tb_instr.Text += $"Фатальная ошибка при импорте '\n'";
                MessageBox.Show(ex.Message, "Ошибка");
                bw_animation.CancelAsync();
                return;
            }

        }

        private void btn_fileSelected_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Файлы csv|*.csv";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            tb_importfile.Text = dialog.FileName;
        }

        private void btn_SaveDB_Click(object sender, EventArgs e)
        {
            if (tb_namedb.Text != "")
                Properties.Settings.Default.NameDataBase = tb_namedb.Text;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            bw_animation.RunWorkerAsync();
            Directory.CreateDirectory("Export");
            var file = @"Export\RMS_ServerConnections.csv";
            tb_instr.Clear();
            try
            {

                var csv = new CsvManager();
                csv.Export(file, SqlManager.GetInstance().GetData());
                tb_instr.Text += $"Успешный экспорт файла {file} '\n'";
                
                bw_animation.CancelAsync();
            }
            catch (Exception ex)
            {
                
                tb_instr.Text += $"Ошибка при экспорте файла {file} '\n'";
                MessageBox.Show(ex.Message, "Ошибка");

                bw_animation.CancelAsync();
            }
        }


        delegate void Delegate(BackgroundWorker bw_animation);
        Delegate del = new Delegate(WaitAnswer);
       
        private static void WaitAnswer(BackgroundWorker bw_animation)
        {

            Wait form = new Wait();
            form.Show();
            form.Focus();
            while (!bw_animation.CancellationPending) { }
            form.Close();
        }
        void CallBackFunc(IAsyncResult aRes)
        {
            del.EndInvoke(aRes);
        }
        private void btn_help_Click(object sender, EventArgs e)
        {

            if (File.Exists("info.txt"))
                tb_instr.Text = File.ReadAllText("info.txt");
            else
                tb_instr.Text = "Информационный файл не найден!";

        }

        private void bw_animation_DoWork(object sender, DoWorkEventArgs e)
        {
            del.BeginInvoke(bw_animation, new AsyncCallback(CallBackFunc), null);
            
          
            
        }

        private void btn_reloadversion_Click(object sender, EventArgs e)
        {
            var str = string.Empty;
            try
            {
                bw_animation.RunWorkerAsync();
                var servers = new List<Server>();
                servers = SqlManager.GetInstance().GetData().ToList();
                var connection = new ConnectionManager();
                
                foreach (var server in servers)
                {
                    try
                    {
                        server.Version = connection.GetServerVersion(server.Connection);
                    }
                    catch (Exception ex)
                    {
                        str += server.Name + " " + server.Connection + ": " + ex.Message + '\n';
                        continue;
                    }
                }
                SqlManager.GetInstance().UpdateVersions(servers);
                bw_animation.CancelAsync();
            }
            catch (Exception ex)
            {
                bw_animation.CancelAsync();
                MessageBox.Show(ex.Message, "Ошибка");
            }
            finally
            {
                MessageBox.Show(str, "Info");
            }

        }

        private void btn_save_ico_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PathRMS = tb_rms.Text;
            Properties.Settings.Default.PathRMSico = tb_rms_ico.Text;
            Properties.Settings.Default.TimeStart = Convert.ToInt32(tb_timer.Text);

            Properties.Settings.Default.Save();
        }

        private void btn_opn_rms_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            //dialog.Filter = "Файлы csv|*.csv";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            tb_rms.Text = dialog.SelectedPath;
        }

        private void btn_opn_rms_ico_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            //dialog.Filter = "Файлы csv|*.csv";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            tb_rms_ico.Text = dialog.SelectedPath;
        }

        private void btn_create_ico_Click(object sender, EventArgs e)
        {
            ///перебрать все папки в Properties.Settings.Default.PathRMS
            ///искать файл BackOffice.exe, если в папке есть обозначение Chain установить флаг чейна
            ///если в папке нет нужного файла проверить есть ли папка Office -> искать в ней
            ///сохранить все пути к BackOffice.exe, флаг чейна, версию из свойства BackOffice.exe
            ///создать ярлыки в папке Properties.Settings.Default.PathRMSico с изменением имени файла и указанием версии


            ///рабочая версия 1 с поиском глубиной 2 при единичном включении
            //try
            //{
            //    btn_save_ico_Click(null, null);
            //    var backname = "BackOffice.exe";
            //    var backFolder = "Office";
            //    var backConfig = "Common.Settings.config";
            //    var folders = Directory.GetDirectories(tb_rms.Text);
            //    var fileRMS = new List<RMSico>();
            //    foreach (var folder in folders)
            //    {
            //        var files = Directory.GetFiles(folder);
            //        //var folderrms = Directory.GetDirectories(folder);
            //        var fiel = files.Where(data => data.Contains(backname));
            //        if (fiel.Count() == 0)
            //        {
            //            if (Directory.Exists(Path.Combine(folder, backFolder)))
            //            {
            //                fiel = Directory.GetFiles(Path.Combine(folder, backFolder)).Where(data => data.Contains(backname));
            //                if (fiel.Count() == 0)
            //                    continue;
            //                else
            //                {
            //                    var rms = GetFileInfo(fiel.First());
            //                    fileRMS.Add(rms);
            //                    CreateLink(rms.File, rms.ToString());
            //                    if (cb_xml_config.Checked)
            //                    {
            //                        RenamedXmlRMSConfig(Directory.GetFiles(Path.Combine(folder, backFolder)).Where(data => data.Contains(backConfig)).First(), rms.Version, rms.IsChain);


            //                    }
            //                }

            //            }
            //            else
            //                continue;
            //        }
            //        else
            //        {
            //            var rms = GetFileInfo(fiel.First());
            //            fileRMS.Add(rms);
            //            CreateLink(rms.File, rms.ToString());
            //            if (cb_xml_config.Checked)
            //            {
            //                RenamedXmlRMSConfig(Directory.GetFiles(folder).Where(data => data.Contains(backConfig)).First(), rms.Version, rms.IsChain);

            //            }
            //        }
            //    }
            //    MessageBox.Show($@"Ярлыки созданы в папке {tb_rms_ico.Text}");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Ошибка");
            //}


            ///версия 2 поиск по всем вложенным папкам
            
            try
            {
                btn_save_ico_Click(null, null);
                var backname = "BackOffice.exe";
                var files = Directory.GetFiles(tb_rms.Text, backname, SearchOption.AllDirectories);
                foreach (var item in files)
                {
                    var rms = GetFileInfo(item);
                    CreateLink(rms.File, rms.ToString());
                    
                }
                MessageBox.Show($@"Создано {files.Count()} ярлыков в папке {tb_rms_ico.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        ///получение всей информации из файла
        RMSico GetFileInfo(string path)
        {
            var version = FileVersionInfo.GetVersionInfo(path);
            return new RMSico(path,version.FileVersion);
        }
        void CreateLink(string SourceFile, string LinkName)
        {
            var WshShell = new IWshRuntimeLibrary.WshShell();
            var Shortcut = (IWshRuntimeLibrary.IWshShortcut)WshShell.CreateShortcut(Path.Combine(tb_rms_ico.Text, LinkName));
            Shortcut.TargetPath = SourceFile;
            Shortcut.IconLocation = SourceFile;
            Shortcut.Save();
        }
        void RenamedXmlRMSConfig(string xmlfile, string version, bool isChain, bool DEFAULT = false)
        {
            var doc = new XmlDocument();
            doc.Load(xmlfile);
            var settings = doc.GetElementsByTagName("setting");
            foreach (XmlNode setting in settings)
            {
                if (setting.Attributes["name"].Value == "RMS_EDITION_SUBPATH")
                    setting.FirstChild.InnerText = DEFAULT ? "Rms" :"Rms " + version;
                    
                if (setting.Attributes["name"].Value == "CHAIN_EDITION_SUBPATH")
                    setting.FirstChild.InnerText = DEFAULT ? "Chain" : "Chain " + version;
                  
            }
            doc.Save(xmlfile);

            //создание папок и файлов в %appdata%
            var path = isChain ? "Chain" : "Rms";
            if (DEFAULT)
            {
                path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\iiko\{path}\{Properties.Settings.Default.AltRunRMSFolder}\config";
                Directory.CreateDirectory(path);
                if (!File.Exists(Path.Combine(path, "backclient.config.xml")))
                {
                    doc = new XmlDocument();
                    doc.LoadXml(Properties.Resources.backclient_config);
                    doc.Save(Path.Combine(path, "backclient.config.xml"));
                }
            }
            else
            {
                path += " " + version;
                path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\iiko\{path}\Default\config";
                Directory.CreateDirectory(path);
                doc = new XmlDocument();
                doc.LoadXml(Properties.Resources.backclient_config);
                doc.Save(Path.Combine(path, "backclient.config.xml"));
            }
            
        }

        private void btn_replace_connection_Click(object sender, EventArgs e)
        {
            try
            {
                var error = string.Empty;
                var Servers = SqlManager.GetInstance().GetData().ToList();
                var servers_group = Servers.GroupBy(data => data.isChain);
                var folder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\iiko";

                foreach (var group in servers_group)
                {
                    var path = group.Key ? "Chain " : "Rms ";
                    var servers_version = group.GroupBy(data => data.Version);
                    foreach (var server in servers_version)
                    {
                        var path_current = path + server.Key;
                        if (!File.Exists($@"{folder}\{path_current}\Default\config\backclient.config.xml"))
                        {
                            error += $"Не найден экземпляр настройки для: {path_current}'\n'";
                            continue;
                        }
                        var doc = new XmlDocument();

                        
                        doc.Load($@"{folder}\{path_current}\Default\config\backclient.config.xml");
                        foreach (var serv in server)
                        {
                            var root = doc.DocumentElement;

                            var ServersList = doc.CreateElement("ServersList");
                            var ServerName = doc.CreateElement("ServerName");
                            var Version = doc.CreateElement("Version");
                            var ComputerName = doc.CreateElement("ComputerName");
                            var Protocol = doc.CreateElement("Protocol");
                            var ServerAddr = doc.CreateElement("ServerAddr");
                            var ServerSubUrl = doc.CreateElement("ServerSubUrl");
                            var Port = doc.CreateElement("Port");
                            var IsPresent = doc.CreateElement("IsPresent");

                            var ServerNameText = doc.CreateTextNode(serv.Name);
                            var VersionText = doc.CreateTextNode(serv.Version);
                            var str_connection = serv.Connection.Split(':');
                            var ProtocolText = doc.CreateTextNode(str_connection.First());
                            var ServerAddrText = doc.CreateTextNode(str_connection[1].Remove(0, 2));
                            var ServerSubUrlText = doc.CreateTextNode($@"/{serv.Connection.Split('/').Last()}");
                            var PortText = doc.CreateTextNode(str_connection[2].Remove(str_connection[2].LastIndexOf('/')));
                            var IsPresentText = doc.CreateTextNode("false");

                            ServerName.AppendChild(ServerNameText);
                            Version.AppendChild(VersionText);
                            Protocol.AppendChild(ProtocolText);
                            ServerAddr.AppendChild(ServerAddrText);
                            ServerSubUrl.AppendChild(ServerSubUrlText);
                            Port.AppendChild(PortText);
                            IsPresent.AppendChild(IsPresentText);

                            ServersList.AppendChild(ServerName);
                            ServersList.AppendChild(Version);
                            ServersList.AppendChild(ComputerName);
                            ServersList.AppendChild(Protocol);
                            ServersList.AppendChild(ServerAddr);
                            ServersList.AppendChild(ServerSubUrl);
                            ServersList.AppendChild(Port);
                            ServersList.AppendChild(IsPresent);

                            root.AppendChild(ServersList);
                        }
                        doc.Save($@"{folder}\{path_current}\Default\config\backclient.config.xml");
                    }
                }
                MessageBox.Show(string.Format(error), "Выполнено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void cb_alt_run_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AltRunRMS = cb_alt_run.Checked;
        }
        /// <summary>
        /// восстановить все пути создания данных рмс по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cansel_settings_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Properties.Settings.Default.AltRunRMS)
                {
                    MessageBox.Show("Альтернативный запуск RMS не используется", "Ошибка");
                    return;
                }
                btn_save_ico_Click(null, null);
                var backname = "BackOffice.exe";
                var backFolder = "Office";
                var backConfig = "Common.Settings.config";
                var folders = Directory.GetDirectories(tb_rms.Text);
                var fileRMS = new List<RMSico>();
                foreach (var folder in folders)
                {
                    var files = Directory.GetFiles(folder);
                    //var folderrms = Directory.GetDirectories(folder);
                    var fiel = files.Where(data => data.Contains(backname));
                    if (fiel.Count() == 0)
                    {
                        if (Directory.Exists(Path.Combine(folder, backFolder)))
                        {
                            fiel = Directory.GetFiles(Path.Combine(folder, backFolder)).Where(data => data.Contains(backname));
                            if (fiel.Count() == 0)
                                continue;
                            else
                            {
                                var rms = GetFileInfo(fiel.First());
                                fileRMS.Add(rms);
                                CreateLink(rms.File, rms.ToString());
                                RenamedXmlRMSConfig(Directory.GetFiles(
                                        Path.Combine(folder, backFolder)).Where(data => data.Contains(backConfig)).First(),
                                        rms.Version,
                                        rms.IsChain,
                                        Properties.Settings.Default.AltRunRMS
                                        );



                            }

                        }
                        else
                            continue;
                    }
                    else
                    {
                        var rms = GetFileInfo(fiel.First());
                        fileRMS.Add(rms);
                        CreateLink(rms.File, rms.ToString());
                        RenamedXmlRMSConfig(Directory.GetFiles(
                                         Path.Combine(folder)).Where(data => data.Contains(backConfig)).First(),
                                         rms.Version,
                                         rms.IsChain,
                                         Properties.Settings.Default.AltRunRMS
                                         );
                    }

                    
                }
                MessageBox.Show($@"Ярлыки созданы в папке {tb_rms_ico.Text}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btn_OpenDB_Click(object sender, EventArgs e)
        {
            var pathdb = Path.Combine(Directory.GetCurrentDirectory(), SqlManager.GetInstance().FolderDB, SqlManager.GetInstance().NameDB);
            try
            {
                
                Process.Start(pathdb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(pathdb + '\n' + ex.Message, "Ошибка при открытии файла");
            }
        }

        private void tb_timer_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_ValueOpen_Click(object sender, EventArgs e)
        {
            var servers = SqlManager.GetInstance().GetData();
            dg_DBValue.Rows.Clear();
            foreach (var server in servers)
            {
                dg_DBValue.Rows.Add(
                    server.Name,
                    server.Connection,
                    server.Version,
                    server.isChain,
                    server.coConnection,
                    server.Login,
                    server.Password);
            }
        }

        private void btn_ValueSave_Click(object sender, EventArgs e)
        {
            try
            {
                var servers = new List<Server>();
                //servers.AddRange(dg_D)
                foreach (DataGridViewRow row in dg_DBValue.Rows)
                {
                    //var Login = row.Cells["isChain"].Value ?? false;
                    servers.Add(new Server()
                    {
                        Name = row.Cells["name"].Value?.ToString() ?? "",
                        Connection = row.Cells["connection"].Value?.ToString() ?? "",
                        coConnection = row.Cells["coConnection"].Value?.ToString() ?? "",
                        isChain = (bool)(row.Cells["isChain"].Value ?? false),
                        Login = row.Cells["login"].Value?.ToString() ?? "",
                        Password = row.Cells["password"].Value?.ToString() ?? "",
                        Version = row.Cells["version"].Value?.ToString() ?? ""
                    });
                }
                servers.Remove(servers.Last());
                SqlManager.GetInstance().RemoveAll();
                SqlManager.GetInstance().Insert(servers);
                MessageBox.Show("База данных изменена", "Успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }

}
