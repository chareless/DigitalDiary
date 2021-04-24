using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Digital_Diary.Functions;

namespace Digital_Diary
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            isFileHere();
            themeControl();
            languageControl();
            if (themeGet() == "dark")
            {
                colorDark();
            }
            if (themeGet() == "light")
            {
                colorLight();
            }
            if(themeGet()=="blue")
            {
                colorBlue();
            }
            if(themeGet()=="green")
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
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (nickNameTextBox.Text != "" && passwordTextBox2.Text != "")
            {
                passwordControl();
                if (passwordTextBox2.Text == passGet() && nickNameTextBox.Text == nickNameGet())
                {
                    MessageBox.Show(title[0]);
                    this.Hide();
                    DiaryForm ff = new DiaryForm();
                    ff.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(title[1]);
                }
            }
            else
            {
                MessageBox.Show(title[1]);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            signIn(nickNameTextBox.Text, passwordTextBox2.Text);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveSettings("dark",languageGet());
            colorDark();
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
        private void colorDark()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTableDark());
            themeToolStripDropDownButton.BackColor = Color.FromArgb(64, 64, 64);
            languageToolStripDropDownButton.BackColor = Color.FromArgb(64, 64, 64);
            toolStrip1.ForeColor = Color.White;
            themeToolStripDropDownButton.ForeColor = Color.White;
            languageToolStripDropDownButton.ForeColor = Color.White;
            darkToolStripMenuItem.ForeColor = Color.White;
            lightToolStripMenuItem.ForeColor = Color.White;
            turkishToolStripMenuItem.ForeColor = Color.White;
            englishToolStripMenuItem.ForeColor = Color.White;
            nickNameLabel.ForeColor = Color.White;
            passLabel.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            signInButton.BackColor = Color.FromArgb(64, 64, 64);
            loginButton.BackColor = Color.FromArgb(64, 64, 64);
            signInButton.ForeColor = Color.White;
            loginButton.ForeColor = Color.White;
            reportToolStripButton.ForeColor = Color.White;
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
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTableLight());
            themeToolStripDropDownButton.BackColor = Color.PaleTurquoise;
            languageToolStripDropDownButton.BackColor = Color.PaleTurquoise;
            toolStrip1.ForeColor = Color.Black;
            themeToolStripDropDownButton.ForeColor = Color.Black;
            languageToolStripDropDownButton.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            turkishToolStripMenuItem.ForeColor = Color.Black;
            englishToolStripMenuItem.ForeColor = Color.Black;
            nickNameLabel.ForeColor = Color.Black;
            passLabel.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            signInButton.BackColor = Color.DarkCyan;
            loginButton.BackColor = Color.DarkCyan;
            signInButton.ForeColor = SystemColors.ControlText;
            loginButton.ForeColor = SystemColors.ControlText;
            reportToolStripButton.ForeColor = Color.Black;
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
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTableBlue());
            themeToolStripDropDownButton.BackColor = Color.DarkSlateGray;
            languageToolStripDropDownButton.BackColor = Color.DarkSlateGray;
            toolStrip1.ForeColor = Color.PaleTurquoise;
            themeToolStripDropDownButton.ForeColor = Color.PaleTurquoise;
            languageToolStripDropDownButton.ForeColor = Color.PaleTurquoise;
            darkToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            lightToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            turkishToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            englishToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            nickNameLabel.ForeColor = Color.PaleTurquoise;
            passLabel.ForeColor = Color.PaleTurquoise;
            label3.ForeColor = Color.PaleTurquoise;
            label4.ForeColor = Color.PaleTurquoise;
            signInButton.BackColor = Color.Aqua;
            loginButton.BackColor = Color.Aqua;
            signInButton.ForeColor = SystemColors.ControlText;
            loginButton.ForeColor = SystemColors.ControlText;
            reportToolStripButton.ForeColor = Color.PaleTurquoise;
            otherColorsToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            blueToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            greenToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            redToolStripMenuItem.ForeColor = Color.PaleTurquoise;
            purpleToolStripMenuItem.ForeColor = Color.PaleTurquoise;
        }
        private void colorGreen()
        {
            this.BackColor = Color.LawnGreen;
            toolStrip1.BackColor = Color.LimeGreen;
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTableGreen());
            themeToolStripDropDownButton.BackColor = Color.LimeGreen;
            languageToolStripDropDownButton.BackColor = Color.LimeGreen;
            toolStrip1.ForeColor = Color.Black;
            themeToolStripDropDownButton.ForeColor = Color.Black;
            languageToolStripDropDownButton.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            turkishToolStripMenuItem.ForeColor = Color.Black;
            englishToolStripMenuItem.ForeColor = Color.Black;
            nickNameLabel.ForeColor = Color.Black;
            passLabel.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            signInButton.BackColor = Color.SeaGreen;
            loginButton.BackColor = Color.SeaGreen;
            signInButton.ForeColor = SystemColors.ControlText;
            loginButton.ForeColor = SystemColors.ControlText;
            reportToolStripButton.ForeColor = Color.Black;
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
            toolStrip1.Renderer = new ToolStripProfessionalRenderer(new DiaryForm.MyColorTableRed());
            themeToolStripDropDownButton.BackColor = Color.DarkRed;
            languageToolStripDropDownButton.BackColor = Color.DarkRed;
            toolStrip1.ForeColor = Color.Gold;
            themeToolStripDropDownButton.ForeColor = Color.Gold;
            languageToolStripDropDownButton.ForeColor = Color.Gold;
            darkToolStripMenuItem.ForeColor = Color.Gold;
            lightToolStripMenuItem.ForeColor = Color.Gold;
            turkishToolStripMenuItem.ForeColor = Color.Gold;
            englishToolStripMenuItem.ForeColor = Color.Gold;
            nickNameLabel.ForeColor = Color.White;
            passLabel.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            signInButton.BackColor = Color.Red;
            loginButton.BackColor = Color.Red;
            signInButton.ForeColor = SystemColors.Control;
            loginButton.ForeColor = SystemColors.Control;
            reportToolStripButton.ForeColor = Color.Gold;
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
            themeToolStripDropDownButton.BackColor = Color.DarkMagenta;
            languageToolStripDropDownButton.BackColor = Color.DarkMagenta;
            toolStrip1.ForeColor = Color.SkyBlue;
            themeToolStripDropDownButton.ForeColor = Color.SkyBlue;
            languageToolStripDropDownButton.ForeColor = Color.SkyBlue;
            darkToolStripMenuItem.ForeColor = Color.SkyBlue;
            lightToolStripMenuItem.ForeColor = Color.SkyBlue;
            turkishToolStripMenuItem.ForeColor = Color.SkyBlue;
            englishToolStripMenuItem.ForeColor = Color.SkyBlue;
            nickNameLabel.ForeColor = Color.DarkTurquoise;
            passLabel.ForeColor = Color.DarkTurquoise;
            label3.ForeColor = Color.DarkTurquoise;
            label4.ForeColor = Color.DarkTurquoise;
            signInButton.BackColor = Color.Indigo;
            loginButton.BackColor = Color.Indigo;
            signInButton.ForeColor = SystemColors.MenuHighlight;
            loginButton.ForeColor = SystemColors.MenuHighlight;
            reportToolStripButton.ForeColor = Color.SkyBlue;
            otherColorsToolStripMenuItem.ForeColor = Color.SkyBlue;
            blueToolStripMenuItem.ForeColor = Color.SkyBlue;
            greenToolStripMenuItem.ForeColor = Color.SkyBlue;
            redToolStripMenuItem.ForeColor = Color.SkyBlue;
            purpleToolStripMenuItem.ForeColor = Color.SkyBlue;
        }
        private void turkishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageTurkish();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            languageEnglish();
        }
        private void reportToolStripButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.saribayirdeniz.cf/#contact");
        }

        private void menuNames()
        {
            themeToolStripDropDownButton.Text = menuName[0];
            darkToolStripMenuItem.Text = menuName[1];
            lightToolStripMenuItem.Text = menuName[2];
            turkishToolStripMenuItem.Text = menuName[3];
            englishToolStripMenuItem.Text = menuName[4];
            languageToolStripDropDownButton.Text = menuName[5];
            nickNameLabel.Text = menuName[6];
            passLabel.Text = menuName[7];
            signInButton.Text = menuName[8];
            loginButton.Text = menuName[9];
            this.Text = menuName[10];
            reportToolStripButton.Text = menuName[27];
            otherColorsToolStripMenuItem.Text = menuName[35];
            blueToolStripMenuItem.Text = menuName[36];
            greenToolStripMenuItem.Text = menuName[37];
            redToolStripMenuItem.Text = menuName[38];
            purpleToolStripMenuItem.Text = menuName[39];
        }
    }
}