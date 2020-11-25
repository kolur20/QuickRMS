namespace QuickRMS.Forms
{
    partial class License
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.pb_Server = new System.Windows.Forms.PictureBox();
            this.tv_servers = new System.Windows.Forms.TreeView();
            this.btn_SkipLicense = new System.Windows.Forms.Button();
            this.pb_License = new System.Windows.Forms.PictureBox();
            this.tb_License = new System.Windows.Forms.TextBox();
            this.tv_License = new System.Windows.Forms.TreeView();
            this.btn_OpenWeb = new System.Windows.Forms.Button();
            this.btn_RestartRabbit = new System.Windows.Forms.Button();
            this.dgv_connections = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_serverInfo = new System.Windows.Forms.TextBox();
            this.tb_Connection = new System.Windows.Forms.TextBox();
            this.btn_connection = new System.Windows.Forms.Button();
            this.btn_RefreshLicence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Server)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_License)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(38, 11);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(182, 23);
            this.tb_Server.TabIndex = 0;
            this.tb_Server.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Server_KeyUp);
            // 
            // pb_Server
            // 
            this.pb_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Server.Image = global::QuickRMS.Properties.Resources.search;
            this.pb_Server.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Server.InitialImage")));
            this.pb_Server.Location = new System.Drawing.Point(12, 11);
            this.pb_Server.MaximumSize = new System.Drawing.Size(20, 20);
            this.pb_Server.MinimumSize = new System.Drawing.Size(20, 20);
            this.pb_Server.Name = "pb_Server";
            this.pb_Server.Size = new System.Drawing.Size(20, 20);
            this.pb_Server.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Server.TabIndex = 3;
            this.pb_Server.TabStop = false;
            this.pb_Server.Click += new System.EventHandler(this.pb_Server_Click);
            // 
            // tv_servers
            // 
            this.tv_servers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_servers.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tv_servers.Location = new System.Drawing.Point(12, 40);
            this.tv_servers.Name = "tv_servers";
            this.tv_servers.Size = new System.Drawing.Size(208, 248);
            this.tv_servers.TabIndex = 4;
            this.tv_servers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_servers_AfterSelect);
            this.tv_servers.DoubleClick += new System.EventHandler(this.tv_servers_DoubleClick);
            // 
            // btn_SkipLicense
            // 
            this.btn_SkipLicense.Location = new System.Drawing.Point(226, 178);
            this.btn_SkipLicense.Name = "btn_SkipLicense";
            this.btn_SkipLicense.Size = new System.Drawing.Size(130, 46);
            this.btn_SkipLicense.TabIndex = 5;
            this.btn_SkipLicense.Text = "Сбросить выбранную";
            this.btn_SkipLicense.UseVisualStyleBackColor = true;
            this.btn_SkipLicense.Click += new System.EventHandler(this.btn_SkipLicense_Click);
            // 
            // pb_License
            // 
            this.pb_License.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_License.Image = global::QuickRMS.Properties.Resources.search;
            this.pb_License.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_License.InitialImage")));
            this.pb_License.Location = new System.Drawing.Point(226, 12);
            this.pb_License.MaximumSize = new System.Drawing.Size(20, 20);
            this.pb_License.MinimumSize = new System.Drawing.Size(20, 20);
            this.pb_License.Name = "pb_License";
            this.pb_License.Size = new System.Drawing.Size(20, 20);
            this.pb_License.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_License.TabIndex = 6;
            this.pb_License.TabStop = false;
            this.pb_License.Click += new System.EventHandler(this.pb_License_Click);
            // 
            // tb_License
            // 
            this.tb_License.Location = new System.Drawing.Point(252, 12);
            this.tb_License.Name = "tb_License";
            this.tb_License.Size = new System.Drawing.Size(253, 23);
            this.tb_License.TabIndex = 7;
            this.tb_License.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_License_KeyUp);
            // 
            // tv_License
            // 
            this.tv_License.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_License.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tv_License.Location = new System.Drawing.Point(226, 37);
            this.tv_License.Name = "tv_License";
            this.tv_License.ShowLines = false;
            this.tv_License.ShowPlusMinus = false;
            this.tv_License.ShowRootLines = false;
            this.tv_License.Size = new System.Drawing.Size(279, 135);
            this.tv_License.TabIndex = 8;
            // 
            // btn_OpenWeb
            // 
            this.btn_OpenWeb.Enabled = false;
            this.btn_OpenWeb.Location = new System.Drawing.Point(375, 230);
            this.btn_OpenWeb.Name = "btn_OpenWeb";
            this.btn_OpenWeb.Size = new System.Drawing.Size(130, 46);
            this.btn_OpenWeb.TabIndex = 9;
            this.btn_OpenWeb.Text = "Открыть веб интерфейс";
            this.btn_OpenWeb.UseVisualStyleBackColor = true;
            this.btn_OpenWeb.Click += new System.EventHandler(this.btn_OpenWeb_Click);
            // 
            // btn_RestartRabbit
            // 
            this.btn_RestartRabbit.Location = new System.Drawing.Point(375, 178);
            this.btn_RestartRabbit.Name = "btn_RestartRabbit";
            this.btn_RestartRabbit.Size = new System.Drawing.Size(130, 46);
            this.btn_RestartRabbit.TabIndex = 10;
            this.btn_RestartRabbit.Text = "Открыть iikoBizConnection";
            this.btn_RestartRabbit.UseVisualStyleBackColor = true;
            this.btn_RestartRabbit.Click += new System.EventHandler(this.btn_RestartRabbit_Click);
            // 
            // dgv_connections
            // 
            this.dgv_connections.AllowUserToAddRows = false;
            this.dgv_connections.AllowUserToDeleteRows = false;
            this.dgv_connections.AllowUserToResizeColumns = false;
            this.dgv_connections.AllowUserToResizeRows = false;
            this.dgv_connections.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_connections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.ID,
            this.ModuleName});
            this.dgv_connections.Location = new System.Drawing.Point(511, 12);
            this.dgv_connections.Name = "dgv_connections";
            this.dgv_connections.ReadOnly = true;
            this.dgv_connections.RowHeadersVisible = false;
            this.dgv_connections.Size = new System.Drawing.Size(301, 180);
            this.dgv_connections.TabIndex = 12;
            // 
            // Login
            // 
            this.Login.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            this.Login.Width = 65;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ModuleID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 90;
            // 
            // ModuleName
            // 
            this.ModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ModuleName.HeaderText = "ModuleName";
            this.ModuleName.Name = "ModuleName";
            this.ModuleName.ReadOnly = true;
            this.ModuleName.Width = 108;
            // 
            // tb_serverInfo
            // 
            this.tb_serverInfo.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tb_serverInfo.Location = new System.Drawing.Point(511, 198);
            this.tb_serverInfo.Multiline = true;
            this.tb_serverInfo.Name = "tb_serverInfo";
            this.tb_serverInfo.Size = new System.Drawing.Size(301, 119);
            this.tb_serverInfo.TabIndex = 13;
            // 
            // tb_Connection
            // 
            this.tb_Connection.Location = new System.Drawing.Point(12, 294);
            this.tb_Connection.Name = "tb_Connection";
            this.tb_Connection.Size = new System.Drawing.Size(234, 23);
            this.tb_Connection.TabIndex = 14;
            // 
            // btn_connection
            // 
            this.btn_connection.Location = new System.Drawing.Point(252, 284);
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Size = new System.Drawing.Size(104, 33);
            this.btn_connection.TabIndex = 15;
            this.btn_connection.Text = "Подключиться";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // btn_RefreshLicence
            // 
            this.btn_RefreshLicence.Location = new System.Drawing.Point(226, 232);
            this.btn_RefreshLicence.Name = "btn_RefreshLicence";
            this.btn_RefreshLicence.Size = new System.Drawing.Size(130, 46);
            this.btn_RefreshLicence.TabIndex = 16;
            this.btn_RefreshLicence.Text = "Обновить лицензии";
            this.btn_RefreshLicence.UseVisualStyleBackColor = true;
            this.btn_RefreshLicence.Click += new System.EventHandler(this.btn_RefreshLicence_Click);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 327);
            this.Controls.Add(this.btn_RefreshLicence);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.tb_Connection);
            this.Controls.Add(this.tb_serverInfo);
            this.Controls.Add(this.dgv_connections);
            this.Controls.Add(this.btn_RestartRabbit);
            this.Controls.Add(this.btn_OpenWeb);
            this.Controls.Add(this.tv_License);
            this.Controls.Add(this.tb_License);
            this.Controls.Add(this.pb_License);
            this.Controls.Add(this.btn_SkipLicense);
            this.Controls.Add(this.tv_servers);
            this.Controls.Add(this.pb_Server);
            this.Controls.Add(this.tb_Server);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Server)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_License)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.PictureBox pb_Server;
        private System.Windows.Forms.TreeView tv_servers;
        private System.Windows.Forms.Button btn_SkipLicense;
        private System.Windows.Forms.PictureBox pb_License;
        private System.Windows.Forms.TextBox tb_License;
        private System.Windows.Forms.TreeView tv_License;
        private System.Windows.Forms.Button btn_OpenWeb;
        private System.Windows.Forms.Button btn_RestartRabbit;
        private System.Windows.Forms.DataGridView dgv_connections;
        private System.Windows.Forms.TextBox tb_serverInfo;
        private System.Windows.Forms.TextBox tb_Connection;
        private System.Windows.Forms.Button btn_connection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModuleName;
        private System.Windows.Forms.Button btn_RefreshLicence;
    }
}