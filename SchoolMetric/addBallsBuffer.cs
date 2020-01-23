using System;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class addBallsBuffer : Form
    {
        public addBallsBuffer()
        {
            InitializeComponent();
        }

        public string[] ballsStr;
        public string[] weightStr;
        public bool closeButton = true;

        private void button1_Click(object sender, EventArgs e)
        {
            balls.Text = balls.Text.Replace("Н","");
            updateColorText();

            char[] delim = new char[] { ';', ' ' };  //Разделители

            weightStr = new string[weights.Items.Count];

            for (int i = 0; i < weights.Items.Count; i++)
            {
                weightStr[i] = weights.Items[i].ToString();
            }

            ballsStr = balls.Text.Split(delim);

            if (weightStr.Length != ballsStr.Length)
                MessageBox.Show("Проверьте корректность введённых данных в ячейках");
            //else if (ballsStr.Length != weightStr.Length && checkBox1.Checked)
            //{
            //    MessageBox.Show("Количество оценок не соотвествует количеству из весов!");
            //}
            else
            {
                closeButton = false;
                this.Close();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            weights.Enabled = checkBox1.Checked;
            removeValue.Enabled = checkBox1.Checked;
            addValue.Enabled = checkBox1.Checked;
        }

        private void balls_TextChanged(object sender, EventArgs e)
        {
            balls.Text = balls.Text.Replace(" ", "");
        }

        private void weights_Leave(object sender, EventArgs e)
        {
            if (weights.Text == "")
            {
                weights.ForeColor = Color.Gray;
                weights.Text = "Все значения вводить через пробел или ';'";

                balls.BackColor = Color.White;
            }
        }

        private void weights_Enter(object sender, EventArgs e)
        {
            if (weights.Text == "Все значения вводить через пробел или ';'")
            {
                weights.ForeColor = Color.Black;
                weights.Text = "";
            }

            updateColorText();
        }

        private void updateColorText()
        {
            balls.Text = balls.Text.Replace("Н", "");

            string[] linesBalls;
            string[] linesWeights = new string[weights.Items.Count];
            char[] delim = new char[] { ';', ' ' };  //Разделители
                                                     //weightStr = weights.Text.Split(delim);
            
            for (int i = 0; i < weights.Items.Count; i++)
            {
                linesWeights[i] = weights.Items[i].ToString();
            }

            linesBalls = balls.Text.Split(delim);

            int count = linesWeights.Length-1;

            for (int i = 0; i < linesWeights.Length; i++)
            {
                if (linesWeights[i] != "")
                    count += linesWeights[i].Length;

                if (linesWeights[i].Length == 2)
                {
                    count -= 1;
                }
            }

            for (int i = 0; i < balls.TextLength; i++)
            {
                if ((i < count && linesWeights[0].Length <= 2) || (!checkBox1.Checked || weights.Text == "Все значения вводить через пробел или ';'"))
                {
                    if (balls.Text[i] >= 48 && balls.Text[i] <= 53)
                    {
                        balls.Select(i, i + linesBalls.Length - 1); //Select text within 0 and 8
                        balls.SelectionBackColor = Color.LightGreen;

                        balls.DeselectAll();
                    }
                    else
                    {
                        balls.Select(i, i + linesBalls.Length - 1); //Select text within 0 and 8
                        balls.SelectionBackColor = Color.LightGray;

                        balls.DeselectAll();
                    }
                }
                else
                {
                    if (balls.Text[i] >= 48 && balls.Text[i] <= 53)
                    {
                        balls.Select(i, i + linesBalls.Length - 1); //Select text within 0 and 8
                        balls.SelectionBackColor = Color.OrangeRed;

                        balls.DeselectAll();
                    }
                    else
                    {
                        balls.Select(i, i + linesBalls.Length - 1); //Select text within 0 and 8
                        balls.SelectionBackColor = Color.LightGray;

                        balls.DeselectAll();
                    }
                }
            }

            balls.SelectionStart = balls.TextLength;
        }

        private void weights_TextChanged(object sender, EventArgs e)
        {
            if (weights.Focused == true)
            {
                updateColorText();
            }
        }

        private void balls_TextChanged_1(object sender, EventArgs e)
        {
            if (balls.Focused == true)
            {
                updateColorText();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateColorText();
        }

        private void weights_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar >= '0' && e.KeyChar <= '10' && Properties.Settings.Default.openWeight == true)
            //{
            //    addWeight frm = new addWeight();

            //    frm.ShowDialog();

            //    weights.Text += frm.select.ToString();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.openWeight == true)
            {
                addWeight frm = new addWeight();

                frm.ShowDialog();

                weights.Items.Add(frm.select.ToString());

                weights.SelectedIndex = weights.Items.Count - 1;
            }
            else
            {
                weights.Items.Add("");

                weights.SelectedIndex = weights.Items.Count - 1;
            }

            updateColorText();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                balls.Text += Clipboard.GetText();
            }
        }

        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(balls.SelectedText);
        }

        private void removeValue_Click(object sender, EventArgs e)
        {
            if (weights.SelectedIndex != -1)
            {
                weights.Items.RemoveAt(weights.SelectedIndex);

                updateColorText();
            }
        }
    }
}
