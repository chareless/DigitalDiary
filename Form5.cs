using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Digital_Diary.Functions;

namespace Digital_Diary
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();

            themeControl();
            languageControl();
            menuNames();
            currentVersionLabel.Text = version;
            checkUpdates();
            if (themeGet() == "dark")
            {
                colorDark();
            }
            if (themeGet() == "light")
            {
                colorLight();
            }
            if (themeGet() == "blue")
            {
                colorBlue();
            }
            if (themeGet() == "green")
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
        }

        private void checkUpdates()
        {
            try
            {
                Uri url = new Uri("https://chareless.github.io/saribayirdeniz/dijitalgunluk.html");
                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string html = client.DownloadString(url);
                HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
                dokuman.LoadHtml(html);
                HtmlNodeCollection titles = dokuman.DocumentNode.SelectNodes("/html/body/div/div[1]/div[2]/div/div/div/div/div[2]/div[2]/div/div/p[6]/h7");
                foreach (HtmlNode title in titles)
                {
                    lastVersionLabel.Text = title.InnerText;
                }

                if (currentVersionLabel.Text == lastVersionLabel.Text)
                {
                    updateButton.Enabled = false;
                    updateButton.Visible = false;
                    versionLabel.Text = title[25];
                }
                else
                {
                    updateButton.Enabled = true;
                    updateButton.Visible = true;
                    versionLabel.Text = title[26];
                }
            }
            catch
            {
                lastVersionLabel.Text = title[27];
                updateButton.Enabled = true;
                updateButton.Visible = true;
                versionLabel.Text = title[28];
            }
           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/chareless/DigitalDiary-for-Windows/archive/refs/heads/master.zip");
        }

        private void menuNames()
        {
            this.Text = menuName[40];
            currentVersionInfoLabel.Text = menuName[41];
            lastVersionInfoLabel.Text = menuName[42];
            updateButton.Text = menuName[43];
        }

        private void colorDark()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            updateButton.BackColor = Color.FromArgb(64, 64, 64);
            updateButton.ForeColor = Color.White;
        }

        private void colorLight()
        {
            this.BackColor = Color.Azure;
            updateButton.BackColor = Color.DarkCyan;
            updateButton.ForeColor = SystemColors.ControlText;
        }
        private void colorBlue()
        {
            this.BackColor = Color.DarkCyan;
            updateButton.BackColor = Color.Aqua;
            updateButton.ForeColor = SystemColors.ControlText;
        }
        private void colorGreen()
        {
            this.BackColor = Color.DarkSeaGreen;
            updateButton.BackColor = Color.PaleGreen;
            updateButton.ForeColor = SystemColors.ControlText;
        }
        private void colorRed()
        {
            this.BackColor = Color.Firebrick;
            updateButton.BackColor = Color.Red;
            updateButton.ForeColor = Color.White;
        }
        private void colorPurple()
        {
            this.BackColor = Color.DarkViolet;
            updateButton.BackColor = Color.Indigo;
            updateButton.ForeColor = Color.DarkTurquoise;
        }
    }
}
