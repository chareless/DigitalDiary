using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static Digital_Diary.Functions;

namespace Digital_Diary
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();

            themeControl();
            languageControl();
            if (themeGet() == "dark")
            {
                colorDark();
            }
            if(themeGet() =="light")
            {
                colorLight();
            }
            if (themeGet() == "blue")
            {
                colorBlue();
            }
            if(themeGet() =="green")
            {
                colorGreen();
            }
            if (themeGet() == "red")
            {
                colorRed();
            }
            if (themeGet() == "purple")
            {
                colorPurple();
            }
            menuNames();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(title[5], "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                diaryRichTextBox.Text = "";
                clearToolStripMenuItem.Enabled = false;
            }
            if (dialog == DialogResult.No)
                diaryRichTextBox.Text = diaryRichTextBox.Text;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateSet(dateTimePicker1.Value.ToShortDateString());
            Directory.CreateDirectory(filePath+date);
            themeControl();
            passwordControl();
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = filePath+date;
            file.Filter = title[20];
            file.CheckFileExists = false;
            file.Title = title[9];
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string DosyaYolu = file.FileName;
                FileStream fs = new FileStream(DosyaYolu, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(File.OpenRead(DosyaYolu));
                string yazi = sr.ReadToEnd();
                yazi = DecryptText(yazi, "chareless");
                if (yazi == nickNameGet() + " " + passGet())
                {
                    MessageBox.Show(title[10]);
                }
                else
                {
                    diaryRichTextBox.Text = yazi;
                    sr.Close();
                    fs.Close();
                }
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateSet(dateTimePicker1.Value.ToShortDateString());
            if (diaryRichTextBox.Text != "" && imageCounter != 0)
            {
                saveAll(diaryRichTextBox.Text);
                saveImage();
                if(delCounter==0)
                {
                    deleteImageButton.Enabled = false;
                    saveToolStripMenuItem.Enabled = false;
                }
            }
            else if (diaryRichTextBox.Text != "" && imageCounter == 0)
            {
                saveAll(diaryRichTextBox.Text);
            }
            else if (diaryRichTextBox.Text == "" && imageCounter != 0)
            {
                saveImage();
                if (delCounter == 0)
                {
                    deleteImageButton.Enabled = false;
                    saveToolStripMenuItem.Enabled = false;
                    clearToolStripMenuItem.Enabled = false;
                }
            }
            imagesTextBox.Text = "";
            for (int i = 0; i < imageCounter; i++)
            {
                imagesTextBox.Text += Path.GetFileNameWithoutExtension(myFile[i]) + " | ";
            }
        }
        private void addImageButton_Click(object sender, EventArgs e)
        {
            if (imageCounter != 10)
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = title[19];
                file.InitialDirectory = desktopPath;
                file.CheckFileExists = false;
                file.Title = title[17];
                file.Multiselect = false;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    myFile[imageCounter] = file.FileName;
                    imagesTextBox.Text += Path.GetFileNameWithoutExtension(myFile[imageCounter]) + " | ";
                    imageCounter++;
                    saveToolStripMenuItem.Enabled = true;
                    deleteImageButton.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(title[18]);
            }
        }
        private void deleteImageButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show(title[21], "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (imagesTextBox.Text == "" && diaryRichTextBox.Text == "")
                {
                    saveToolStripMenuItem.Enabled = false;
                    clearToolStripMenuItem.Enabled = false;
                    deleteImageButton.Enabled = false;
                }
                Array.Clear(myFile, 0, 10);
                imageCounter = 0;
                imagesTextBox.Text = "";
                if (imageCounter == 0 && diaryRichTextBox.Text == "")
                {
                    saveToolStripMenuItem.Enabled = false;
                    clearToolStripMenuItem.Enabled = false;
                    deleteImageButton.Enabled = false;
                }
                deleteImageButton.Enabled = false;
            }
        }
        private void diaryRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if ((diaryRichTextBox.Text != "" || diaryRichTextBox.Text == null) || imageCounter != 0)
            {
                saveToolStripMenuItem.Enabled = true;
                clearToolStripMenuItem.Enabled = true;
                if ((diaryRichTextBox.Text == "" || diaryRichTextBox.Text == null))
                {
                    clearToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                saveToolStripMenuItem.Enabled = false;
                clearToolStripMenuItem.Enabled = false;
            }
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/#contact");
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/dijitalgunluk.html#version");
        }
        private void patchNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/dijitalgunluk.html#update");
        }
        private void changeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm f3 = new InformationForm();
            f3.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f4 = new AboutForm();
            f4.ShowDialog();
        }
        private void localBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(logPath))
            {
                Directory.CreateDirectory(desktopPath + "\\backups");
                foreach (string dirPath in Directory.GetDirectories(logPath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(logPath, backupPath));

                foreach (string newPath in Directory.GetFiles(logPath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(logPath, backupPath), true);
                MessageBox.Show(title[23]);
            }
            else
            {
                MessageBox.Show(title[22]);
            }
        }
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(backupPath))
            {
                Directory.CreateDirectory(logPath);
            }
            
            if (Directory.Exists(backupPath))
            {
                foreach (string dirPath in Directory.GetDirectories(backupPath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(backupPath, logPath));

                foreach (string newPath in Directory.GetFiles(backupPath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(backupPath, logPath), true);
                MessageBox.Show(title[24]);
            }
            else
            {
                MessageBox.Show(title[22]);
            }
        }
        private void bugReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/#contact");
        }
        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.denizsaribayir.cf/blog.html#yorum");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 8);
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 10);
        }
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 12);
        }
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 14);
        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 16);
        }
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 18);
        }
        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            diaryRichTextBox.SelectionFont = new Font("Microsoft Sans Serif", 20);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("dark",languageGet());
            colorDark();
            secret();
        }
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("light",languageGet());
            colorLight();
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("blue", languageGet());
            colorBlue();
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("green", languageGet());
            colorGreen();
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("red", languageGet());
            colorRed();
        }
        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("purple", languageGet());
            colorPurple();
        }
        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageTurkish();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageEnglish();
        }

        private void colorDark()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTableDark());
            fileToolStripDropDownButton.BackColor = Color.FromArgb(64, 64, 64);
            helpToolStripDropDownButton.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.ForeColor = Color.White;
            openToolStripMenuItem.ForeColor = Color.White;
            saveToolStripMenuItem.ForeColor = Color.White;
            fileToolStripDropDownButton.ForeColor = Color.White;
            toolsToolStripDropDownButton.ForeColor = Color.White;
            helpToolStripDropDownButton.ForeColor = Color.White;
            aboutToolStripMenuItem.ForeColor = Color.White;
            supportToolStripMenuItem.ForeColor = Color.White;
            updateToolStripMenuItem.ForeColor = Color.White;
            patchNotesToolStripMenuItem.ForeColor = Color.White;
            changeInfoToolStripMenuItem.ForeColor = Color.White;
            languageToolStripMenuItem.ForeColor = Color.White;
            themeToolStripMenuItem.ForeColor = Color.White;
            turkishToolStripMenuItem.ForeColor = Color.White;
            englishToolStripMenuItem.ForeColor = Color.White;
            darkToolStripMenuItem.ForeColor = Color.White;
            lightToolStripMenuItem.ForeColor = Color.White;
            clearToolStripMenuItem.ForeColor = Color.White;
            changeFontSizeToolStripMenuItem.ForeColor = Color.White;
            toolStripMenuItem8.ForeColor = Color.White;
            toolStripMenuItem10.ForeColor = Color.White;
            toolStripMenuItem12.ForeColor = Color.White;
            toolStripMenuItem14.ForeColor = Color.White;
            toolStripMenuItem16.ForeColor = Color.White;
            toolStripMenuItem18.ForeColor = Color.White;
            toolStripMenuItem20.ForeColor = Color.White;
            diaryRichTextBox.BackColor = Color.Black;
            diaryRichTextBox.ForeColor = Color.White;
            backupToolStripButton.ForeColor = Color.White;
            localBackupToolStripMenuItem.ForeColor = Color.White;
            cloudBackupToolStripMenuItem.ForeColor = Color.White;
            bugReportToolStripMenuItem.ForeColor = Color.White;
            restoreToolStripMenuItem.ForeColor = Color.White;
            imagesTextBox.ForeColor = Color.White;
            imagesTextBox.BackColor = Color.Black;
            commentToolStripMenuItem.ForeColor = Color.White;
            otherColorsToolStripMenuItem.ForeColor = Color.White;
            blueToolStripMenuItem.ForeColor = Color.White;
            greenToolStripMenuItem.ForeColor = Color.White;
            redToolStripMenuItem.ForeColor = Color.White;
            purpleToolStripMenuItem.ForeColor = Color.White;
        }
        private void colorLight()
        {
            this.BackColor = Color.Azure;
            toolStrip1.BackColor = Color.PaleTurquoise;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTableLight());
            fileToolStripDropDownButton.BackColor = Color.PaleTurquoise;
            helpToolStripDropDownButton.BackColor = Color.PaleTurquoise;
            toolStrip1.ForeColor = Color.Black;
            openToolStripMenuItem.ForeColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripDropDownButton.ForeColor = Color.Black;
            toolsToolStripDropDownButton.ForeColor = Color.Black;
            helpToolStripDropDownButton.ForeColor = Color.Black;
            aboutToolStripMenuItem.ForeColor = Color.Black;
            supportToolStripMenuItem.ForeColor = Color.Black;
            updateToolStripMenuItem.ForeColor = Color.Black;
            patchNotesToolStripMenuItem.ForeColor = Color.Black;
            changeInfoToolStripMenuItem.ForeColor = Color.Black;
            languageToolStripMenuItem.ForeColor = Color.Black;
            themeToolStripMenuItem.ForeColor = Color.Black;
            turkishToolStripMenuItem.ForeColor = Color.Black;
            englishToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            clearToolStripMenuItem.ForeColor = Color.Black;
            changeFontSizeToolStripMenuItem.ForeColor = Color.Black;
            toolStripMenuItem8.ForeColor = Color.Black;
            toolStripMenuItem10.ForeColor = Color.Black;
            toolStripMenuItem12.ForeColor = Color.Black;
            toolStripMenuItem14.ForeColor = Color.Black;
            toolStripMenuItem16.ForeColor = Color.Black;
            toolStripMenuItem18.ForeColor = Color.Black;
            toolStripMenuItem20.ForeColor = Color.Black;
            diaryRichTextBox.BackColor = Color.LightSteelBlue;
            diaryRichTextBox.ForeColor = Color.Black;
            backupToolStripButton.ForeColor = Color.Black;
            localBackupToolStripMenuItem.ForeColor = Color.Black;
            cloudBackupToolStripMenuItem.ForeColor = Color.Black;
            bugReportToolStripMenuItem.ForeColor = Color.Black;
            restoreToolStripMenuItem.ForeColor = Color.Black;
            imagesTextBox.ForeColor = SystemColors.WindowText;
            imagesTextBox.BackColor = SystemColors.Control;
            commentToolStripMenuItem.ForeColor = Color.Black;
            otherColorsToolStripMenuItem.ForeColor = Color.Black;
            blueToolStripMenuItem.ForeColor = Color.Black;
            greenToolStripMenuItem.ForeColor = Color.Black;
            redToolStripMenuItem.ForeColor = Color.Black;
            purpleToolStripMenuItem.ForeColor = Color.Black;
        }
        private void colorBlue()
        {
            this.BackColor = Color.DarkCyan;
            toolStrip1.BackColor = Color.DarkSlateGray;
            toolStrip1.ForeColor = Color.PaleTurquoise;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTableBlue());
            fileToolStripDropDownButton.BackColor = Color.DarkSlateGray;
            helpToolStripDropDownButton.BackColor = Color.DarkSlateGray;
            toolStrip1.ForeColor= Color.PaleTurquoise;
            openToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            saveToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            fileToolStripDropDownButton.ForeColor= Color.PaleTurquoise;
            toolsToolStripDropDownButton.ForeColor= Color.PaleTurquoise;
            helpToolStripDropDownButton.ForeColor= Color.PaleTurquoise;
            aboutToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            supportToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            updateToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            patchNotesToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            changeInfoToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            languageToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            themeToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            turkishToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            englishToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            darkToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            lightToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            clearToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            changeFontSizeToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem8.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem10.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem12.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem14.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem16.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem18.ForeColor= Color.PaleTurquoise;
            toolStripMenuItem20.ForeColor= Color.PaleTurquoise;
            diaryRichTextBox.BackColor = Color.CadetBlue;
            diaryRichTextBox.ForeColor= Color.Black;
            backupToolStripButton.ForeColor= Color.PaleTurquoise;
            localBackupToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            cloudBackupToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            bugReportToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            restoreToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            imagesTextBox.ForeColor = SystemColors.WindowText;
            imagesTextBox.BackColor = SystemColors.Control;
            commentToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            otherColorsToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            blueToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            greenToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            redToolStripMenuItem.ForeColor= Color.PaleTurquoise;
            purpleToolStripMenuItem.ForeColor= Color.PaleTurquoise;
        }
        private void colorGreen()
        {
            this.BackColor = Color.LawnGreen;
            toolStrip1.BackColor = Color.LimeGreen;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTableGreen());
            fileToolStripDropDownButton.BackColor = Color.LimeGreen;
            helpToolStripDropDownButton.BackColor = Color.LimeGreen;
            toolStrip1.ForeColor = Color.Black;
            openToolStripMenuItem.ForeColor = Color.Black;
            saveToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripDropDownButton.ForeColor = Color.Black;
            toolsToolStripDropDownButton.ForeColor = Color.Black;
            helpToolStripDropDownButton.ForeColor = Color.Black;
            aboutToolStripMenuItem.ForeColor = Color.Black;
            supportToolStripMenuItem.ForeColor = Color.Black;
            updateToolStripMenuItem.ForeColor = Color.Black;
            patchNotesToolStripMenuItem.ForeColor = Color.Black;
            changeInfoToolStripMenuItem.ForeColor = Color.Black;
            languageToolStripMenuItem.ForeColor = Color.Black;
            themeToolStripMenuItem.ForeColor = Color.Black;
            turkishToolStripMenuItem.ForeColor = Color.Black;
            englishToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            clearToolStripMenuItem.ForeColor = Color.Black;
            changeFontSizeToolStripMenuItem.ForeColor = Color.Black;
            toolStripMenuItem8.ForeColor = Color.Black;
            toolStripMenuItem10.ForeColor = Color.Black;
            toolStripMenuItem12.ForeColor = Color.Black;
            toolStripMenuItem14.ForeColor = Color.Black;
            toolStripMenuItem16.ForeColor = Color.Black;
            toolStripMenuItem18.ForeColor = Color.Black;
            toolStripMenuItem20.ForeColor = Color.Black;
            diaryRichTextBox.BackColor = Color.LightGreen;
            diaryRichTextBox.ForeColor = Color.Black;
            backupToolStripButton.ForeColor = Color.Black;
            localBackupToolStripMenuItem.ForeColor = Color.Black;
            cloudBackupToolStripMenuItem.ForeColor = Color.Black;
            bugReportToolStripMenuItem.ForeColor = Color.Black;
            restoreToolStripMenuItem.ForeColor = Color.Black;
            imagesTextBox.ForeColor = SystemColors.WindowText;
            imagesTextBox.BackColor = SystemColors.Control;
            commentToolStripMenuItem.ForeColor = Color.Black;
            otherColorsToolStripMenuItem.ForeColor = Color.Black;
            blueToolStripMenuItem.ForeColor = Color.Black;
            greenToolStripMenuItem.ForeColor = Color.Black;
            redToolStripMenuItem.ForeColor = Color.Black;
            purpleToolStripMenuItem.ForeColor = Color.Black;
        }
        private void colorRed()
        {
            this.BackColor = Color.Firebrick;
            toolStrip1.BackColor = Color.DarkRed;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTableRed());
            fileToolStripDropDownButton.BackColor = Color.DarkRed;
            helpToolStripDropDownButton.BackColor = Color.DarkRed;
            toolStrip1.ForeColor = Color.Gold;
            openToolStripMenuItem.ForeColor = Color.Gold;
            saveToolStripMenuItem.ForeColor = Color.Gold;
            fileToolStripDropDownButton.ForeColor = Color.Gold;
            toolsToolStripDropDownButton.ForeColor = Color.Gold;
            helpToolStripDropDownButton.ForeColor = Color.Gold;
            aboutToolStripMenuItem.ForeColor = Color.Gold;
            supportToolStripMenuItem.ForeColor = Color.Gold;
            updateToolStripMenuItem.ForeColor = Color.Gold;
            patchNotesToolStripMenuItem.ForeColor = Color.Gold;
            changeInfoToolStripMenuItem.ForeColor = Color.Gold;
            languageToolStripMenuItem.ForeColor = Color.Gold;
            themeToolStripMenuItem.ForeColor = Color.Gold;
            turkishToolStripMenuItem.ForeColor = Color.Gold;
            englishToolStripMenuItem.ForeColor = Color.Gold;
            darkToolStripMenuItem.ForeColor = Color.Gold;
            lightToolStripMenuItem.ForeColor = Color.Gold;
            clearToolStripMenuItem.ForeColor = Color.Gold;
            changeFontSizeToolStripMenuItem.ForeColor = Color.Gold;
            toolStripMenuItem8.ForeColor = Color.Gold;
            toolStripMenuItem10.ForeColor = Color.Gold;
            toolStripMenuItem12.ForeColor = Color.Gold;
            toolStripMenuItem14.ForeColor = Color.Gold;
            toolStripMenuItem16.ForeColor = Color.Gold;
            toolStripMenuItem18.ForeColor = Color.Gold;
            toolStripMenuItem20.ForeColor = Color.Gold;
            diaryRichTextBox.BackColor = Color.LightCoral;
            diaryRichTextBox.ForeColor = Color.Black;
            backupToolStripButton.ForeColor = Color.Gold;
            localBackupToolStripMenuItem.ForeColor = Color.Gold;
            cloudBackupToolStripMenuItem.ForeColor = Color.Gold;
            bugReportToolStripMenuItem.ForeColor = Color.Gold;
            restoreToolStripMenuItem.ForeColor = Color.Gold;
            imagesTextBox.ForeColor = SystemColors.WindowText;
            imagesTextBox.BackColor = SystemColors.Control;
            commentToolStripMenuItem.ForeColor = Color.Gold;
            otherColorsToolStripMenuItem.ForeColor = Color.Gold;
            blueToolStripMenuItem.ForeColor = Color.Gold;
            greenToolStripMenuItem.ForeColor = Color.Gold;
            redToolStripMenuItem.ForeColor = Color.Gold;
            purpleToolStripMenuItem.ForeColor = Color.Gold;
        }
        private void colorPurple()
        {
            this.BackColor = Color.DarkViolet;
            toolStrip1.BackColor = Color.DarkMagenta;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTablePurple());
            fileToolStripDropDownButton.BackColor = Color.DarkMagenta;
            helpToolStripDropDownButton.BackColor = Color.DarkMagenta;
            toolStrip1.ForeColor = Color.SkyBlue;
            openToolStripMenuItem.ForeColor = Color.SkyBlue;
            saveToolStripMenuItem.ForeColor = Color.SkyBlue;
            fileToolStripDropDownButton.ForeColor = Color.SkyBlue;
            toolsToolStripDropDownButton.ForeColor = Color.SkyBlue;
            helpToolStripDropDownButton.ForeColor = Color.SkyBlue;
            aboutToolStripMenuItem.ForeColor = Color.SkyBlue;
            supportToolStripMenuItem.ForeColor = Color.SkyBlue;
            updateToolStripMenuItem.ForeColor = Color.SkyBlue;
            patchNotesToolStripMenuItem.ForeColor = Color.SkyBlue;
            changeInfoToolStripMenuItem.ForeColor = Color.SkyBlue;
            languageToolStripMenuItem.ForeColor = Color.SkyBlue;
            themeToolStripMenuItem.ForeColor = Color.SkyBlue;
            turkishToolStripMenuItem.ForeColor = Color.SkyBlue;
            englishToolStripMenuItem.ForeColor = Color.SkyBlue;
            darkToolStripMenuItem.ForeColor = Color.SkyBlue;
            lightToolStripMenuItem.ForeColor = Color.SkyBlue;
            clearToolStripMenuItem.ForeColor = Color.SkyBlue;
            changeFontSizeToolStripMenuItem.ForeColor = Color.SkyBlue;
            toolStripMenuItem8.ForeColor = Color.SkyBlue;
            toolStripMenuItem10.ForeColor = Color.SkyBlue;
            toolStripMenuItem12.ForeColor = Color.SkyBlue;
            toolStripMenuItem14.ForeColor = Color.SkyBlue;
            toolStripMenuItem16.ForeColor = Color.SkyBlue;
            toolStripMenuItem18.ForeColor = Color.SkyBlue;
            toolStripMenuItem20.ForeColor = Color.SkyBlue;
            diaryRichTextBox.BackColor = Color.MediumPurple;
            diaryRichTextBox.ForeColor = Color.Black;
            backupToolStripButton.ForeColor = Color.SkyBlue;
            localBackupToolStripMenuItem.ForeColor = Color.SkyBlue;
            cloudBackupToolStripMenuItem.ForeColor = Color.SkyBlue;
            bugReportToolStripMenuItem.ForeColor = Color.SkyBlue;
            restoreToolStripMenuItem.ForeColor = Color.SkyBlue;
            imagesTextBox.ForeColor = SystemColors.WindowText;
            imagesTextBox.BackColor = SystemColors.Control;
            commentToolStripMenuItem.ForeColor = Color.SkyBlue;
            otherColorsToolStripMenuItem.ForeColor = Color.SkyBlue;
            blueToolStripMenuItem.ForeColor = Color.SkyBlue;
            greenToolStripMenuItem.ForeColor = Color.SkyBlue;
            redToolStripMenuItem.ForeColor = Color.SkyBlue;
            purpleToolStripMenuItem.ForeColor = Color.SkyBlue;
        }
        public class MyColorTableLight : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return SystemColors.Control;
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return SystemColors.ControlLight;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return SystemColors.ControlLight;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return SystemColors.Control;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return SystemColors.Control;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return SystemColors.Highlight;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return SystemColors.GradientActiveCaption;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return SystemColors.Control;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return SystemColors.Control;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return SystemColors.Control;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return SystemColors.Control;
                }
            }
        }
        public class MyColorTableDark: ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.Black;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.Black;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.FromArgb(64, 64, 64);
                }
            }


        }
        public class MyColorTableBlue : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.CadetBlue;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.CadetBlue;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.CadetBlue;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.CadetBlue;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.CadetBlue;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.DarkSlateGray;
                }
            }


        }
        public class MyColorTableGreen : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.LimeGreen;
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.LimeGreen;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.LimeGreen;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.LimeGreen;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.PaleGreen;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.PaleGreen;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.PaleGreen;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.LimeGreen;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.PaleGreen;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.PaleGreen;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.LimeGreen;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.LimeGreen;
                }
            }


        }
        public class MyColorTableRed : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.DarkRed;
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.DarkRed;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.DarkRed;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.DarkRed;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.IndianRed;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.IndianRed;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.IndianRed;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.DarkRed;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.IndianRed;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.IndianRed;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.DarkRed;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.DarkRed;
                }
            }


        }
        public class MyColorTablePurple : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }
            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }

            public override Color ImageMarginGradientMiddle
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }

            public override Color ImageMarginGradientEnd
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.BlueViolet;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.BlueViolet;
                }
            }

            public override Color MenuItemSelected
            {
                get
                {
                    return Color.BlueViolet;
                }
            }


            public override Color MenuStripGradientEnd
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return Color.BlueViolet;
                }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return Color.BlueViolet;
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return Color.DarkMagenta;
                }
            }


        }

        private void secret()
        {
            easteregg++;
            if (easteregg == 10)
            {
                MessageBox.Show("Welcome To The Dark Side!!");
                lightToolStripMenuItem.Enabled = false;
            }
        }
        private void menuNames()
        {
            this.Text = menuName[10];
            fileToolStripDropDownButton.Text = menuName[11];
            openToolStripMenuItem.Text = menuName[12];
            saveToolStripMenuItem.Text = menuName[13];
            clearToolStripMenuItem.Text = menuName[14];
            toolsToolStripDropDownButton.Text = menuName[15];
            changeInfoToolStripMenuItem.Text = menuName[16];
            languageToolStripMenuItem.Text = menuName[17];
            turkishToolStripMenuItem.Text = menuName[3];
            englishToolStripMenuItem.Text = menuName[4];
            themeToolStripMenuItem.Text = menuName[18];
            darkToolStripMenuItem.Text = menuName[1];
            lightToolStripMenuItem.Text = menuName[2];
            changeFontSizeToolStripMenuItem.Text = menuName[19];
            helpToolStripDropDownButton.Text = menuName[20];
            aboutToolStripMenuItem.Text = menuName[21];
            supportToolStripMenuItem.Text = menuName[22];
            updateToolStripMenuItem.Text = menuName[23];
            patchNotesToolStripMenuItem.Text = menuName[24];
            addImageButton.Text = menuName[28];
            backupToolStripButton.Text = menuName[29];
            cloudBackupToolStripMenuItem.Text = menuName[30];
            localBackupToolStripMenuItem.Text = menuName[31];
            bugReportToolStripMenuItem.Text = menuName[32];
            restoreToolStripMenuItem.Text = menuName[33];
            commentToolStripMenuItem.Text = menuName[34];
            otherColorsToolStripMenuItem.Text = menuName[35];
            blueToolStripMenuItem.Text = menuName[36];
            greenToolStripMenuItem.Text = menuName[37];
            redToolStripMenuItem.Text = menuName[38];
            purpleToolStripMenuItem.Text = menuName[39];
        }

 
    }
}