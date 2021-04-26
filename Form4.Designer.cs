namespace Digital_Diary
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.developerLabel = new System.Windows.Forms.Label();
            this.usageLabel = new System.Windows.Forms.Label();
            this.downPanel = new System.Windows.Forms.Panel();
            this.specificationsLabel = new System.Windows.Forms.Label();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.downPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.programNameLabel);
            this.topPanel.Location = new System.Drawing.Point(2, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(837, 118);
            this.topPanel.TabIndex = 0;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.programNameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.programNameLabel.Location = new System.Drawing.Point(8, 37);
            this.programNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(256, 31);
            this.programNameLabel.TabIndex = 0;
            this.programNameLabel.Text = "Dijital Günlük v1.6.2";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.Location = new System.Drawing.Point(10, 132);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(91, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Dijital Günlük";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionLabel.Location = new System.Drawing.Point(10, 158);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(89, 17);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Sürüm: 1.6.2";
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.developerLabel.Location = new System.Drawing.Point(10, 183);
            this.developerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(191, 17);
            this.developerLabel.TabIndex = 3;
            this.developerLabel.Text = "© 2020-2021 Deniz Sarıbayır";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usageLabel.Location = new System.Drawing.Point(10, 236);
            this.usageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(173, 24);
            this.usageLabel.TabIndex = 5;
            this.usageLabel.Text = "Kullanım Özellikleri:";
            // 
            // downPanel
            // 
            this.downPanel.BackColor = System.Drawing.Color.White;
            this.downPanel.Controls.Add(this.specificationsLabel);
            this.downPanel.Location = new System.Drawing.Point(10, 262);
            this.downPanel.Margin = new System.Windows.Forms.Padding(2);
            this.downPanel.Name = "downPanel";
            this.downPanel.Size = new System.Drawing.Size(818, 182);
            this.downPanel.TabIndex = 8;
            // 
            // specificationsLabel
            // 
            this.specificationsLabel.AutoSize = true;
            this.specificationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.specificationsLabel.Location = new System.Drawing.Point(2, 11);
            this.specificationsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.specificationsLabel.Name = "specificationsLabel";
            this.specificationsLabel.Size = new System.Drawing.Size(808, 102);
            this.specificationsLabel.TabIndex = 7;
            this.specificationsLabel.Text = resources.GetString("specificationsLabel.Text");
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.licenseLabel.Location = new System.Drawing.Point(11, 207);
            this.licenseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(134, 17);
            this.licenseLabel.TabIndex = 9;
            this.licenseLabel.Text = "Tüm hakları saklıdır.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 453);
            this.Controls.Add(this.licenseLabel);
            this.Controls.Add(this.downPanel);
            this.Controls.Add(this.usageLabel);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijital Günlük Hakkında";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.downPanel.ResumeLayout(false);
            this.downPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.Panel downPanel;
        private System.Windows.Forms.Label specificationsLabel;
        private System.Windows.Forms.Label licenseLabel;
    }
}