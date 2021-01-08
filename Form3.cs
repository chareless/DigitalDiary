using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Digital_Diary.Functions;

namespace Digital_Diary
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();

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
            if(themeGet() =="blue")
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

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            if (nickNameTextBox.Text != "" && passwordTextBox.Text != "")
            {
                changePassword(nickNameTextBox.Text,passwordTextBox.Text);
                MessageBox.Show(title[6]);
                this.Close();
            }
            else
            {
                MessageBox.Show(title[7]);
            }
            
        }

        private void colorDark()
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            updateInfoButton.BackColor = Color.FromArgb(64, 64, 64);
            updateInfoButton.ForeColor = Color.White;
        }

        private void colorLight()
        {
            this.BackColor = Color.Azure;
            updateInfoButton.BackColor = Color.DarkCyan;
            updateInfoButton.ForeColor = SystemColors.ControlText;
        }
        private void colorBlue()
        {
            this.BackColor = Color.DarkCyan;
            updateInfoButton.BackColor = Color.Aqua;
            updateInfoButton.ForeColor = SystemColors.ControlText;
        }
        private void colorGreen()
        {
            this.BackColor = Color.DarkSeaGreen;
            updateInfoButton.BackColor = Color.PaleGreen;
            updateInfoButton.ForeColor = SystemColors.ControlText;
        }
        private void colorRed()
        {
            this.BackColor = Color.Firebrick;
            updateInfoButton.BackColor = Color.Red;
            updateInfoButton.ForeColor = Color.White;
        }
        private void colorPurple()
        {
            this.BackColor = Color.DarkViolet;
            updateInfoButton.BackColor = Color.Indigo;
            updateInfoButton.ForeColor = Color.DarkTurquoise;
        }
        private void menuNames()
        {
            nickNameTextBox.Text = nickNameGet();
            passwordTextBox.Text = passGet();
            this.Text = menuName[25];
            updateInfoButton.Text = menuName[25];
        }
    }
}
