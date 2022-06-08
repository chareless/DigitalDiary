namespace Digital_Diary
{
    partial class LoginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.nickNameTextBox = new System.Windows.Forms.TextBox();
            this.nickNameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.themeToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nickNameTextBox
            // 
            this.nickNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nickNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nickNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nickNameTextBox.Location = new System.Drawing.Point(134, 50);
            this.nickNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nickNameTextBox.Name = "nickNameTextBox";
            this.nickNameTextBox.Size = new System.Drawing.Size(106, 21);
            this.nickNameTextBox.TabIndex = 0;
            // 
            // nickNameLabel
            // 
            this.nickNameLabel.AutoSize = true;
            this.nickNameLabel.Location = new System.Drawing.Point(51, 52);
            this.nickNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nickNameLabel.Name = "nickNameLabel";
            this.nickNameLabel.Size = new System.Drawing.Size(64, 13);
            this.nickNameLabel.TabIndex = 1;
            this.nickNameLabel.Text = "Kullanıcı Adı";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Location = new System.Drawing.Point(51, 98);
            this.passLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(70, 13);
            this.passLabel.TabIndex = 2;
            this.passLabel.Text = "Kullanıcı Şifre";
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordTextBox2.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox2.Location = new System.Drawing.Point(134, 98);
            this.passwordTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(106, 21);
            this.passwordTextBox2.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkCyan;
            this.loginButton.Location = new System.Drawing.Point(148, 178);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 31);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "GİRİŞ";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DarkCyan;
            this.signInButton.Location = new System.Drawing.Point(25, 178);
            this.signInButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(105, 31);
            this.signInButton.TabIndex = 7;
            this.signInButton.Text = "KAYIT OL";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripDropDownButton,
            this.languageToolStripDropDownButton,
            this.reportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(286, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // themeToolStripDropDownButton
            // 
            this.themeToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.themeToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.otherColorsToolStripMenuItem});
            this.themeToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("themeToolStripDropDownButton.Image")));
            this.themeToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeToolStripDropDownButton.Name = "themeToolStripDropDownButton";
            this.themeToolStripDropDownButton.Size = new System.Drawing.Size(48, 22);
            this.themeToolStripDropDownButton.Text = "Tema";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.darkToolStripMenuItem.Text = "Karanlık";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.lightToolStripMenuItem.Text = "Aydınlık";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // otherColorsToolStripMenuItem
            // 
            this.otherColorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.redToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.otherColorsToolStripMenuItem.Name = "otherColorsToolStripMenuItem";
            this.otherColorsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.otherColorsToolStripMenuItem.Text = "Diğer Renk Seçenekleri";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.blueToolStripMenuItem.Text = "Mavi";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.greenToolStripMenuItem.Text = "Yeşil";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.redToolStripMenuItem.Text = "Kırmızı";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.purpleToolStripMenuItem.Text = "Mor";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // languageToolStripDropDownButton
            // 
            this.languageToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.languageToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turkishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("languageToolStripDropDownButton.Image")));
            this.languageToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.languageToolStripDropDownButton.Name = "languageToolStripDropDownButton";
            this.languageToolStripDropDownButton.Size = new System.Drawing.Size(34, 22);
            this.languageToolStripDropDownButton.Text = "Dil";
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.turkishToolStripMenuItem.Text = "Türkçe";
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.englishToolStripMenuItem.Text = "İngilizce";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // reportToolStripButton
            // 
            this.reportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.reportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripButton.Image")));
            this.reportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportToolStripButton.Name = "reportToolStripButton";
            this.reportToolStripButton.Size = new System.Drawing.Size(38, 22);
            this.reportToolStripButton.Text = "Bildir";
            this.reportToolStripButton.Click += new System.EventHandler(this.reportToolStripButton_Click);
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.Location = new System.Drawing.Point(134, 133);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(88, 17);
            this.showPassCheckBox.TabIndex = 10;
            this.showPassCheckBox.Text = "Şifreyi Göster";
            this.showPassCheckBox.UseVisualStyleBackColor = true;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showPassCheckBox_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(286, 251);
            this.Controls.Add(this.showPassCheckBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.nickNameLabel);
            this.Controls.Add(this.nickNameTextBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijital Günlük";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nickNameTextBox;
        private System.Windows.Forms.Label nickNameLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton themeToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton languageToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton reportToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem otherColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.CheckBox showPassCheckBox;
    }
}

