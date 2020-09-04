using QuickRMS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickRMS.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            tb_namedb.Text = Properties.Settings.Default.NameDataBase;

            btn_help_Click(null, null);

            pb_load.Enabled = pb_load.Visible = false;

        }



        private void btn_check_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            try
            {
                bw_animation.RunWorkerAsync();

                tb_strConnection.Text = connection.CheckConnectionSafe(tb_strConnection.Text);
                tb_version.Text = connection.GetServerVersion(tb_strConnection.Text);

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
            try
            {
                SqlManager.GetInstance().Insert(server);
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
                        tb_instr.Text += $"Ошибка: {server.Name}\n";
                    }
                }

                foreach (var kill in killServers)
                    servers.RemoveAt(servers.FindIndex(data => data.Name == kill));
                
                //очистка записей в бд при необходимости
                if (cb_removeAll.Checked)
                    SqlManager.GetInstance().RemoveAll();
                //запись новых данных в бд
                SqlManager.GetInstance().Insert(servers);
                tb_instr.Text += $"Импортировано: {servers.Count} из {servers.Count + killServers.Count}\n";

                bw_animation.CancelAsync();
            }
            catch (Exception ex)
            {
                tb_instr.Text += $"Фатальная ошибка при импорте\n";
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
            var file = "RMS_ServerConnections.csv";
            tb_instr.Clear();
            try
            {

                var csv = new CsvManager();
                csv.Export(file, SqlManager.GetInstance().GetData());
                tb_instr.Text += $"Успешный экспорт файла {file}\n";
                
                bw_animation.CancelAsync();
            }
            catch (Exception ex)
            {
                
                tb_instr.Text += $"Ошибка при экспорте файла {file}\n";
                MessageBox.Show(ex.Message, "Ошибка");

                bw_animation.CancelAsync();
            }
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
            
            while (!bw_animation.CancellationPending)
            {
                PictureAnimation(true);
                //for (var i=0; i < 1000; i++) { }
            }
            PictureAnimation(false);
        }

        private void PictureAnimation(bool animation)
        {

            if (InvokeRequired)
                Invoke((Action<bool>)PictureAnimation, animation);
            else
                pb_load.Enabled = pb_load.Visible = animation;
        }
    }
}
