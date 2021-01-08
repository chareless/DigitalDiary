namespace Digital_Diary
{
    partial class InformationForm
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
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.nickNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.BackColor = System.Drawing.Color.DarkCyan;
            this.updateInfoButton.Location = new System.Drawing.Point(97, 217);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(193, 58);
            this.updateInfoButton.TabIndex = 0;
            this.updateInfoButton.Text = "BİLGİLERİ GÜNCELLE";
            this.updateInfoButton.UseVisualStyleBackColor = false;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // nickNameTextBox
            // 
            this.nickNameTextBox.Location = new System.Drawing.Point(97, 55);
            this.nickNameTextBox.Name = "nickNameTextBox";
            this.nickNameTextBox.Size = new System.Drawing.Size(193, 22);
            this.nickNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(97, 132);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(193, 22);
            this.passwordTextBox.TabIndex = 2;
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(374, 335);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nickNameTextBox);
            this.Controls.Add(this.updateInfoButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgileri Güncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.TextBox nickNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}