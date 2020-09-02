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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cb_protocol = new System.Windows.Forms.ComboBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.toolStrip_btn_Settings = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textBox1.Location = new System.Drawing.Point(5, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 23);
            this.textBox1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.treeView1.Location = new System.Drawing.Point(5, 37);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(273, 29);
            this.treeView1.TabIndex = 3;
            // 
            // cb_protocol
            // 
            this.cb_protocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_protocol.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.cb_protocol.FormattingEnabled = true;
            this.cb_protocol.Location = new System.Drawing.Point(5, 67);
            this.cb_protocol.Name = "cb_protocol";
            this.cb_protocol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_protocol.Size = new System.Drawing.Size(71, 23);
            this.cb_protocol.TabIndex = 4;
            // 
            // tb_server
            // 
            this.tb_server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_server.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tb_server.Location = new System.Drawing.Point(82, 67);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(100, 23);
            this.tb_server.TabIndex = 5;
            // 
            // tb_port
            // 
            this.tb_port.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tb_port.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.tb_port.Location = new System.Drawing.Point(189, 67);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(55, 23);
            this.tb_port.TabIndex = 6;
            this.tb_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_port_KeyPress);
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
            // 
            // toolStrip_btn_Settings
            // 
            this.toolStrip_btn_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_btn_Settings.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.toolStrip_btn_Settings.Image = global::QuickRMS.Properties.Resources.options;
            this.toolStrip_btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_btn_Settings.Name = "toolStrip_btn_Settings";
            this.toolStrip_btn_Settings.Size = new System.Drawing.Size(29, 20);
            this.toolStrip_btn_Settings.Text = "toolStrip_btn_Settings";
            this.toolStrip_btn_Settings.Click += new System.EventHandler(this.toolStrip_btn_Settings_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::QuickRMS.Properties.Resources.сheck;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatus.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatus.Text = "version";
            this.toolStripStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_btn_Settings,
            this.toolStripSplitButton1,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(5, 94);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(274, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.cb_protocol);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.pb_Search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(300, 160);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cb_protocol;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_btn_Settings;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}