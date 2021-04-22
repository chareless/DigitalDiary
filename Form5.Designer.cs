
namespace Digital_Diary
{
    partial class UpdateForm
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.lastVersionLabel = new System.Windows.Forms.Label();
            this.lastVersionInfoLabel = new System.Windows.Forms.Label();
            this.currentVersionInfoLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionLabel.Location = new System.Drawing.Point(61, 175);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(137, 24);
            this.versionLabel.TabIndex = 19;
            this.versionLabel.Text = "Sürüm durumu";
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentVersionLabel.Location = new System.Drawing.Point(214, 54);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(71, 24);
            this.currentVersionLabel.TabIndex = 18;
            this.currentVersionLabel.Text = "Mevcut";
            // 
            // lastVersionLabel
            // 
            this.lastVersionLabel.AutoSize = true;
            this.lastVersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastVersionLabel.Location = new System.Drawing.Point(214, 106);
            this.lastVersionLabel.Name = "lastVersionLabel";
            this.lastVersionLabel.Size = new System.Drawing.Size(71, 24);
            this.lastVersionLabel.TabIndex = 17;
            this.lastVersionLabel.Text = "Güncel";
            // 
            // lastVersionInfoLabel
            // 
            this.lastVersionInfoLabel.AutoSize = true;
            this.lastVersionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastVersionInfoLabel.Location = new System.Drawing.Point(61, 106);
            this.lastVersionInfoLabel.Name = "lastVersionInfoLabel";
            this.lastVersionInfoLabel.Size = new System.Drawing.Size(147, 24);
            this.lastVersionInfoLabel.TabIndex = 16;
            this.lastVersionInfoLabel.Text = "Güncel Sürüm : ";
            // 
            // currentVersionInfoLabel
            // 
            this.currentVersionInfoLabel.AutoSize = true;
            this.currentVersionInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentVersionInfoLabel.Location = new System.Drawing.Point(61, 54);
            this.currentVersionInfoLabel.Name = "currentVersionInfoLabel";
            this.currentVersionInfoLabel.Size = new System.Drawing.Size(147, 24);
            this.currentVersionInfoLabel.TabIndex = 15;
            this.currentVersionInfoLabel.Text = "Mevcut Sürüm : ";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkCyan;
            this.updateButton.Location = new System.Drawing.Point(348, 166);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(145, 47);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "İndir";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(584, 302);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.lastVersionLabel);
            this.Controls.Add(this.lastVersionInfoLabel);
            this.Controls.Add(this.currentVersionInfoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güncellemeleri Denetle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Label lastVersionLabel;
        private System.Windows.Forms.Label lastVersionInfoLabel;
        private System.Windows.Forms.Label currentVersionInfoLabel;
        private System.Windows.Forms.Button updateButton;
    }
}