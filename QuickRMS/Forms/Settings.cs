using QuickRMS.Classes;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            var connection = new ConnectionManager();
            try
            {
                tb_strConnection.Text = connection.CheckConnectionSafe(tb_strConnection.Text);
                tb_version.Text = connection.GetServerVersion(tb_strConnection.Text);
            }
            catch (Exception)
            {
                tb_version.Text = "Ошибка";
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
                if (cb_removeAll.Checked)
                    SqlManager.GetInstance().RemoveAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return;
            }

        }

    }
}
