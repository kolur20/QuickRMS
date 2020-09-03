namespace QuickRMS.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_chain = new System.Windows.Forms.CheckBox();
            this.tb_co = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_strConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nameConnection = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_removeAll = new System.Windows.Forms.CheckBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cb_chain);
            this.groupBox1.Controls.Add(this.tb_co);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.btn_check);
            this.groupBox1.Controls.Add(this.tb_version);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_strConnection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_nameConnection);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление элемента в базу";
            // 
            // cb_chain
            // 
            this.cb_chain.AutoSize = true;
            this.cb_chain.Location = new System.Drawing.Point(324, 109);
            this.cb_chain.Name = "cb_chain";
            this.cb_chain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_chain.Size = new System.Drawing.Size(56, 20);
            this.cb_chain.TabIndex = 10;
            this.cb_chain.Text = "Чейн";
            this.cb_chain.UseVisualStyleBackColor = true;
            // 
            // tb_co
            // 
            this.tb_co.Location = new System.Drawing.Point(141, 80);
            this.tb_co.Name = "tb_co";
            this.tb_co.Size = new System.Drawing.Size(564, 23);
            this.tb_co.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Подключение к ЦО";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(602, 109);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(103, 40);
            this.btn_insert.TabIndex = 7;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(478, 109);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(103, 40);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "Проверить";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(141, 109);
            this.tb_version.Name = "tb_version";
            this.tb_version.ReadOnly = true;
            this.tb_version.Size = new System.Drawing.Size(149, 23);
            this.tb_version.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Версия";
            // 
            // tb_strConnection
            // 
            this.tb_strConnection.Location = new System.Drawing.Point(141, 51);
            this.tb_strConnection.Name = "tb_strConnection";
            this.tb_strConnection.Size = new System.Drawing.Size(564, 23);
            this.tb_strConnection.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Строка подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя подключения";
            // 
            // tb_nameConnection
            // 
            this.tb_nameConnection.Location = new System.Drawing.Point(141, 23);
            this.tb_nameConnection.Name = "tb_nameConnection";
            this.tb_nameConnection.Size = new System.Drawing.Size(564, 23);
            this.tb_nameConnection.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_import);
            this.groupBox2.Controls.Add(this.cb_removeAll);
            this.groupBox2.Location = new System.Drawing.Point(13, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Импорт";
            // 
            // cb_removeAll
            // 
            this.cb_removeAll.AutoSize = true;
            this.cb_removeAll.Location = new System.Drawing.Point(9, 22);
            this.cb_removeAll.Name = "cb_removeAll";
            this.cb_removeAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_removeAll.Size = new System.Drawing.Size(242, 20);
            this.cb_removeAll.TabIndex = 0;
            this.cb_removeAll.Text = "Удалить все данные перед импортом";
            this.cb_removeAll.UseVisualStyleBackColor = true;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(578, 220);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(127, 40);
            this.btn_import.TabIndex = 11;
            this.btn_import.Text = "Импортировать";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Настройки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_co;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_strConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nameConnection;
        private System.Windows.Forms.CheckBox cb_chain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.CheckBox cb_removeAll;
    }
}