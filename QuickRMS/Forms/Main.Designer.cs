namespace QuickRMS.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_search = new System.Windows.Forms.TextBox();
            this.tv_servers = new System.Windows.Forms.TreeView();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.toolStrip_btn_check = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cms_icon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_close = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_version = new System.Windows.Forms.Label();
            this.лицензированиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_btn_Settings = new System.Windows.Forms.ToolStripSplitButton();
            this.лицензированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.cms_icon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.tb_search.Location = new System.Drawing.Point(5, 8);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(239, 24);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_search_KeyPress);
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // tv_servers
            // 
            this.tv_servers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_servers.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.tv_servers.Location = new System.Drawing.Point(5, 37);
            this.tv_servers.Name = "tv_servers";
            this.tv_servers.Size = new System.Drawing.Size(273, 83);
            this.tv_servers.TabIndex = 3;
            this.tv_servers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_servers_AfterSelect);
            this.tv_servers.DoubleClick += new System.EventHandler(this.tv_servers_DoubleClick);
            // 
            // tb_server
            // 
            this.tb_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_server.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tb_server.Location = new System.Drawing.Point(5, 121);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(190, 23);
            this.tb_server.TabIndex = 5;
            // 
            // pb_Search
            // 
            this.pb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Search.Image = global::QuickRMS.Properties.Resources.search;
            this.pb_Search.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_Search.InitialImage")));
            this.pb_Search.Location = new System.Drawing.Point(254, 8);
            this.pb_Search.MaximumSize = new System.Drawing.Size(20, 20);
            this.pb_Search.MinimumSize = new System.Drawing.Size(20, 20);
            this.pb_Search.Name = "pb_Search";
            this.pb_Search.Size = new System.Drawing.Size(20, 20);
            this.pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Search.TabIndex = 2;
            this.pb_Search.TabStop = false;
            this.pb_Search.Click += new System.EventHandler(this.pb_Search_Click);
            // 
            // toolStrip_btn_check
            // 
            this.toolStrip_btn_check.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btn_check.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лицензированиеToolStripMenuItem1});
            this.toolStrip_btn_check.Image = global::QuickRMS.Properties.Resources.сheck;
            this.toolStrip_btn_check.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btn_check.Name = "toolStrip_btn_check";
            this.toolStrip_btn_check.Size = new System.Drawing.Size(32, 20);
            this.toolStrip_btn_check.Text = "toolStripSplitButton1";
            this.toolStrip_btn_check.ButtonClick += new System.EventHandler(this.toolStrip_btn_check_ButtonClick);
            // 
            // toolStripVersion
            // 
            this.toolStripVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripVersion.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.toolStripVersion.Name = "toolStripVersion";
            this.toolStripVersion.Size = new System.Drawing.Size(49, 17);
            this.toolStripVersion.Text = "version";
            this.toolStripVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_btn_Settings,
            this.toolStrip_btn_check,
            this.toolStripVersion});
            this.statusStrip1.Location = new System.Drawing.Point(5, 148);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(274, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.cms_icon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "QuickRMS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // cms_icon
            // 
            this.cms_icon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_close});
            this.cms_icon.Name = "cms_icon";
            this.cms_icon.Size = new System.Drawing.Size(121, 26);
            // 
            // toolStripMenuItem_close
            // 
            this.toolStripMenuItem_close.Name = "toolStripMenuItem_close";
            this.toolStripMenuItem_close.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem_close.Text = "Закрыть";
            this.toolStripMenuItem_close.Click += new System.EventHandler(this.toolStripMenuItem_close_Click);
            // 
            // lb_version
            // 
            this.lb_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lb_version.Location = new System.Drawing.Point(201, 124);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(40, 16);
            this.lb_version.TabIndex = 6;
            this.lb_version.Text = "label1";
            this.lb_version.Click += new System.EventHandler(this.lb_version_Click);
            this.lb_version.DoubleClick += new System.EventHandler(this.lb_version_DoubleClick);
            // 
            // лицензированиеToolStripMenuItem1
            // 
            this.лицензированиеToolStripMenuItem1.Name = "лицензированиеToolStripMenuItem1";
            this.лицензированиеToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.лицензированиеToolStripMenuItem1.Text = "Лицензирование";
            // 
            // toolStrip_btn_Settings
            // 
            this.toolStrip_btn_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btn_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.лицензированиеToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.toolStrip_btn_Settings.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.toolStrip_btn_Settings.Image = global::QuickRMS.Properties.Resources.options;
            this.toolStrip_btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btn_Settings.Name = "toolStrip_btn_Settings";
            this.toolStrip_btn_Settings.Size = new System.Drawing.Size(32, 20);
            this.toolStrip_btn_Settings.Text = "toolStrip_btn_Settings";
            // 
            // лицензированиеToolStripMenuItem
            // 
            this.лицензированиеToolStripMenuItem.Name = "лицензированиеToolStripMenuItem";
            this.лицензированиеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.лицензированиеToolStripMenuItem.Text = "Лицензирование";
            this.лицензированиеToolStripMenuItem.Click += new System.EventHandler(this.лицензированиеToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            this.настройкиToolStripMenuItem.Click += new System.EventHandler(this.настройкиToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.tv_servers);
            this.Controls.Add(this.pb_Search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickRMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms_icon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.TreeView tv_servers;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.ToolStripSplitButton toolStrip_btn_check;
        private System.Windows.Forms.ToolStripStatusLabel toolStripVersion;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.ContextMenuStrip cms_icon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_close;
        private System.Windows.Forms.ToolStripMenuItem лицензированиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSplitButton toolStrip_btn_Settings;
        private System.Windows.Forms.ToolStripMenuItem лицензированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
    }
}