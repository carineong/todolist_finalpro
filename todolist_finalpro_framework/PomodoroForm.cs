using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace todolist_finalpro_framework
{
    public partial class PomodoroForm : KryptonForm
    {
        int minSet = 50;
        int min = 50;
        int sec = 0;
        int profile = 0;
        public PomodoroForm(int p)
        {
            InitializeComponent();
            profile = p;
        }

        private void RefreshUI()
        {
            labelMin.Text = min.ToString();
            if (sec < 10) labelSec.Text = $"0{sec}";
            else labelSec.Text = sec.ToString();
        }
        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            min += 5;
            if (min > 180) min = 180;
            minSet = min;
            RefreshUI();
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            min -= 5;
            if (min < 5) min = 5;
            minSet = min;
            RefreshUI();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelMin.Focus();
            if (buttonStart.Text == "START")
            {
                timer1.Enabled = true;
                buttonStart.Text = "CANCEL";
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show($"You have stayed focused for {minSet-min} mins!");
                buttonStart.Text = "START";
                sec = 0;
                min = minSet;
            }
            RefreshUI();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            if(sec < 0)
            {
                sec = 59;
                min -= 1;
            }
            if(min == 0 && sec == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show($"Congratulation! You have stayed focused for {minSet} mins!");
                buttonStart.Text = "START";
            }
            RefreshUI();
        }
    }
}
