namespace QuickRMS.Forms
{
    partial class Wait
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
            this.pb_wait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_wait)).BeginInit();
            this.SuspendLayout();
            
            // 
            // pb_wait
            // 
            this.pb_wait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_wait.Image = global::QuickRMS.Properties.Resources.loading_bar;
            this.pb_wait.Location = new System.Drawing.Point(0, 0);
            this.pb_wait.Name = "pb_wait";
            this.pb_wait.Size = new System.Drawing.Size(434, 50);
            this.pb_wait.TabIndex = 0;
            this.pb_wait.TabStop = false;
            this.pb_wait.Enabled = true;
            this.pb_wait.Visible = true;
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 50);
            this.Controls.Add(this.pb_wait);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Wait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подождите";
            ((System.ComponentModel.ISupportInitialize)(this.pb_wait)).EndInit();
            this.ResumeLayout(true);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_wait;
    }
}