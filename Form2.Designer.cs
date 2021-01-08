namespace Digital_Diary
{
    partial class DiaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiaryForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.changeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patchNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.localBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloudBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addImageButton = new System.Windows.Forms.Button();
            this.imagesTextBox = new System.Windows.Forms.TextBox();
            this.deleteImageButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripDropDownButton,
            this.toolsToolStripDropDownButton,
            this.helpToolStripDropDownButton,
            this.backupToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1139, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileToolStripDropDownButton
            // 
            this.fileToolStripDropDownButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.fileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripDropDownButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fileToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripDropDownButton.Image")));
            this.fileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileToolStripDropDownButton.Name = "fileToolStripDropDownButton";
            this.fileToolStripDropDownButton.Size = new System.Drawing.Size(64, 24);
            this.fileToolStripDropDownButton.Text = "Dosya";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.openToolStripMenuItem.Text = "Aç";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.saveToolStripMenuItem.Text = "Kaydet";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.clearToolStripMenuItem.Enabled = false;
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.clearToolStripMenuItem.Text = "Temizle";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolsToolStripDropDownButton
            // 
            this.toolsToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolsToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeInfoToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.changeFontSizeToolStripMenuItem});
            this.toolsToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("toolsToolStripDropDownButton.Image")));
            this.toolsToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolsToolStripDropDownButton.Name = "toolsToolStripDropDownButton";
            this.toolsToolStripDropDownButton.Size = new System.Drawing.Size(70, 24);
            this.toolsToolStripDropDownButton.Text = "Araçlar";
            // 
            // changeInfoToolStripMenuItem
            // 
            this.changeInfoToolStripMenuItem.Name = "changeInfoToolStripMenuItem";
            this.changeInfoToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.changeInfoToolStripMenuItem.Text = "Giriş Bilgilerini Değiştir";
            this.changeInfoToolStripMenuItem.Click += new System.EventHandler(this.changeInfoToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turkishToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.languageToolStripMenuItem.Text = "Dil";
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.turkishToolStripMenuItem.Text = "Türkçe";
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.turkishToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.englishToolStripMenuItem.Text = "İngilizce";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.otherColorsToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.themeToolStripMenuItem.Text = "Tema";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.darkToolStripMenuItem.Text = "Karanlık";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
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
            this.otherColorsToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.otherColorsToolStripMenuItem.Text = "Diğer Renk Seçenekleri";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.blueToolStripMenuItem.Text = "Mavi";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.greenToolStripMenuItem.Text = "Yeşil";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redToolStripMenuItem.Text = "Kırmızı";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.purpleToolStripMenuItem.Text = "Mor";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // changeFontSizeToolStripMenuItem
            // 
            this.changeFontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem10,
            this.toolStripMenuItem12,
            this.toolStripMenuItem14,
            this.toolStripMenuItem16,
            this.toolStripMenuItem18,
            this.toolStripMenuItem20});
            this.changeFontSizeToolStripMenuItem.Name = "changeFontSizeToolStripMenuItem";
            this.changeFontSizeToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.changeFontSizeToolStripMenuItem.Text = "Yazı Boyutu";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem8.Text = "8";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem10.Text = "10";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem12.Text = "12";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem14.Text = "14";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem16.Text = "16";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem18.Text = "18";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(108, 26);
            this.toolStripMenuItem20.Text = "20";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // helpToolStripDropDownButton
            // 
            this.helpToolStripDropDownButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.helpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.supportToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.patchNotesToolStripMenuItem,
            this.bugReportToolStripMenuItem,
            this.commentToolStripMenuItem});
            this.helpToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripDropDownButton.Image")));
            this.helpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripDropDownButton.Name = "helpToolStripDropDownButton";
            this.helpToolStripDropDownButton.Size = new System.Drawing.Size(69, 24);
            this.helpToolStripDropDownButton.Text = "Yardım";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.supportToolStripMenuItem.Text = "Geliştirici";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.updateToolStripMenuItem.Text = "Güncelleştirmeleri Denetle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // patchNotesToolStripMenuItem
            // 
            this.patchNotesToolStripMenuItem.Name = "patchNotesToolStripMenuItem";
            this.patchNotesToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.patchNotesToolStripMenuItem.Text = "Sürüm Notları";
            this.patchNotesToolStripMenuItem.Click += new System.EventHandler(this.patchNotesToolStripMenuItem_Click);
            // 
            // bugReportToolStripMenuItem
            // 
            this.bugReportToolStripMenuItem.Name = "bugReportToolStripMenuItem";
            this.bugReportToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.bugReportToolStripMenuItem.Text = "Hata Bildir";
            this.bugReportToolStripMenuItem.Click += new System.EventHandler(this.bugReportToolStripMenuItem_Click);
            // 
            // commentToolStripMenuItem
            // 
            this.commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            this.commentToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.commentToolStripMenuItem.Text = "Görüş Bildir ve Değerlendir";
            this.commentToolStripMenuItem.Click += new System.EventHandler(this.commentToolStripMenuItem_Click);
            // 
            // backupToolStripButton
            // 
            this.backupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backupToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localBackupToolStripMenuItem,
            this.cloudBackupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.backupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backupToolStripButton.Image")));
            this.backupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backupToolStripButton.Name = "backupToolStripButton";
            this.backupToolStripButton.Size = new System.Drawing.Size(74, 24);
            this.backupToolStripButton.Text = "Yedekle";
            // 
            // localBackupToolStripMenuItem
            // 
            this.localBackupToolStripMenuItem.Name = "localBackupToolStripMenuItem";
            this.localBackupToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.localBackupToolStripMenuItem.Text = "Yerel Yedekleme";
            this.localBackupToolStripMenuItem.Click += new System.EventHandler(this.localBackupToolStripMenuItem_Click);
            // 
            // cloudBackupToolStripMenuItem
            // 
            this.cloudBackupToolStripMenuItem.Enabled = false;
            this.cloudBackupToolStripMenuItem.Name = "cloudBackupToolStripMenuItem";
            this.cloudBackupToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.cloudBackupToolStripMenuItem.Text = "Bulut Yedekleme";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(202, 26);
            this.restoreToolStripMenuItem.Text = "Geri Yükle";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // diaryRichTextBox
            // 
            this.diaryRichTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.diaryRichTextBox.Location = new System.Drawing.Point(12, 104);
            this.diaryRichTextBox.Name = "diaryRichTextBox";
            this.diaryRichTextBox.Size = new System.Drawing.Size(1115, 542);
            this.diaryRichTextBox.TabIndex = 1;
            this.diaryRichTextBox.Text = "";
            this.diaryRichTextBox.TextChanged += new System.EventHandler(this.diaryRichTextBox_TextChanged);
            // 
            // addImageButton
            // 
            this.addImageButton.Location = new System.Drawing.Point(12, 59);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(131, 39);
            this.addImageButton.TabIndex = 2;
            this.addImageButton.Text = "Resim Ekle";
            this.addImageButton.UseVisualStyleBackColor = true;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // imagesTextBox
            // 
            this.imagesTextBox.Location = new System.Drawing.Point(149, 67);
            this.imagesTextBox.Name = "imagesTextBox";
            this.imagesTextBox.ReadOnly = true;
            this.imagesTextBox.Size = new System.Drawing.Size(935, 22);
            this.imagesTextBox.TabIndex = 3;
            // 
            // deleteImageButton
            // 
            this.deleteImageButton.Enabled = false;
            this.deleteImageButton.Location = new System.Drawing.Point(1090, 61);
            this.deleteImageButton.Name = "deleteImageButton";
            this.deleteImageButton.Size = new System.Drawing.Size(37, 35);
            this.deleteImageButton.TabIndex = 4;
            this.deleteImageButton.Text = "X";
            this.deleteImageButton.UseVisualStyleBackColor = true;
            this.deleteImageButton.Click += new System.EventHandler(this.deleteImageButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.TabStop = false;
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1139, 662);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.deleteImageButton);
            this.Controls.Add(this.imagesTextBox);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.diaryRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiaryForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dijital Günlük";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton helpToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.RichTextBox diaryRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patchNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolsToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem changeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button addImageButton;
        private System.Windows.Forms.TextBox imagesTextBox;
        private System.Windows.Forms.Button deleteImageButton;
        private System.Windows.Forms.ToolStripDropDownButton backupToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem cloudBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherColorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
    }
}