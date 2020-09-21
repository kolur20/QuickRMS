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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cb_chain = new System.Windows.Forms.CheckBox();
            this.tb_co = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_strConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nameConnection = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_reloadversion = new System.Windows.Forms.Button();
            this.btn_SaveDB = new System.Windows.Forms.Button();
            this.tb_namedb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_safeImport = new System.Windows.Forms.CheckBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.tb_instr = new System.Windows.Forms.TextBox();
            this.tb_importfile = new System.Windows.Forms.TextBox();
            this.btn_fileSelected = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.cb_removeAll = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_replace_connection = new System.Windows.Forms.Button();
            this.cb_xml_config = new System.Windows.Forms.CheckBox();
            this.btn_create_ico = new System.Windows.Forms.Button();
            this.btn_save_ico = new System.Windows.Forms.Button();
            this.btn_opn_rms_ico = new System.Windows.Forms.Button();
            this.tb_rms_ico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_opn_rms = new System.Windows.Forms.Button();
            this.tb_rms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bw_animation = new System.ComponentModel.BackgroundWorker();
            this.btn_cansel_settings = new System.Windows.Forms.Button();
            this.cb_alt_run = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 328);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btn_insert);
            this.tabPage1.Controls.Add(this.cb_chain);
            this.tabPage1.Controls.Add(this.tb_co);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btn_check);
            this.tabPage1.Controls.Add(this.tb_version);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tb_strConnection);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tb_nameConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Новое подключение";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(604, 96);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(103, 40);
            this.btn_insert.TabIndex = 18;
            this.btn_insert.Text = "Добавить";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cb_chain
            // 
            this.cb_chain.AutoSize = true;
            this.cb_chain.Location = new System.Drawing.Point(326, 96);
            this.cb_chain.Name = "cb_chain";
            this.cb_chain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_chain.Size = new System.Drawing.Size(56, 20);
            this.cb_chain.TabIndex = 21;
            this.cb_chain.Text = "Чейн";
            this.cb_chain.UseVisualStyleBackColor = true;
            // 
            // tb_co
            // 
            this.tb_co.Location = new System.Drawing.Point(143, 67);
            this.tb_co.Name = "tb_co";
            this.tb_co.Size = new System.Drawing.Size(564, 23);
            this.tb_co.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Подключение к ЦО";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(480, 96);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(103, 40);
            this.btn_check.TabIndex = 17;
            this.btn_check.Text = "Проверить";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_version
            // 
            this.tb_version.Location = new System.Drawing.Point(143, 96);
            this.tb_version.Name = "tb_version";
            this.tb_version.ReadOnly = true;
            this.tb_version.Size = new System.Drawing.Size(149, 23);
            this.tb_version.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Версия";
            // 
            // tb_strConnection
            // 
            this.tb_strConnection.Location = new System.Drawing.Point(143, 38);
            this.tb_strConnection.Name = "tb_strConnection";
            this.tb_strConnection.Size = new System.Drawing.Size(564, 23);
            this.tb_strConnection.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Строка подключения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя подключения";
            // 
            // tb_nameConnection
            // 
            this.tb_nameConnection.Location = new System.Drawing.Point(143, 10);
            this.tb_nameConnection.Name = "tb_nameConnection";
            this.tb_nameConnection.Size = new System.Drawing.Size(564, 23);
            this.tb_nameConnection.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btn_reloadversion);
            this.tabPage2.Controls.Add(this.btn_SaveDB);
            this.tabPage2.Controls.Add(this.tb_namedb);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Базы данных";
            // 
            // btn_reloadversion
            // 
            this.btn_reloadversion.Location = new System.Drawing.Point(481, 67);
            this.btn_reloadversion.Name = "btn_reloadversion";
            this.btn_reloadversion.Size = new System.Drawing.Size(227, 36);
            this.btn_reloadversion.TabIndex = 21;
            this.btn_reloadversion.Text = "Обновить все версии";
            this.btn_reloadversion.UseVisualStyleBackColor = true;
            this.btn_reloadversion.Click += new System.EventHandler(this.btn_reloadversion_Click);
            // 
            // btn_SaveDB
            // 
            this.btn_SaveDB.Location = new System.Drawing.Point(581, 14);
            this.btn_SaveDB.Name = "btn_SaveDB";
            this.btn_SaveDB.Size = new System.Drawing.Size(127, 36);
            this.btn_SaveDB.TabIndex = 20;
            this.btn_SaveDB.Text = "Сохранить";
            this.btn_SaveDB.UseVisualStyleBackColor = true;
            this.btn_SaveDB.Click += new System.EventHandler(this.btn_SaveDB_Click);
            // 
            // tb_namedb
            // 
            this.tb_namedb.Location = new System.Drawing.Point(327, 22);
            this.tb_namedb.Name = "tb_namedb";
            this.tb_namedb.Size = new System.Drawing.Size(204, 23);
            this.tb_namedb.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Имя базы данных (применится после перезагрузки)";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.cb_safeImport);
            this.tabPage3.Controls.Add(this.btn_help);
            this.tabPage3.Controls.Add(this.tb_instr);
            this.tabPage3.Controls.Add(this.tb_importfile);
            this.tabPage3.Controls.Add(this.btn_fileSelected);
            this.tabPage3.Controls.Add(this.btn_export);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btn_import);
            this.tabPage3.Controls.Add(this.cb_removeAll);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(716, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Импорт/Экспорт";
            // 
            // cb_safeImport
            // 
            this.cb_safeImport.AutoSize = true;
            this.cb_safeImport.Location = new System.Drawing.Point(416, 62);
            this.cb_safeImport.Name = "cb_safeImport";
            this.cb_safeImport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_safeImport.Size = new System.Drawing.Size(161, 20);
            this.cb_safeImport.TabIndex = 26;
            this.cb_safeImport.Text = "Умный импорт данных";
            this.cb_safeImport.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(583, 148);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(127, 40);
            this.btn_help.TabIndex = 25;
            this.btn_help.Text = "Подсказка";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // tb_instr
            // 
            this.tb_instr.Location = new System.Drawing.Point(17, 88);
            this.tb_instr.Multiline = true;
            this.tb_instr.Name = "tb_instr";
            this.tb_instr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_instr.Size = new System.Drawing.Size(560, 201);
            this.tb_instr.TabIndex = 24;
            // 
            // tb_importfile
            // 
            this.tb_importfile.Location = new System.Drawing.Point(17, 32);
            this.tb_importfile.Name = "tb_importfile";
            this.tb_importfile.Size = new System.Drawing.Size(560, 23);
            this.tb_importfile.TabIndex = 22;
            // 
            // btn_fileSelected
            // 
            this.btn_fileSelected.Location = new System.Drawing.Point(583, 22);
            this.btn_fileSelected.Name = "btn_fileSelected";
            this.btn_fileSelected.Size = new System.Drawing.Size(125, 33);
            this.btn_fileSelected.TabIndex = 21;
            this.btn_fileSelected.Text = "Обзор";
            this.btn_fileSelected.UseVisualStyleBackColor = true;
            this.btn_fileSelected.Click += new System.EventHandler(this.btn_fileSelected_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(583, 240);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(127, 40);
            this.btn_export.TabIndex = 23;
            this.btn_export.Text = "Экспортировать";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите csv файл для импорта";
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(583, 194);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(127, 40);
            this.btn_import.TabIndex = 19;
            this.btn_import.Text = "Импортировать";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // cb_removeAll
            // 
            this.cb_removeAll.AutoSize = true;
            this.cb_removeAll.Location = new System.Drawing.Point(17, 61);
            this.cb_removeAll.Name = "cb_removeAll";
            this.cb_removeAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_removeAll.Size = new System.Drawing.Size(242, 20);
            this.cb_removeAll.TabIndex = 18;
            this.cb_removeAll.Text = "Удалить все данные перед импортом";
            this.cb_removeAll.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.cb_alt_run);
            this.tabPage4.Controls.Add(this.btn_cansel_settings);
            this.tabPage4.Controls.Add(this.btn_replace_connection);
            this.tabPage4.Controls.Add(this.cb_xml_config);
            this.tabPage4.Controls.Add(this.btn_create_ico);
            this.tabPage4.Controls.Add(this.btn_save_ico);
            this.tabPage4.Controls.Add(this.btn_opn_rms_ico);
            this.tabPage4.Controls.Add(this.tb_rms_ico);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.btn_opn_rms);
            this.tabPage4.Controls.Add(this.tb_rms);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(716, 300);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ярлыки";
            // 
            // btn_replace_connection
            // 
            this.btn_replace_connection.Location = new System.Drawing.Point(382, 163);
            this.btn_replace_connection.Name = "btn_replace_connection";
            this.btn_replace_connection.Size = new System.Drawing.Size(160, 40);
            this.btn_replace_connection.TabIndex = 9;
            this.btn_replace_connection.Text = "Перезаписать подключения серверов";
            this.btn_replace_connection.UseVisualStyleBackColor = true;
            this.btn_replace_connection.Click += new System.EventHandler(this.btn_replace_connection_Click);
            // 
            // cb_xml_config
            // 
            this.cb_xml_config.AutoSize = true;
            this.cb_xml_config.Location = new System.Drawing.Point(12, 117);
            this.cb_xml_config.Name = "cb_xml_config";
            this.cb_xml_config.Size = new System.Drawing.Size(571, 20);
            this.cb_xml_config.TabIndex = 8;
            this.cb_xml_config.Text = "Применить генерацию конфигурационных файлов с изменением пути при создании ярлыко" +
    "в";
            this.cb_xml_config.UseVisualStyleBackColor = true;
            // 
            // btn_create_ico
            // 
            this.btn_create_ico.Location = new System.Drawing.Point(548, 163);
            this.btn_create_ico.Name = "btn_create_ico";
            this.btn_create_ico.Size = new System.Drawing.Size(160, 40);
            this.btn_create_ico.TabIndex = 7;
            this.btn_create_ico.Text = "Сгенерировать ярлыки";
            this.btn_create_ico.UseVisualStyleBackColor = true;
            this.btn_create_ico.Click += new System.EventHandler(this.btn_create_ico_Click);
            // 
            // btn_save_ico
            // 
            this.btn_save_ico.Location = new System.Drawing.Point(604, 117);
            this.btn_save_ico.Name = "btn_save_ico";
            this.btn_save_ico.Size = new System.Drawing.Size(104, 40);
            this.btn_save_ico.TabIndex = 6;
            this.btn_save_ico.Text = "Сохранить";
            this.btn_save_ico.UseVisualStyleBackColor = true;
            this.btn_save_ico.Click += new System.EventHandler(this.btn_save_ico_Click);
            // 
            // btn_opn_rms_ico
            // 
            this.btn_opn_rms_ico.Location = new System.Drawing.Point(604, 71);
            this.btn_opn_rms_ico.Name = "btn_opn_rms_ico";
            this.btn_opn_rms_ico.Size = new System.Drawing.Size(104, 40);
            this.btn_opn_rms_ico.TabIndex = 5;
            this.btn_opn_rms_ico.Text = "Обзор";
            this.btn_opn_rms_ico.UseVisualStyleBackColor = true;
            this.btn_opn_rms_ico.Click += new System.EventHandler(this.btn_opn_rms_ico_Click);
            // 
            // tb_rms_ico
            // 
            this.tb_rms_ico.Location = new System.Drawing.Point(12, 81);
            this.tb_rms_ico.Name = "tb_rms_ico";
            this.tb_rms_ico.Size = new System.Drawing.Size(586, 23);
            this.tb_rms_ico.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Расположение ярлыков";
            // 
            // btn_opn_rms
            // 
            this.btn_opn_rms.Location = new System.Drawing.Point(604, 25);
            this.btn_opn_rms.Name = "btn_opn_rms";
            this.btn_opn_rms.Size = new System.Drawing.Size(104, 40);
            this.btn_opn_rms.TabIndex = 2;
            this.btn_opn_rms.Text = "Обзор";
            this.btn_opn_rms.UseVisualStyleBackColor = true;
            this.btn_opn_rms.Click += new System.EventHandler(this.btn_opn_rms_Click);
            // 
            // tb_rms
            // 
            this.tb_rms.Location = new System.Drawing.Point(12, 35);
            this.tb_rms.Name = "tb_rms";
            this.tb_rms.Size = new System.Drawing.Size(586, 23);
            this.tb_rms.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Расположение бэков";
            // 
            // bw_animation
            // 
            this.bw_animation.WorkerSupportsCancellation = true;
            this.bw_animation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_animation_DoWork);
            // 
            // btn_cansel_settings
            // 
            this.btn_cansel_settings.Location = new System.Drawing.Point(12, 163);
            this.btn_cansel_settings.Name = "btn_cansel_settings";
            this.btn_cansel_settings.Size = new System.Drawing.Size(160, 40);
            this.btn_cansel_settings.TabIndex = 10;
            this.btn_cansel_settings.Text = "Восстановить файлы конфигураций";
            this.btn_cansel_settings.UseVisualStyleBackColor = true;
            this.btn_cansel_settings.Click += new System.EventHandler(this.btn_cansel_settings_Click);
            // 
            // cb_alt_run
            // 
            this.cb_alt_run.AutoSize = true;
            this.cb_alt_run.Location = new System.Drawing.Point(12, 209);
            this.cb_alt_run.Name = "cb_alt_run";
            this.cb_alt_run.Size = new System.Drawing.Size(213, 20);
            this.cb_alt_run.TabIndex = 11;
            this.cb_alt_run.Text = "Альтернативный запуск офисов";
            this.cb_alt_run.UseVisualStyleBackColor = true;
            this.cb_alt_run.CheckedChanged += new System.EventHandler(this.cb_alt_run_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 328);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cb_chain;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_reloadversion;
        private System.Windows.Forms.Button btn_SaveDB;
        private System.Windows.Forms.TextBox tb_namedb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.TextBox tb_instr;
        private System.Windows.Forms.TextBox tb_importfile;
        private System.Windows.Forms.Button btn_fileSelected;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.CheckBox cb_removeAll;
        private System.ComponentModel.BackgroundWorker bw_animation;
        private System.Windows.Forms.CheckBox cb_safeImport;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_save_ico;
        private System.Windows.Forms.Button btn_opn_rms_ico;
        private System.Windows.Forms.TextBox tb_rms_ico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_opn_rms;
        private System.Windows.Forms.TextBox tb_rms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_create_ico;
        private System.Windows.Forms.CheckBox cb_xml_config;
        private System.Windows.Forms.Button btn_replace_connection;
        private System.Windows.Forms.CheckBox cb_alt_run;
        private System.Windows.Forms.Button btn_cansel_settings;
    }
}