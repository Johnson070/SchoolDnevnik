using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class Main : Form
    {
        bool portableVersion = false;

        const int colPred = 13;
        public int[,] poslBall;
        public int[] colBallSr;
        string[] args;

        bool startEdit = false;
        bool fileOpened = false;

        List<string> pred = new List<string> { "Английский язык", "Астрономия", "Естествознание", "Информатика", "История", "Литература", "Математика", "ОБЖ", "Обществознание", "Программирование", "Русский язык", "Физика", "Физ-ра" };

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        public static bool IsInternetAvailable()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }

        private void columnGenBallWeight(int col)
        {
            var srBall = new DataGridViewColumn();
            srBall.HeaderText = "Балл"; //текст в шапке
            srBall.Width = 100; //ширина колонки
            srBall.ReadOnly = false; //значение в этой колонке нельзя править
            srBall.Name = "ball"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            srBall.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            srBall.DisplayIndex = 9999;
            srBall.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);

            for (int i = 0; i < col; i++)
            {
                var ball = new DataGridViewColumn();
                ball.HeaderText = "Оценка"; //текст в шапке
                ball.Width = 50; //ширина колонки
                ball.DefaultCellStyle.BackColor = Color.FromArgb(179, 179, 179);
                ball.ReadOnly = false; //значение в этой колонке нельзя править
                ball.Name = "val"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                ball.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                ball.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;

                var weight = new DataGridViewColumn();
                weight.HeaderText = "Вес";
                weight.Width = 35;
                weight.DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
                weight.Name = "costs";
                weight.CellTemplate = new DataGridViewTextBoxCell();
                weight.DefaultCellStyle.Font = Properties.Settings.Default.fontWeight;

                dataGridView1.Columns.Add(ball);
                dataGridView1.Columns.Add(weight);
            }

            dataGridView1.Columns.Add(srBall);
        }

        private void columnSet(bool genRows, List<string> _pred)
        {
            var predmet = new DataGridViewColumn();
            predmet.HeaderText = "Предмет"; //текст в шапке
            predmet.Width = 150; //ширина колонки
            predmet.Name = "name"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            predmet.DefaultCellStyle.Font = Properties.Settings.Default.font;
            predmet.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var srBall = new DataGridViewColumn();
            srBall.HeaderText = "Балл"; //текст в шапке
            srBall.Width = 100; //ширина колонки
            srBall.ReadOnly = false; //значение в этой колонке нельзя править
            srBall.Name = "ball"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            srBall.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
            srBall.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            srBall.DisplayIndex = 9999;

            var ball = new DataGridViewColumn();
            ball.HeaderText = "Оценка"; //текст в шапке
            ball.Width = 50; //ширина колонки
            ball.DefaultCellStyle.BackColor = Color.FromArgb(179, 179, 179);
            ball.ReadOnly = false; //значение в этой колонке нельзя править
            ball.Name = "val"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            ball.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
            ball.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var weight = new DataGridViewColumn();
            weight.HeaderText = "Вес";
            weight.Width = 35;
            weight.DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
            weight.DefaultCellStyle.Font = Properties.Settings.Default.fontWeight;
            weight.Name = "costs";
            weight.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.AllowUserToAddRows = false;

            /*=====================================*/

            dataGridView1.Columns.Add(predmet);
            dataGridView1.Columns.Add(ball);
            dataGridView1.Columns.Add(weight);
            dataGridView1.Columns.Add(srBall);

            /*=====================================*/

            if (genRows == true)
            {
                for (int i = 0; i < _pred.Count; ++i)
                {
                    //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                    dataGridView1.Rows.Add();
                    dataGridView1["name", dataGridView1.Rows.Count - 1].Value = _pred[i];
                }
            }
        }

        private void welcome(bool show)
        {
            if (show)
            {
                MessageBox.Show("Здравствуйте, спасибо за установку данной программы.\r\r\r\n\nЕсли вы нашли ошибку перейдите в\nОсновные => Сообщить о проблеме\r\r\r\n\nЕсли у вас есть идеи и предложения перейдите в Основные => Написать разработчику\r\r\r\n\nПриятного пользования!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Properties.Settings.Default.welcome = false;
                Properties.Settings.Default.Save();
            }
        }

        private void portableVersionUpdate()
        {
            if (portableVersion)
            {
                Properties.Settings.Default.portableVersion = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.portableVersion = false;
                Properties.Settings.Default.Save();
            }
        }

        public Main(string[] _args)
        {
            InitializeComponent();

            args = _args;

            portableVersionUpdate();

            restoreSettings();

            //dataGridView1.ContextMenuStrip = actionTable;

            dataGridView1.Font = Properties.Settings.Default.font;
        }

        public void resultBall()
        {
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                float result = 0;
                int[] weight = new int[(dataGridView1.Columns.Count - 2) / 2];
                int[] ball = new int[(dataGridView1.Columns.Count - 2) / 2];

                int countBall = 0, countWeight = 0;

                //int[] weightsStep = new int[5];

                //string lines = Properties.Settings.Default.asdasd;
                //string[] inpstr;
                //char[] delim = new char[] { ';' };  //Разделители
                //inpstr = lines.Split(delim);

                //for (int i = 0; i < inpstr.Length; i++)
                //{
                //    weightsStep[i] = Convert.ToInt16(inpstr[i]);
                //}


                for (int i = 1; i < dataGridView1.Columns.Count - 1; i++)
                {
                    if (dataGridView1[i, j].Value != null && dataGridView1[i, j].Value != "")
                    {
                        if (i % 2 != 0)
                        {
                            ball[countBall] = Convert.ToInt32(dataGridView1[i, j].Value);
                            countBall++;

                            int numberToColor = Convert.ToInt32(dataGridView1[i, j].Value);

                            if (Properties.Settings.Default.colorIndicateOn == true)
                            {
                                if (numberToColor == 5)
                                {
                                    dataGridView1[i, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));
                                }
                                else if (numberToColor == 4)
                                {
                                    dataGridView1[i, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
                                }
                                else if (numberToColor == 3)
                                {
                                    dataGridView1[i, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
                                }
                                else if (numberToColor == 2)
                                {
                                    dataGridView1[i, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
                                }
                            }
                            else
                            {
                                dataGridView1[i, j].Style.BackColor = Color.FromArgb(179, 179, 179);
                            }

                            //dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            //dataGridView1.AutoResizeRow(j, DataGridViewAutoSizeRowMode.AllCells);
                        }
                        else
                        {
                            if (dataGridView1[i, j].Value.ToString() == "1" && Properties.Settings.Default.oneWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.oneText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "2" && Properties.Settings.Default.twoWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.twoText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "3" && Properties.Settings.Default.threeWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.threeText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "4" && Properties.Settings.Default.fourWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.fourText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "5" && Properties.Settings.Default.fiveWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.fiveText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "6" && Properties.Settings.Default.sixWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.sixText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "7" && Properties.Settings.Default.sevenWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.sevenText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "8" && Properties.Settings.Default.eightWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.eightText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "9" && Properties.Settings.Default.nineWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.nineText;
                            }
                            else if (dataGridView1[i, j].Value.ToString() == "10" && Properties.Settings.Default.tenWeight)
                            {
                                dataGridView1[i, j].ToolTipText = Properties.Settings.Default.tenText;
                            }
                            else
                            {
                                dataGridView1[i, j].ToolTipText = "";
                            }


                            weight[countWeight] = Convert.ToInt32(dataGridView1[i, j].Value);
                            //dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            //dataGridView1.AutoResizeRow(j, DataGridViewAutoSizeRowMode.AllCells);
                            countWeight++;
                        }
                    }
                    else
                    {
                        dataGridView1[i, j].Value = null;

                        if (i % 2 != 0)
                        {
                            dataGridView1[i, j].Style.BackColor = Color.FromArgb(179, 179, 179);
                        }
                    }
                }

                float resultBall = 0, resultWeight = 0;

                for (int i = 0; i < (dataGridView1.Columns.Count / 2) - 1; i++)
                {
                    if (ball[i] != 0 && weight[i] != 0)
                    {
                        resultBall += ball[i] * weight[i];

                        resultWeight += weight[i];
                    }
                }

                if (resultWeight == 0) { result = 0; }
                else
                {
                    result = resultBall / resultWeight;
                }

                dataGridView1[dataGridView1.Columns.Count - 1, j].Value = result.ToString("N2");

                float[] ballStep = new float[3] { Properties.Settings.Default.twoStep, Properties.Settings.Default.threeStep, Properties.Settings.Default.fourStep };

                if (Properties.Settings.Default.colorIndicateOn == true)
                {
                    if (result >= ballStep[2])
                    {
                        dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (result < ballStep[2] && result >= ballStep[1])
                    {
                        dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (result < ballStep[1] && result >= ballStep[0])
                    {
                        dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else if (result < ballStep[0] && result >= 2)
                    {
                        dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
                    }
                    else
                    {
                        dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.White;

                    }
                }
                else
                {
                    dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.White;
                }

                result = 0;
            }

            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                dataGridView1.AutoResizeColumn(k, DataGridViewAutoSizeColumnMode.DisplayedCells);
            }

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                dataGridView1.AutoResizeRow(k, DataGridViewAutoSizeRowMode.AllCells);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            startEdit = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                {
                    try
                    {
                        if (dataGridView1[j, i].Value.ToString().Length > 1 && dataGridView1[j, i].Value.ToString() != "10")
                        {
                            dataGridView1[j, i].Value = null;
                        }
                    }
                    catch { }

                    try
                    {
                        if (!char.IsDigit(Convert.ToChar(dataGridView1[j, i].Value)) && dataGridView1[j, i].Value.ToString() != "10")
                        {
                            dataGridView1[j, i].Value = null;
                        }
                    }
                    catch { }
                }
            }

            updateCell();

            resultBall();
        }

        private void updateCell()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView1.Columns.Count - 1; j++)
                {
                    if (j % 2 != 0)
                    {
                        if (dataGridView1[j, i].Value != null && dataGridView1[j + 1, i].Value == null)
                        {
                            dataGridView1[j + 1, i].ErrorText = "Введите значение!";
                        }
                        else if (dataGridView1[j, i].Value == null && dataGridView1[j + 1, i].Value != null)
                        {
                            dataGridView1[j, i].ErrorText = "Введите значение!";
                        }
                        else
                        {
                            dataGridView1[j, i].ErrorText = "";
                        }

                    }
                    else
                    {
                        if (dataGridView1[j, i].Value != null && dataGridView1[j - 1, i].Value == null)
                        {
                            dataGridView1[j - 1, i].ErrorText = "Введите значение!";
                        }
                        else if (dataGridView1[j, i].Value == null && dataGridView1[j - 1, i].Value != null)
                        {
                            dataGridView1[j, i].ErrorText = "Введите значение!";
                        }
                        else
                        {
                            dataGridView1[j, i].ErrorText = "";
                        }
                    }
                }
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            updateCell();

            resultBall();
        }

        private bool NextSet(int[] a, int n, int m)
        {
            int j = m - 1;
            while (j >= 0 && a[j] == n) j--;
            if (j < 0) return false;
            if (a[j] >= n)
                j--;
            a[j]++;
            if (j == m - 1) return true;
            for (int k = j + 1; k < m; k++)
                a[k] = 1;
            return true;
        }

        void Print(int[] a, int n, int[,] outBall, int num)
        {
            for (int i = 0; i < n; i++)
            {
                outBall[i, num] = a[i] + 1;
            }
        }

        private void генерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int f = 1; f < dataGridView1.Columns.Count - 1; f++)
                {
                    if (f % 2 != 0)
                    {
                        if (dataGridView1[f, i].Value != null && dataGridView1[f + 1, i].Value == null)
                        {
                            dataGridView1[f, i].Value = null;
                        }
                        else if (dataGridView1[f, i].Value == null && dataGridView1[f + 1, i].Value != null)
                        {
                            dataGridView1[f + 1, i].Value = null;
                        }
                    }
                    else
                    {
                        if (dataGridView1[f, i].Value != null && dataGridView1[f - 1, i].Value == null)
                        {
                            dataGridView1[f, i].Value = null;
                        }
                        else if (dataGridView1[f, i].Value == null && dataGridView1[f - 1, i].Value != null)
                        {
                            dataGridView1[f - 1, i].Value = null;
                        }
                    }
                }
            }

            SettingsAnalytics frm1 = new SettingsAnalytics();
            frm1.ShowDialog();

            if (!frm1.closeButton)
            {
                int colBalls = Convert.ToInt32(frm1.colBalls);
                int[] colWeight = new int[10] { frm1.type[0], frm1.type[1], frm1.type[2], frm1.type[3], frm1.type[4], frm1.type[5], frm1.type[6], frm1.type[7], frm1.type[8], frm1.type[9]}; // 6 7 8 9 10

                colBallSr = new int[colBalls];

                for (int i = 0; i < colBallSr.Length; i++)
                {
                    for (int f = 0; f < 10; f++)
                    {
                        if (colWeight[f] != 0)
                        {
                            colBallSr[i] = f+1;
                            colWeight[f] -= 1;
                            break;
                        }
                    }
                }

                int[] ballSr = new int[] { 2, 3, 4, 5 };
                poslBall = new int[colBalls, Convert.ToInt32(Math.Pow(4, colBalls))];
                int count = 0;

                int[] a;

                int h = Math.Max(4, colBalls); // размер массива а выбирается как max(n,m)
                a = new int[h];
                for (int i = 0; i < h; i++)
                {
                    a[i] = 1;
                }
                Print(a, colBalls, poslBall, 0);
                count++;


                while (NextSet(a, 4, colBalls))
                {
                    Print(a, colBalls, poslBall, count);
                    count++;
                }


                int j = dataGridView1.CurrentRow.Index;

                float result = 0;
                int[] weight = new int[(dataGridView1.Columns.Count - 2) / 2];
                int[] ball = new int[(dataGridView1.Columns.Count - 2) / 2];

                int countBall = 0, countWeight = 0;

                for (int i = 1; i < dataGridView1.Columns.Count - 1; i++)
                {
                    if (dataGridView1[i, j].Value != null && dataGridView1[i, j].Value != "")
                    {
                        if (i % 2 != 0)
                        {
                            ball[countBall] = Convert.ToInt32(dataGridView1[i, j].Value);
                            countBall++;
                        }
                        else
                        {
                            weight[countWeight] = Convert.ToInt32(dataGridView1[i, j].Value);
                            countWeight++;
                        }
                        //result += Convert.ToInt32(dataGridView1[i, j].Value.ToString());
                    }
                }

                int ost = dataGridView1.Columns.Count + colBalls - 2;
                float[] outSrBall = new float[Convert.ToInt32(Math.Pow(4, colBalls))];

                for (int f = 0; f < Convert.ToInt32(Math.Pow(4, colBalls)); f++)
                {
                    float resultBall = 0, resultWeight = 0;
                    int[] balls = new int[dataGridView1.Columns.Count + colBalls];
                    int[] weights = new int[dataGridView1.Columns.Count + colBalls];


                    int countBalls = 0;
                    for (int i = 0; i < colBalls; i++)
                    {
                        if (i > 0)
                        {
                            balls[countBalls] = poslBall[i, f];
                            weights[countBalls] = colBallSr[i];
                        }
                        else
                        {
                            balls[countBalls] = poslBall[i, f];
                            weights[countBalls] = colBallSr[i];
                        }
                        countBalls += 2;
                    }

                    for (int i = 0; i < (dataGridView1.Columns.Count - 2) / 2; i++)
                    {
                        if (ball[i] != 0 && weight[i] != 0)
                        {
                            resultBall += (ball[i]) * (weight[i]);

                            resultWeight += weight[i];
                        }
                    }

                    int countOut = 0;

                    for (int i = 0; i < colBalls; i++)
                    {

                        resultBall += (balls[i + countOut] * weights[i + countOut]);

                        resultWeight += weights[i + countOut];

                        countOut++;
                    }

                    if (resultWeight == 0) { result = 0; }
                    else
                    {
                        result = resultBall / resultWeight;
                    }

                    outSrBall[f] = result;

                }

                int[] dataRow = new int[dataGridView1.Columns.Count - 2];

                for (int i = 0; i < dataGridView1.Columns.Count - 2; i++)
                {
                    try
                    {
                        dataRow[i] = Convert.ToInt32(dataGridView1[i + 1, j].Value);
                    }
                    catch
                    {
                        dataRow[i] = 0;
                    }
                }

                selectBalls frm2 = new selectBalls(j, poslBall, colBallSr, outSrBall, dataRow, Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 1, j].Value),frm1.typeIndividual);

                frm2.Text = dataGridView1["name", j].Value.ToString();

                frm2.ShowDialog();

                int[] selectedBalls = frm2.selectedBalls;
                int[] selectedWeights = frm2.selectedWeights;

                if (selectedBalls != null)
                {
                    int countRepeat = 0;
                    for (int i = dataGridView1.Columns.Count - 2; i >= 0; i--)
                    {
                        try
                        {
                            if (dataGridView1[i, j].Value == null)
                            {
                                countRepeat++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        catch { }

                        //try
                        //{
                        //    if (dataGridView1[i, j].Value == null)
                        //    {
                        //        countRepeat++;
                        //    }
                        //    else
                        //    {
                        //        break;
                        //    }
                        //}
                        //catch { }
                    }

                    columnGenBallWeight(colBallSr.Length - (countRepeat / 2));

                    int countBallAdd = 0, countWeightAdd = 0;
                    for (int i = 0; i < colBalls * 2; i++)
                    {
                        if (i % 2 == 0)
                        {
                            dataGridView1[i + dataRow.Length - countRepeat + 1, j].Value = selectedBalls[countBallAdd].ToString();
                            countBallAdd++;
                        }
                        else
                        {
                            dataGridView1[i + dataRow.Length - countRepeat + 1, j].Value = selectedWeights[countWeightAdd].ToString();
                            countWeightAdd++;
                        }
                    }

                    startEdit = true;

                    resultBall();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "dnv Файл (*.dnv)|*.dnv|txt Файл (*.txt)|*.txt";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileOpened = true;

                Properties.Settings.Default.homeDirectory = openFileDialog1.FileName;
                //Properties.Settings.Default.homeDirectoryOpen = true;
                Properties.Settings.Default.Save();
                //MessageBox.Show(openFileDialog1.FileName);

                string fname = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(fname);

                if (lines.Length != 0 && lines.Length <= 100)
                {

                    int[] checkTrueTable = new int[lines.Length];
                    bool cantReadThisFile = false;

                    for (int j = 0; j < lines.Length; j++)
                    {
                        for (int i = 0; i < lines[j].Length; i++)
                        {
                            if (lines[j][i] == ';')
                            {
                                checkTrueTable[j]++;
                            }
                        }
                    }

                    int constColumns = checkTrueTable[0];

                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (constColumns != checkTrueTable[i])
                            cantReadThisFile = true;
                    }

                    if (!cantReadThisFile)
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        columnSet(false, pred);

                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                        }

                        int count = 0;

                        if (lines.Length == 0 && lines.Length <= 100)
                        {
                            count = 4;
                        }
                        else
                        {
                            for (int i = 0; i < lines[0].Length; i++)
                            {
                                if (lines[0][i] == ';')
                                {
                                    count++;
                                }
                            }
                        }

                        if (count < 4)
                        {
                            count = 4;
                        }

                        count = (count - 2) / 2;

                        columnGenBallWeight(count);

                        dataGridView1.AllowUserToAddRows = false;

                        string[] inpstr;
                        char[] delim = new char[] { ';' };  //Разделители

                        for (int i = 0; i < lines.Length; i++)
                        {
                            inpstr = lines[i].Split(delim);
                            dataGridView1.Rows.Add(inpstr);
                        }

                        resultBall();
                    }
                    else
                    {
                        MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.homeDirectory) && fileOpened)
            {
                startEdit = false;

                StreamWriter myWriter = new StreamWriter(Properties.Settings.Default.homeDirectory);
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value == null)
                            {
                                myWriter.Write("" + ";");
                            }
                            else
                            {
                                myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
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
                //myStream.Close();

                MessageBox.Show("Файл сохранён!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                        fileOpened = false;
                        startEdit = false;

                        Properties.Settings.Default.homeDirectory = saveFileDialog1.FileName;
                        Properties.Settings.Default.Save();

                        StreamWriter myWriter = new StreamWriter(myStream);
                        try
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                                    {
                                        myWriter.Write("" + ";");
                                    }
                                    else
                                    {
                                        myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
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

        private void добавитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            dataGridView1.Rows.Add();
        }

        private void добавитьСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            columnGenBallWeight(1);

            resultBall();
        }

        private void удалитьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void удалитьСтолбецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            if (dataGridView1.CurrentCell.ColumnIndex > 0 && dataGridView1.CurrentCell.ColumnIndex < dataGridView1.Columns.Count - 1 && dataGridView1.CurrentCell.ColumnIndex % 2 != 0)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);
            }
            else if (dataGridView1.CurrentCell.ColumnIndex > 0 && dataGridView1.CurrentCell.ColumnIndex < dataGridView1.Columns.Count - 1 && dataGridView1.CurrentCell.ColumnIndex % 2 == 0)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex);
                dataGridView1.Columns.RemoveAt(dataGridView1.CurrentCell.ColumnIndex - 1);
            }

            resultBall();
        }

        private void очиститьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            DialogResult result = MessageBox.Show("Вы точно хотите очистить полностью таблицу?", "Вы уверены?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                columnSet(true, pred);
            }
        }

        private void редактироватьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startEdit = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int f = 1; f < dataGridView1.Columns.Count - 1; f++)
                {
                    if (f % 2 != 0)
                    {
                        if (dataGridView1[f, i].Value != null && dataGridView1[f + 1, i].Value == null)
                        {
                            dataGridView1[f, i].Value = null;
                        }
                        else if (dataGridView1[f, i].Value == null && dataGridView1[f + 1, i].Value != null)
                        {
                            dataGridView1[f + 1, i].Value = null;
                        }
                    }
                    else
                    {
                        if (dataGridView1[f, i].Value != null && dataGridView1[f - 1, i].Value == null)
                        {
                            dataGridView1[f, i].Value = null;
                        }
                        else if (dataGridView1[f, i].Value == null && dataGridView1[f - 1, i].Value != null)
                        {
                            dataGridView1[f - 1, i].Value = null;
                        }
                    }
                }
            }

            updateCell();

            resultBall();
        }

        private void настрокиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting frm1 = new Setting(dataGridView1, startEdit);
            frm1.ShowDialog();

            resultBall();
        }

        private void clearCell(object sender, EventArgs e)
        {
            startEdit = true;

            if (dataGridView1.CurrentCell.ColumnIndex > 0 && dataGridView1.CurrentCell.ColumnIndex < dataGridView1.Columns.Count - 1)
            {
                dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Value = null;
            }

            updateCell();
            resultBall();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            welcome(Properties.Settings.Default.welcome);

            checkUpdate(false);

            change_log(Properties.Settings.Default.change_log);

            if (File.Exists(Properties.Settings.Default.homeDirectory) && Properties.Settings.Default.homeDirectoryOpen == true && args.Length <= 1)
            {
                DialogResult msg = MessageBox.Show("Открыть предыдущий файл?", "Открыть?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (msg == DialogResult.Yes)
                {
                    fileOpened = true;

                    string fname = Properties.Settings.Default.homeDirectory;
                    string[] lines = File.ReadAllLines(fname);

                    if (lines.Length != 0 && lines.Length <= 100)
                    {

                        int[] checkTrueTable = new int[lines.Length];
                        bool cantReadThisFile = false;

                        for (int j = 0; j < lines.Length; j++)
                        {
                            for (int i = 0; i < lines[j].Length; i++)
                            {
                                if (lines[j][i] == ';')
                                {
                                    checkTrueTable[j]++;
                                }
                            }
                        }

                        int constColumns = checkTrueTable[0];

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (constColumns != checkTrueTable[i])
                                cantReadThisFile = true;
                        }

                        if (!cantReadThisFile)
                        {

                            dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        columnSet(false, pred);

                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                        }

                        int count = 0;

                        if (lines.Length == 0 && lines.Length <= 100)
                        {
                            count = 4;
                        }
                        else
                        {
                            for (int i = 0; i < lines[0].Length; i++)
                            {
                                if (lines[0][i] == ';')
                                {
                                    count++;
                                }
                            }
                        }

                        if (count < 4)
                        {
                            count = 4;
                        }

                        count = (count - 2) / 2;

                        columnGenBallWeight(count);

                        dataGridView1.AllowUserToAddRows = false;

                        string[] inpstr;
                        char[] delim = new char[] { ';' };  //Разделители

                        for (int i = 0; i < lines.Length; i++)
                        {
                            inpstr = lines[i].Split(delim);
                            dataGridView1.Rows.Add(inpstr);
                        }

                        resultBall();
                        }
                        else
                        {
                            MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        fileOpened = false;

                        MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    fileOpened = false;

                    Properties.Settings.Default.homeDirectoryOpen = false;
                    Properties.Settings.Default.Save();

                    columnSet(true, pred);
                }
            }
            else if (args.Length > 1)
            {
                openFileShown(args);
            }
            else
            {
                columnSet(true, pred);
            }

            updateCell();

            resultBall();
        }

        private void написатьОПроблемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorNotification frm = new errorNotification();

            frm.Show();
        }

        private void сообщитьОПроблемеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorNotification frm = new errorNotification();

            frm.Show();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex % 2 == 0 && dataGridView1.CurrentCell.ColumnIndex > 0 && Properties.Settings.Default.openWeight == true)
            {
                addWeight frm = new addWeight();

                frm.ShowDialog();

                dataGridView1[dataGridView1.CurrentCell.ColumnIndex, dataGridView1.CurrentCell.RowIndex].Value = frm.select.ToString();
            }
        }

        private void checkUpdate(bool check)
        {
            if (IsInternetAvailable())
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://drive.google.com/uc?export=download&id=1IP0sA73W3Fhkx5u-_C44dstelFNMiiVN", Path.Combine(Path.GetTempPath(), "version.txt"));
                }
                string vers = File.ReadAllText(Path.Combine(Path.GetTempPath(), "version.txt"));
                if (String.Equals(vers, Application.ProductVersion))
                {
                    if (check == true)
                    {
                        MessageBox.Show("Ваша версиия программы " + Application.ProductVersion + ".\n\rВерсия загруженая на сервере " + vers, "Обновление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    string neravno = "Требуется обновление. Обновить ПО?"; //Эту переменную можно не создавать. Её можно поместить в всплывающее сообщение ниже MessageBox
                                                                           //Создадим событие в MessageBox. Отловим какую кнопку нажмём
                    DialogResult result = MessageBox.Show("Ваша версиия программы " + Application.ProductVersion + ".\n\rВерсия загруженая на сервере " + vers + "\n\r\n\r" + neravno, "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) //Если нажали ДА. Выполняем следующее условие
                    {
                        if (fileOpened == true)
                        {
                            saveFileUpdate();
                        }
                        // Качаем программу
                        WebClient webClient = new WebClient();

                        if (!Properties.Settings.Default.portableVersion)
                        {
                            webClient.DownloadFile("https://drive.google.com/uc?export=download&id=1KDEClWYHJ6iK0kQb3kvFCRrEhruJ1UPF", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Setup.exe"));
                        }
                        else
                        {
                            webClient.DownloadFile("https://drive.google.com/uc?export=download&id=1EFU8OMmtqteYuRek4X6zlkkPJn_EdqlF", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SchoolMetric_v." + vers + ".exe"));
                        }

                        if (!Properties.Settings.Default.portableVersion)
                        {
                            Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Setup.exe"));
                        }
                        else
                        {
                            Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "SchoolMetric_v." + vers + ".exe"));
                        }

                        Properties.Settings.Default.change_log = true;
                        Properties.Settings.Default.Save();

                        Application.Exit();
                    }
                    if (result == DialogResult.No)
                    {
                        return; //Если нажали НЕТ. Возвращаемся.
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет подключения к интернету, проверьте соединение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFileShown(string[] file)
        {
            if (file.Length > 1)
            {
                string ext = Path.GetExtension(file[1]);

                if (ext == ".txt" || ext == ".dnv")
                {
                    fileOpened = true;

                    Properties.Settings.Default.homeDirectory = file[1];
                    //Properties.Settings.Default.homeDirectoryOpen = true;
                    Properties.Settings.Default.Save();
                    //MessageBox.Show(openFileDialog1.FileName);

                    string fname = file[1];
                    string[] lines = File.ReadAllLines(fname);

                    if (lines.Length != 0 && lines.Length <= 100)
                    {

                        int[] checkTrueTable = new int[lines.Length];
                        bool cantReadThisFile = false;

                        for (int j = 0; j < lines.Length; j++)
                        {
                            for (int i = 0; i < lines[j].Length; i++)
                            {
                                if (lines[j][i] == ';')
                                {
                                    checkTrueTable[j]++;
                                }
                            }
                        }

                        int constColumns = checkTrueTable[0];

                        for (int i = 0; i < lines.Length; i++)
                        {
                            if (constColumns != checkTrueTable[i])
                                cantReadThisFile = true;
                        }

                        if (!cantReadThisFile)
                        {

                            dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();

                        columnSet(false, pred);

                        for (int i = 0; i < 2; i++)
                        {
                            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
                        }

                        int count = 0;

                        if (lines.Length == 0 && lines.Length <= 100)
                        {
                            count = 4;
                        }
                        else
                        {
                            for (int i = 0; i < lines[0].Length; i++)
                            {
                                if (lines[0][i] == ';')
                                {
                                    count++;
                                }
                            }
                        }

                        if (count < 4)
                        {
                            count = 4;
                        }

                        count = (count - 2) / 2;

                        columnGenBallWeight(count);

                        dataGridView1.AllowUserToAddRows = false;

                        string[] inpstr;
                        char[] delim = new char[] { ';' };  //Разделители

                        for (int i = 0; i < lines.Length; i++)
                        {
                            inpstr = lines[i].Split(delim);
                            dataGridView1.Rows.Add(inpstr);
                        }

                        resultBall();
                        }
                        else
                        {
                            MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно прочитать файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveFileUpdate()
        {
            if (File.Exists(Properties.Settings.Default.homeDirectory) && fileOpened == true && startEdit == true)
            {
                StreamWriter myWriter = new StreamWriter(Properties.Settings.Default.homeDirectory);
                try
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value == null)
                            {
                                myWriter.Write("" + ";");
                            }
                            else
                            {
                                myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
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
                //myStream.Close();
                MessageBox.Show("Файл сохранён!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                                    {
                                        myWriter.Write("" + ";");
                                    }
                                    else
                                    {
                                        myWriter.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + ";");
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

        private void programUpdate(object sender, EventArgs e)
        {
            checkUpdate(true);
        }

        private void aboutProgram(object sender, EventArgs e)
        {
            AboutProgram about = new AboutProgram();

            about.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();

            saveFileUpdate();
        }

        private void saveSettings()
        {
            StreamWriter saveSettings = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\settings.json"));
            try
            {
                TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));

                //saveSettings.Write($"{Properties.Settings.Default.colorIndicateOn}#{Properties.Settings.Default.twoColor}#{Properties.Settings.Default.threeColor}#{Properties.Settings.Default.fourColor}#{Properties.Settings.Default.fiveColor}#{Properties.Settings.Default.twoStep}#{Properties.Settings.Default.threeStep}#{Properties.Settings.Default.fourStep}#{Properties.Settings.Default.homeDirectory}#{tc.ConvertToString(Properties.Settings.Default.font)}#{Properties.Settings.Default.homeDirectoryOpen}#{tc.ConvertToString(Properties.Settings.Default.fontBall)}#{tc.ConvertToString(Properties.Settings.Default.fontWeight)}#{Properties.Settings.Default.asdasd}#{Properties.Settings.Default.openWeight}#{Properties.Settings.Default.welcome}#{Properties.Settings.Default.change_log}");

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
        }

        private void поднятьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = new string[dataGridView1.Columns.Count - 1];

            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                try
                {
                    data[i] = dataGridView1[i, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                catch
                {
                    data[i] = "";
                }
            }

            if (dataGridView1.CurrentCell.RowIndex != 0)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows.RemoveAt(index);

                dataGridView1.Rows.Insert(index - 1, data);

                dataGridView1.Rows[index - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, index - 1];
            }

            updateCell();

            resultBall();
        }

        private void опуститьСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = new string[dataGridView1.Columns.Count - 1];

            for (int i = 0; i < dataGridView1.Columns.Count - 1; i++)
            {
                try
                {
                    data[i] = dataGridView1[i, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                }
                catch
                {
                    data[i] = "";
                }
            }

            if (dataGridView1.CurrentCell.RowIndex != dataGridView1.Rows.Count - 1)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows.RemoveAt(index);

                dataGridView1.Rows.Insert(index + 1, data);

                dataGridView1.Rows[index + 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[dataGridView1.CurrentCell.ColumnIndex, index + 1];
            }

            updateCell();

            resultBall();
        }

        public void change_log(bool show)
        {
            if (IsInternetAvailable())
            {
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://drive.google.com/uc?export=download&id=1IP0sA73W3Fhkx5u-_C44dstelFNMiiVN", Path.Combine(Path.GetTempPath(), "version.txt"));
                }
                string vers = File.ReadAllText(Path.Combine(Path.GetTempPath(), "version.txt"));
                if (!String.Equals(vers, Application.ProductVersion))
                {
                    show = false;
                }

                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile("https://drive.google.com/uc?export=download&id=1UwtrW5OZG7z-0FFVN3_v7lfNH44RQy6f", Path.Combine(Path.GetTempPath(), "change_log.txt"));
                }
                string change_log = File.ReadAllText(Path.Combine(Path.GetTempPath(), "change_log.txt"), System.Text.Encoding.GetEncoding(1251));

                if (show)
                {
                    MessageBox.Show(change_log, "Что изменилось в обновлении", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Properties.Settings.Default.change_log = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        public static Font StringToFont(string font)
        {
            //font = font.Replace("[", "");
            //font = font.Replace("]","");
            //font = font.Replace(Convert.ToString('"'), "");

            //var cvt = new FontConverter();
            //Font f = cvt.ConvertFromString(font) as Font;

            //return f;

            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Font));
            Font newFont = (Font)tc.ConvertFromString(font);

            return newFont;
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

        private void restoreSettings()
        {
            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал")))
            {
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\settings.json")))
                {
                    string Setting = "";

                    StreamReader openSettings = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\settings.json"));
                    try
                    {
                        Setting = openSettings.ReadLine();
                    }
                    catch { }
                    finally
                    {
                        openSettings.Close();
                    }

                    metric metric;
                    metric = JsonConvert.DeserializeObject<metric>(Setting);

                    //MessageBox.Show($"{settingsValues[0]}\n{settingsValues[1]}\n{settingsValues[2]}\n{settingsValues[3]}\n{settingsValues[4]}\n{settingsValues[5]}\n{settingsValues[6]}\n{settingsValues[7]}\n{settingsValues[8]}\n{settingsValues[9]}\n{settingsValues[10]}\n{settingsValues[11]}\n{settingsValues[12]}\n{settingsValues[13]}\n{settingsValues[14]}\n{settingsValues[15]}");

                    Properties.Settings.Default.colorIndicateOn = metric.colorIndicateOn;
                    Properties.Settings.Default.twoColor = metric.twoColor;
                    Properties.Settings.Default.threeColor = metric.threeColor;
                    Properties.Settings.Default.fourColor = metric.fourColor;
                    Properties.Settings.Default.fiveColor = metric.fiveColor;
                    Properties.Settings.Default.twoStep = metric.twoStep;
                    Properties.Settings.Default.threeStep = metric.threeStep;
                    Properties.Settings.Default.fourStep = metric.fourStep;
                    Properties.Settings.Default.homeDirectory = metric.homeDirectory;
                    Properties.Settings.Default.font = StringToFont(metric.font);
                    Properties.Settings.Default.homeDirectoryOpen = metric.homeDirectoryOpen;
                    Properties.Settings.Default.fontBall = StringToFont(metric.fontBall);
                    Properties.Settings.Default.fontWeight = StringToFont(metric.fontWeight);
                    Properties.Settings.Default.openWeight = metric.openWeight;
                    Properties.Settings.Default.welcome = metric.welcome;
                    Properties.Settings.Default.change_log = metric.change_log;

                    Properties.Settings.Default.oneWeight = metric.allWeights.oneWeight;
                    Properties.Settings.Default.twoWeight = metric.allWeights.twoWeight;
                    Properties.Settings.Default.threeWeight = metric.allWeights.threeWeight;
                    Properties.Settings.Default.fourWeight = metric.allWeights.fourWeight;
                    Properties.Settings.Default.fiveWeight = metric.allWeights.fiveWeight;
                    Properties.Settings.Default.fourWeight = metric.allWeights.fourWeight;
                    Properties.Settings.Default.fiveWeight = metric.allWeights.fiveWeight;
                    Properties.Settings.Default.sixWeight = metric.allWeights.sixWeight;
                    Properties.Settings.Default.sevenWeight = metric.allWeights.sevenWeight;
                    Properties.Settings.Default.eightWeight = metric.allWeights.eightWeight;
                    Properties.Settings.Default.nineWeight = metric.allWeights.nineWeight;
                    Properties.Settings.Default.tenWeight = metric.allWeights.tenWeight;

                    Properties.Settings.Default.oneText = metric.textWeights.oneText;
                    Properties.Settings.Default.twoText = metric.textWeights.twoText;
                    Properties.Settings.Default.threeText = metric.textWeights.threeText;
                    Properties.Settings.Default.fourText = metric.textWeights.fourText;
                    Properties.Settings.Default.fiveText = metric.textWeights.fiveText;
                    Properties.Settings.Default.fourText = metric.textWeights.fourText;
                    Properties.Settings.Default.fiveText = metric.textWeights.fiveText;
                    Properties.Settings.Default.sixText = metric.textWeights.sixText;
                    Properties.Settings.Default.sevenText = metric.textWeights.sevenText;
                    Properties.Settings.Default.eightText = metric.textWeights.eightText;
                    Properties.Settings.Default.nineText = metric.textWeights.nineText;
                    Properties.Settings.Default.tenText = metric.textWeights.tenText;
                }
                else
                {
                    //File.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\settings.json"));
                    saveSettings();
                }
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал"));
            }
        }

        private void посмотретьНоввоведенияВЭтойВерсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change_log(true);
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                string[] args = new string[2] { "", file};

                saveFileUpdate();

                openFileShown(args);
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void вставитьОценкиИзБуфераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBallsBuffer frm1 = new addBallsBuffer();

            frm1.ShowDialog();

            if (frm1.balls.TextLength != 0 && !frm1.closeButton)
            {
                int countRepeat = 0;
                for (int i = dataGridView1.Columns.Count - 2; i >= 0; i--)
                {
                    try
                    {
                        if (dataGridView1[i, dataGridView1.CurrentCell.RowIndex].Value == null)
                        {
                            countRepeat++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch { }
                }

                int[] dataRow = new int[dataGridView1.Columns.Count - 2];

                for (int i = 0; i < dataGridView1.Columns.Count - 2; i++)
                {
                    try
                    {
                        dataRow[i] = Convert.ToInt32(dataGridView1[i + 1, dataGridView1.CurrentCell.RowIndex].Value);
                    }
                    catch
                    {
                        dataRow[i] = 0;
                    }
                }

                columnGenBallWeight((frm1.ballsStr.Length * 2 - countRepeat) / 2);

                int abs = 0;

                if (dataRow.Length - countRepeat > 0)
                    abs = dataRow.Length - countRepeat;

                int countBallAdd = 0, countWeightAdd = 0;
                for (int i = 0; i < frm1.ballsStr.Length * 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        dataGridView1[i + abs + 1, dataGridView1.CurrentCell.RowIndex].Value = frm1.ballsStr[countBallAdd].ToString();
                        countBallAdd++;
                    }
                    else if (frm1.weightStr.Length != 0)
                    {
                        dataGridView1[i + abs + 1, dataGridView1.CurrentCell.RowIndex].Value = frm1.weightStr[countWeightAdd].ToString();
                        countWeightAdd++;
                    }
                }

                startEdit = true;

                updateCell();

                resultBall();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Testing shortcut!");
        }

        private void dnevnikCopyMarks_Click(object sender, EventArgs e)
        {
            dnevnikWebBrowser frm = new dnevnikWebBrowser();

            frm.ShowDialog();

            DialogResult result = DialogResult.No;

            if ((fileOpened == true || startEdit == true ) && frm.insertMarks)
                result = MessageBox.Show("Перед тем как вставить оценки из электронного журнала нужно сохранить текущие оценки.\n\nСохранить?", "Сохранить", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes && frm.insertMarks)
                saveFileUpdate();

            if (frm.names.Count > 0 && frm.insertMarks)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                pred.Clear();

                for (int i = 0; i < frm.names.Count; i++)
                {
                    pred.Add(frm.names[i]);
                }

                columnSet(true, pred);

                int maxLen = 0;

                for (int i = 0; i < frm.marks.Count; i++)
                {
                    frm.marks[i] = frm.marks[i].Replace(" ", "");

                    if (frm.marks[i].Length > maxLen)
                    {
                        maxLen = frm.marks[i].Length;
                    }
                }

                columnGenBallWeight(maxLen);

                int countBallAdd = 0, countWeightAdd = 0;

                for (int i = 0; i < frm.marks.Count; i++)
                {
                    for (int j = 0; j < frm.marks[i].Length*2;j++)
                    {
                        if (j % 2 == 0)
                        {
                            dataGridView1[j + 1, i].Value = frm.marks[i][countBallAdd].ToString();
                            countBallAdd++;
                        }
                        else
                        {
                            dataGridView1[j + 1, i].Value = frm.weights[countWeightAdd].ToString();
                            countWeightAdd++;
                        }
                    }

                    countBallAdd = 0;
                }

                startEdit = true;
            }

            updateCell();

            resultBall();
        }
    }
}

