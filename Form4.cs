using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Digital_Diary.Functions;

namespace Digital_Diary
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            languageControl();
            menuNames();
        }
        private void menuNames()
        {
            this.Text = menuName[26];
            programNameLabel.Text = title[11];
            nameLabel.Text = title[12];
            versionLabel.Text = title[13];
            usageLabel.Text = title[14];
            specificationsLabel.Text = title[15];
            licenseLabel.Text = title[16];
        }
    }
}
