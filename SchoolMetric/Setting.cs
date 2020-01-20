using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class Setting : Form
    {
        bool reload = false;
        DataGridView dataGrid;
        bool startEdit = false;
        bool startRead = true;

        public Setting(DataGridView _dataGrid, bool _startEdit)
        {
            InitializeComponent();

            dataGrid = _dataGrid;
            startEdit = _startEdit;

            try
            {
                colorIndication.Checked = Properties.Settings.Default.colorIndicateOn;
                openFileNewProgram.Checked = Properties.Settings.Default.homeDirectoryOpen;
                openFormWeights.Checked = Properties.Settings.Default.openWeight;
                twoStep.Value = Convert.ToDecimal(Properties.Settings.Default.twoStep);
                threeStep.Value = Convert.ToDecimal(Properties.Settings.Default.threeStep);
                fourStep.Value = Convert.ToDecimal(Properties.Settings.Default.fourStep);
                twoStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
                threeStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
                fourStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
                fiveStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));

                checkBox4.Checked = Properties.Settings.Default.oneWeight;
                checkBox6.Checked = Properties.Settings.Default.twoWeight;
                checkBox5.Checked = Properties.Settings.Default.threeWeight;
                checkBox7.Checked = Properties.Settings.Default.fourWeight;
                checkBox8.Checked = Properties.Settings.Default.fiveWeight;
                checkBox9.Checked = Properties.Settings.Default.sixWeight;
                checkBox10.Checked = Properties.Settings.Default.sevenWeight;
                checkBox11.Checked = Properties.Settings.Default.eightWeight;
                checkBox12.Checked = Properties.Settings.Default.nineWeight;
                checkBox13.Checked = Properties.Settings.Default.tenWeight;

                textBox1.Text = Properties.Settings.Default.oneText;
                textBox2.Text = Properties.Settings.Default.twoText;
                textBox3.Text = Properties.Settings.Default.threeText;
                textBox4.Text = Properties.Settings.Default.fourText;
                textBox5.Text = Properties.Settings.Default.fiveText;
                textBox6.Text = Properties.Settings.Default.sixText;
                textBox8.Text = Properties.Settings.Default.sevenText;
                textBox9.Text = Properties.Settings.Default.eightText;
                textBox10.Text = Properties.Settings.Default.nineText;
                textBox7.Text = Properties.Settings.Default.tenText;

                startRead = false;
            }
            catch
            {
                Properties.Settings.Default.Reset();
            }

            twoStepColor.Enabled = colorIndication.Checked;
            threeStepColor.Enabled = colorIndication.Checked;
            fourStepColor.Enabled = colorIndication.Checked;
            fiveStepColor.Enabled = colorIndication.Checked;
            pictureBox1.Enabled = colorIndication.Checked;
            pictureBox2.Enabled = colorIndication.Checked;
            pictureBox3.Enabled = colorIndication.Checked;
            pictureBox4.Enabled = colorIndication.Checked;
        }

        private void saveWeights()
        {
            Properties.Settings.Default.oneWeight = checkBox4.Checked;
            Properties.Settings.Default.twoWeight = checkBox6.Checked;
            Properties.Settings.Default.threeWeight = checkBox5.Checked;
            Properties.Settings.Default.fourWeight = checkBox7.Checked;
            Properties.Settings.Default.fiveWeight = checkBox8.Checked;
            Properties.Settings.Default.sixWeight = checkBox9.Checked;
            Properties.Settings.Default.sevenWeight = checkBox10.Checked;
            Properties.Settings.Default.eightWeight = checkBox11.Checked;
            Properties.Settings.Default.nineWeight = checkBox12.Checked;
            Properties.Settings.Default.tenWeight = checkBox13.Checked;

            Properties.Settings.Default.oneText = textBox1.Text;
            Properties.Settings.Default.twoText = textBox2.Text;
            Properties.Settings.Default.threeText = textBox3.Text;
            Properties.Settings.Default.fourText = textBox4.Text;
            Properties.Settings.Default.fiveText = textBox5.Text;
            Properties.Settings.Default.sixText = textBox6.Text;
            Properties.Settings.Default.sevenText = textBox8.Text;
            Properties.Settings.Default.eightText = textBox9.Text;
            Properties.Settings.Default.nineText = textBox10.Text;
            Properties.Settings.Default.tenText = textBox7.Text;

            Properties.Settings.Default.Save();

            checkBox4.Checked = Properties.Settings.Default.oneWeight;
            checkBox6.Checked = Properties.Settings.Default.twoWeight;
            checkBox5.Checked = Properties.Settings.Default.threeWeight;
            checkBox7.Checked = Properties.Settings.Default.fourWeight;
            checkBox8.Checked = Properties.Settings.Default.fiveWeight;
            checkBox9.Checked = Properties.Settings.Default.sixWeight;
            checkBox10.Checked = Properties.Settings.Default.sevenWeight;
            checkBox11.Checked = Properties.Settings.Default.eightWeight;
            checkBox12.Checked = Properties.Settings.Default.nineWeight;
            checkBox13.Checked = Properties.Settings.Default.tenWeight;
        }

        private void selectColor(int numColor)
        {
            using (ColorDialog colorForm = new ColorDialog())
            {
                colorForm.CustomColors = new int[] {
                                        ColorTranslator.ToOle(Color.FromArgb(int.Parse("FFFF4500", System.Globalization.NumberStyles.HexNumber))),
                                        ColorTranslator.ToOle(Color.FromArgb(int.Parse("FFFFFF00", System.Globalization.NumberStyles.HexNumber))),
                                        ColorTranslator.ToOle(Color.FromArgb(int.Parse("FF90EE90", System.Globalization.NumberStyles.HexNumber)))
                };
                if (colorForm.ShowDialog() == DialogResult.OK)
                {
                    if (numColor == 0)
                    {
                        Properties.Settings.Default.twoColor = colorForm.Color.A.ToString("X2") + colorForm.Color.R.ToString("X2") + colorForm.Color.G.ToString("X2") + colorForm.Color.B.ToString("X2");
                    }
                    else if (numColor == 1)
                    {
                        Properties.Settings.Default.threeColor = colorForm.Color.A.ToString("X2") + colorForm.Color.R.ToString("X2") + colorForm.Color.G.ToString("X2") + colorForm.Color.B.ToString("X2");
                    }
                    else if (numColor == 2)
                    {
                        Properties.Settings.Default.fourColor = colorForm.Color.A.ToString("X2") + colorForm.Color.R.ToString("X2") + colorForm.Color.G.ToString("X2") + colorForm.Color.B.ToString("X2");
                    }
                    else if (numColor == 3)
                    {
                        Properties.Settings.Default.fiveColor = colorForm.Color.A.ToString("X2") + colorForm.Color.R.ToString("X2") + colorForm.Color.G.ToString("X2") + colorForm.Color.B.ToString("X2");
                    }

                    Properties.Settings.Default.Save();

                    if (numColor == 0)
                    {
                        twoStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (numColor == 1)
                    {
                        threeStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (numColor == 2)
                    {
                        fourStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (numColor == 3)
                    {
                        fiveStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));
                    }
                }
            }
        }

        private void selectStep(int numStep)
        {
            if (numStep == 0)
            {
                Properties.Settings.Default.twoStep = Convert.ToSingle(twoStep.Value);
            }
            else if (numStep == 1)
            {
                Properties.Settings.Default.threeStep = Convert.ToSingle(threeStep.Value);
            }
            else if (numStep == 2)
            {
                Properties.Settings.Default.fourStep = Convert.ToSingle(fourStep.Value);
            }

            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            colorIndication.Checked = Properties.Settings.Default.colorIndicateOn;
            openFileNewProgram.Checked = Properties.Settings.Default.homeDirectoryOpen;
            openFormWeights.Checked = Properties.Settings.Default.openWeight;
            twoStep.Value = Convert.ToDecimal(Properties.Settings.Default.twoStep);
            threeStep.Value = Convert.ToDecimal(Properties.Settings.Default.threeStep);
            fourStep.Value = Convert.ToDecimal(Properties.Settings.Default.fourStep);
            twoStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
            threeStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
            fourStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
            fiveStepColor.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));

            reload = true;

            MessageBox.Show("Все настройки сброшены!\nЗакройте окно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectColor(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectColor(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectColor(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectColor(3);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.colorIndicateOn = colorIndication.Checked;
            Properties.Settings.Default.Save();

            twoStepColor.Enabled = colorIndication.Checked;
            threeStepColor.Enabled = colorIndication.Checked;
            fourStepColor.Enabled = colorIndication.Checked;
            fiveStepColor.Enabled = colorIndication.Checked;
            pictureBox1.Enabled = colorIndication.Checked;
            pictureBox2.Enabled = colorIndication.Checked;
            pictureBox3.Enabled = colorIndication.Checked;
            pictureBox4.Enabled = colorIndication.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectStep(0);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            selectStep(1);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            selectStep(2);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.homeDirectoryOpen = openFileNewProgram.Checked;
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                font.Font = Properties.Settings.Default.font;

                if (font.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.font = font.Font;
                    Properties.Settings.Default.Save();

                    reload = true;
                }
            }
        }

        class metric
        {
            public bool colorIndicateOn { get; set; }
            public string twoColor { get; set; }
            public string threeColor { get; set; }
            public string fourColor { get; set; }
            public string fiveColor { get; set; }
            public float twoStep { get; set; }
            public float threeStep { get; set; }
            public float fourStep { get; set; }
            public string homeDirectory { get; set; }
            public string font { get; set; }
            public bool homeDirectoryOpen { get; set; }
            public string fontBall { get; set; }
            public string fontWeight { get; set; }
            public allWeights allWeights { get; set; }
            public textWeights textWeights { get; set; }
            public bool openWeight { get; set; }
            public bool welcome { get; set; }
            public bool portableVersion { get; set; }
            public bool change_log { get; set; }
        }

        class allWeights
        {
            public bool oneWeight { get; set; }
            public bool twoWeight { get; set; }
            public bool threeWeight { get; set; }
            public bool fourWeight { get; set; }
            public bool fiveWeight { get; set; }
            public bool sixWeight { get; set; }
            public bool sevenWeight { get; set; }
            public bool eightWeight { get; set; }
            public bool nineWeight { get; set; }
            public bool tenWeight { get; set; }
        }

        class textWeights
        {
            public string oneText { get; set; }
            public string twoText { get; set; }
            public string threeText { get; set; }
            public string fourText { get; set; }
            public string fiveText { get; set; }
            public string sixText { get; set; }
            public string sevenText { get; set; }
            public string eightText { get; set; }
            public string nineText { get; set; }
            public string tenText { get; set; }
        }       

        private void Setting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал"));
            }

            StreamWriter saveSettings = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\settings.json"));
            try
            {
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));

                //saveSettings.Write($"{Properties.Settings.Default.colorIndicateOn}#{Properties.Settings.Default.twoColor}#{Properties.Settings.Default.threeColor}#{Properties.Settings.Default.fourColor}#{Properties.Settings.Default.fiveColor}#{Properties.Settings.Default.twoStep}#{Properties.Settings.Default.threeStep}#{Properties.Settings.Default.fourStep}#{Properties.Settings.Default.homeDirectory}#{tc.ConvertToString(Properties.Settings.Default.font)}#{Properties.Settings.Default.homeDirectoryOpen}#{tc.ConvertToString(Properties.Settings.Default.fontBall)}#{tc.ConvertToString(Properties.Settings.Default.fontWeight)}#{Properties.Settings.Default.allWeights}#{Properties.Settings.Default.openWeight}#{Properties.Settings.Default.welcome}#{Properties.Settings.Default.change_log}");

                metric data = new metric();

                data.colorIndicateOn = Properties.Settings.Default.colorIndicateOn;
                data.twoColor = Properties.Settings.Default.twoColor;
                data.threeColor = Properties.Settings.Default.threeColor;
                data.fourColor = Properties.Settings.Default.fourColor;
                data.fiveColor = Properties.Settings.Default.fiveColor;
                data.twoStep = Properties.Settings.Default.twoStep;
                data.threeStep = Properties.Settings.Default.threeStep;
                data.fourStep = Properties.Settings.Default.fourStep;
                data.homeDirectory = Properties.Settings.Default.homeDirectory;
                data.font = tc.ConvertToString(Properties.Settings.Default.font);
                data.homeDirectoryOpen = Properties.Settings.Default.homeDirectoryOpen;
                data.fontBall = tc.ConvertToString(Properties.Settings.Default.fontBall);
                data.fontWeight = tc.ConvertToString(Properties.Settings.Default.fontWeight);
                data.openWeight = Properties.Settings.Default.openWeight;
                data.welcome = Properties.Settings.Default.welcome;
                data.change_log = Properties.Settings.Default.change_log;

                data.allWeights = new allWeights()
                {
                    oneWeight = Properties.Settings.Default.oneWeight,
                    twoWeight = Properties.Settings.Default.twoWeight,
                    threeWeight = Properties.Settings.Default.threeWeight,
                    fourWeight = Properties.Settings.Default.fourWeight,
                    fiveWeight = Properties.Settings.Default.fiveWeight,
                    sixWeight = Properties.Settings.Default.sixWeight,
                    sevenWeight = Properties.Settings.Default.sevenWeight,
                    eightWeight = Properties.Settings.Default.eightWeight,
                    nineWeight = Properties.Settings.Default.nineWeight,
                    tenWeight = Properties.Settings.Default.tenWeight
                };

                data.textWeights = new textWeights()
                {
                    oneText = Properties.Settings.Default.oneText,
                    twoText = Properties.Settings.Default.twoText,
                    threeText = Properties.Settings.Default.threeText,
                    fourText = Properties.Settings.Default.fourText,
                    fiveText = Properties.Settings.Default.fiveText,
                    sixText = Properties.Settings.Default.sixText,
                    sevenText = Properties.Settings.Default.sevenText,
                    eightText = Properties.Settings.Default.eightText,
                    nineText = Properties.Settings.Default.nineText,
                    tenText = Properties.Settings.Default.tenText
                };

                saveSettings.Write(JsonConvert.SerializeObject(data)); //Formatting.Indented
            }
            catch { }
            finally
            {
                saveSettings.Close();
            }

            if (reload == true)
            {
                DialogResult msg = MessageBox.Show("Что бы изменения вступили в силу, нужно перезапустить программу.\r\r\r\nПерезапустить?", "Перезапустить?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes && startEdit == true)
                {
                    DialogResult resultSave = MessageBox.Show("Файл с оценками не сохранён, сохранить?", "Сохранить файл?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultSave == DialogResult.Yes)
                    {

                        if (File.Exists(Properties.Settings.Default.homeDirectory))
                        {
                            StreamWriter myWriter = new StreamWriter(Properties.Settings.Default.homeDirectory);
                            try
                            {
                                for (int i = 0; i < dataGrid.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                                    {
                                        if (dataGrid.Rows[i].Cells[j].Value == null)
                                        {
                                            myWriter.Write("" + ";");
                                        }
                                        else
                                        {
                                            myWriter.Write(dataGrid.Rows[i].Cells[j].Value.ToString() + ";");
                                        }
                                    }

                                    myWriter.WriteLine();

                                }
                            }
                            catch { }
                            finally
                            {
                                myWriter.Close();
                            }
                            MessageBox.Show("Файл сохранён!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                        else if (startEdit == true)
                        {

                            Stream myStream;

                            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                            saveFileDialog1.Filter = "dnv Файл (*.dnv)|*.dnv|txt Файл (*.txt)|*.txt";
                            saveFileDialog1.FilterIndex = 1;
                            saveFileDialog1.RestoreDirectory = true;

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                if ((myStream = saveFileDialog1.OpenFile()) != null)
                                {
                                    Properties.Settings.Default.homeDirectory = saveFileDialog1.FileName;
                                    Properties.Settings.Default.Save();

                                    StreamWriter myWriter = new StreamWriter(myStream);
                                    try
                                    {
                                        for (int i = 0; i < dataGrid.Rows.Count; i++)
                                        {
                                            for (int j = 0; j < dataGrid.Columns.Count; j++)
                                            {
                                                if (dataGrid.Rows[i].Cells[j].Value == null)
                                                {
                                                    myWriter.Write("" + ";");
                                                }
                                                else
                                                {
                                                    myWriter.Write(dataGrid.Rows[i].Cells[j].Value.ToString() + ";");
                                                }
                                            }

                                            myWriter.WriteLine();

                                        }
                                    }
                                    catch { }
                                    finally
                                    {
                                        myWriter.Close();
                                    }
                                    myStream.Close();
                                }
                            }
                        }
                    }

                    Application.Restart();

                }
                if (msg == DialogResult.Yes && startEdit == false)
                {
                    Application.Restart();
                }
                else
                {
                    reload = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                font.Font = Properties.Settings.Default.fontBall;

                if (font.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.fontBall = font.Font;
                    Properties.Settings.Default.Save();

                    reload = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FontDialog font = new FontDialog())
            {
                font.Font = Properties.Settings.Default.fontWeight;

                if (font.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.fontWeight = font.Font;
                    Properties.Settings.Default.Save();

                    reload = true;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.openWeight = openFormWeights.Checked;
            Properties.Settings.Default.Save();
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (!startRead)
            { saveWeights(); }

            textBox1.Enabled = checkBox4.Checked; 
            textBox2.Enabled = checkBox6.Checked;
            textBox3.Enabled = checkBox5.Checked;
            textBox4.Enabled = checkBox7.Checked;
            textBox5.Enabled = checkBox8.Checked;
            textBox6.Enabled = checkBox9.Checked;
            textBox8.Enabled = checkBox10.Checked;
            textBox9.Enabled = checkBox11.Checked;
            textBox10.Enabled = checkBox12.Checked;
            textBox7.Enabled = checkBox13.Checked;
        }
    }
}
