using System;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class addWeight : Form
    {
        public int select = 6;

        public addWeight()
        {
            InitializeComponent();

            radioButton1.Text = Properties.Settings.Default.oneText;
            radioButton2.Text = Properties.Settings.Default.twoText;
            radioButton3.Text = Properties.Settings.Default.threeText;
            radioButton4.Text = Properties.Settings.Default.fourText;
            radioButton5.Text = Properties.Settings.Default.fiveText;
            radioButton10.Text = Properties.Settings.Default.sixText;
            radioButton9.Text = Properties.Settings.Default.sevenText;
            radioButton8.Text = Properties.Settings.Default.eightText;
            radioButton7.Text = Properties.Settings.Default.nineText;
            radioButton6.Text = Properties.Settings.Default.tenText;


            if (Properties.Settings.Default.oneWeight) { radioButton1.Checked = true; } else { radioButton1.Enabled = false; }
            if (Properties.Settings.Default.twoWeight) { radioButton2.Checked = true; } else { radioButton2.Enabled = false; }
            if (Properties.Settings.Default.threeWeight) { radioButton3.Checked = true; } else { radioButton3.Enabled = false; }
            if (Properties.Settings.Default.fourWeight) { radioButton4.Checked = true; } else { radioButton4.Enabled = false; }
            if (Properties.Settings.Default.fiveWeight) { radioButton5.Checked = true; } else { radioButton5.Enabled = false; }
            if (Properties.Settings.Default.sixWeight) { radioButton6.Checked = true; } else { radioButton6.Enabled = false; }
            if (Properties.Settings.Default.sevenWeight) { radioButton7.Checked = true; } else { radioButton7.Enabled = false; }
            if (Properties.Settings.Default.eightWeight) { radioButton8.Checked = true; } else { radioButton8.Enabled = false; }
            if (Properties.Settings.Default.nineWeight) { radioButton9.Checked = true; } else { radioButton9.Enabled = false; }
            if (Properties.Settings.Default.tenWeight) { radioButton10.Checked = true; } else { radioButton10.Enabled = false; }

            this.Width = Math.Max(radioButton1.Width, Math.Max(radioButton2.Width, Math.Max(radioButton3.Width, Math.Max(radioButton4.Width, Math.Max(radioButton5.Width, Math.Max(radioButton6.Width, Math.Max(radioButton7.Width, Math.Max(radioButton8.Width, Math.Max(radioButton9.Width, radioButton10.Width))))))))) + 30;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                select = 1;
            }
            else if (radioButton2.Checked)
            {
                select = 2;
            }
            else if (radioButton3.Checked)
            {
                select = 3;
            }
            else if (radioButton4.Checked)
            {
                select = 4;
            }
            else if (radioButton5.Checked)
            {
                select = 5;
            }
            else if (radioButton10.Checked)
            {
                select = 6;
            }
            else if (radioButton9.Checked)
            {
                select = 7;
            }
            else if (radioButton8.Checked)
            {
                select = 8;
            }
            else if (radioButton7.Checked)
            {
                select = 9;
            }
            else if (radioButton6.Checked)
            {
                select = 10;
            }

            this.Close();
        }
    }
}
