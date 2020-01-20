using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class selectBalls : Form
    {
        float[] ballStep = new float[3] { Properties.Settings.Default.twoStep, Properties.Settings.Default.threeStep, Properties.Settings.Default.fourStep };
        public int[] selectedBalls;
        public int[] selectedWeights;
        int[] colBallSr;
        int[] dataRow;
        int num;
        int[,] poslBall;
        int[,] typeIndividual;
        float[] outSrBall;
        float srBall;
        int lengthMarks = 0;

        class gridTable
        {
            public DataGridView selectBallsGrid { get; set; }
        }

        public selectBalls(int num, int[,] poslBall, int[] colBallSr, float[] outSrBall, int[] dataRow, float srBall, int[,] typeIndividual)
        {
            InitializeComponent();

            updateBuff(num, poslBall, colBallSr, outSrBall, dataRow, srBall, typeIndividual);

            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            dataGridView1.Font = Properties.Settings.Default.font;
        }

        static void updateSelectBallsGrid(DataGridView _balls)
        {
            gridTable grid = new gridTable();

            grid.selectBallsGrid = _balls;
        }

        private void updateBuff(int _num, int[,] _poslBall, int[] _colBallSr, float[] _outSrBall, int[] _dataRow, float _srBall, int[,] _typeIndividual)
        {
            num = _num;
            poslBall = _poslBall;
            colBallSr = _colBallSr;
            outSrBall = _outSrBall;
            dataRow = _dataRow;
            srBall = _srBall;
            typeIndividual = _typeIndividual;
        }

        private void filterTable(float of, float to, bool two, bool three, bool four, bool five, int dataRowLen, bool rasnPos, bool rasnNet, bool rasnNeg)
        {

            updateTable(num, poslBall, colBallSr, outSrBall, dataRow, srBall);

            int rowLen = 0, step = 0;

            rowLen = dataGridView1.Rows.Count;

            while (step < rowLen) {
                int count = 0;

                for (int j = lengthMarks; j < dataGridView1.Columns.Count - 3; j++)
                {
                    try
                    {
                        if (Convert.ToInt16(dataGridView1[j, step].Value) == 2 && two == false) 
                        {
                            count++;
                        }
                    } catch { }

                    try
                    {
                        if (Convert.ToInt16(dataGridView1[j, step].Value) == 3 && three == false)
                        {
                            count++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (Convert.ToInt16(dataGridView1[j, step].Value) == 4 && four == false)
                        {
                            count++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (Convert.ToInt16(dataGridView1[j, step].Value) == 5 && five == false)
                        {
                            count++;
                        }
                    }
                    catch { }

                    try
                    {
                        if (Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 3, step].Value) < of || Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 3, step].Value) > to)
                        {
                            count++;
                        }
                    } catch { }
                }

                if (Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 1, step].Value) > 0 && !rasnPos)
                {
                    count++;
                }
                else if (Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 1, step].Value) == 0 && !rasnNet)
                {
                    count++;
                }
                else if (Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 1, step].Value) < 0 && !rasnNeg)
                {
                    count++;
                }

                if (count != 0)
                {
                    dataGridView1.Rows.RemoveAt(step);
                    step = 0;
                    rowLen = dataGridView1.Rows.Count;
                }
                else
                {
                    step++;
                }
            }
        }

        private void columnsGen(int colOldBalls, int colNewBalls)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            var srBallColumn = new DataGridViewColumn();
            srBallColumn.HeaderText = "Балл"; //текст в шапке
            srBallColumn.Width = 75; //ширина колонки
            srBallColumn.ReadOnly = false; //значение в этой колонке нельзя править
            srBallColumn.Name = "ball"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            srBallColumn.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
            srBallColumn.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            srBallColumn.DisplayIndex = 999;

            var srBallColumnDo = new DataGridViewColumn();
            srBallColumnDo.HeaderText = "Старый балл"; //текст в шапке
            srBallColumnDo.Width = 75; //ширина колонки
            srBallColumnDo.ReadOnly = false; //значение в этой колонке нельзя править
            srBallColumnDo.Name = "ballBefore"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            srBallColumnDo.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
            srBallColumnDo.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            srBallColumnDo.DisplayIndex = 9999;

            var srBallColumnRasn = new DataGridViewColumn();
            srBallColumnRasn.SortMode = DataGridViewColumnSortMode.NotSortable;
            srBallColumnRasn.HeaderText = "Разность баллов"; //текст в шапке
            srBallColumnRasn.Width = 75; //ширина колонки
            srBallColumnRasn.ReadOnly = false; //значение в этой колонке нельзя править
            srBallColumnRasn.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
            srBallColumnRasn.Name = "ballRasn"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            srBallColumnRasn.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            srBallColumnRasn.DisplayIndex = 9999;

            dataGridView1.AllowUserToAddRows = false;

            for (int i = 0; i < colOldBalls; i++)
            {
                var ball = new DataGridViewColumn();
                ball.HeaderText = "Оценка"; //текст в шапке
                ball.Width = 50; //ширина колонки
                ball.DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
                ball.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
                ball.ReadOnly = false; //значение в этой колонке нельзя править
                ball.Name = "val"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                ball.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки  var weight = new DataGridViewColumn();

                var weight = new DataGridViewColumn();
                weight.HeaderText = "Вес";
                weight.Width = 30;
                weight.DefaultCellStyle.Font = Properties.Settings.Default.fontWeight;
                weight.DefaultCellStyle.BackColor = Color.FromArgb(179, 179, 179);
                weight.Name = "costs";
                weight.CellTemplate = new DataGridViewTextBoxCell();

                dataGridView1.Columns.Add(ball);
                dataGridView1.Columns.Add(weight);
            }

            for (int i = 0; i < colNewBalls; i++)
            {
                var ball = new DataGridViewColumn();
                ball.HeaderText = "Оценка"; //текст в шапке
                ball.Width = 50; //ширина колонки
                if (Properties.Settings.Default.colorIndicateOn == true)
                {
                    ball.DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else
                {
                    ball.DefaultCellStyle.BackColor = Color.FromArgb(221, 221, 221);
                }
                ball.ReadOnly = false; //значение в этой колонке нельзя править
                ball.DefaultCellStyle.Font = Properties.Settings.Default.fontBall;
                ball.Name = "val"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                ball.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

                var weight = new DataGridViewColumn();
                weight.HeaderText = "Вес";
                weight.Width = 30;
                weight.DefaultCellStyle.Font = Properties.Settings.Default.fontWeight;
                if (Properties.Settings.Default.colorIndicateOn == true)
                {
                    weight.DefaultCellStyle.BackColor = Color.FromArgb(0, 159, 7);
                }
                else
                {
                    weight.DefaultCellStyle.BackColor = Color.FromArgb(179, 179, 179);
                }
                weight.Name = "costs";
                weight.CellTemplate = new DataGridViewTextBoxCell();

                dataGridView1.Columns.Add(ball);
                dataGridView1.Columns.Add(weight);
            }

            dataGridView1.Columns.Add(srBallColumn);
            dataGridView1.Columns.Add(srBallColumnDo);
            dataGridView1.Columns.Add(srBallColumnRasn);
        }

        private void updateTable(int num, int[,] poslBall, int[] colBallSr, float[] outSrBall, int[] dataRow, float srBall)
        {
            gridTable grid = new gridTable();

            if (grid.selectBallsGrid == null)
            {
                mainProgressBar.Value = 0;

                ballRange.Enabled = false;
                filterMarks.Enabled = false;
                sorts.Enabled = false;

                lengthMarks = 0;

                for (int i = 0; i < dataRow.Length; i++)
                {
                    if (dataRow[i] != 0) lengthMarks++;
                }

                mainProgressBar.Value = 20;

                columnsGen(lengthMarks / 2, colBallSr.Length);

                mainProgressBar.Value = mainProgressBar.Value + 20;

                for (int j = 0; j < Convert.ToInt32(Math.Pow(4, colBallSr.Length)); j++)
                {
                    string[] data = new string[lengthMarks + (colBallSr.Length * 2) + 3];

                    data[lengthMarks + colBallSr.Length * 2] = outSrBall[j].ToString("N2");

                    for (int i = 0; i < lengthMarks; i++)
                    {
                        if (dataRow[i] == 0)
                        {
                            data[i] = null;
                        }
                        else
                        {
                            if (dataRow[i] == 0) { data[i] = null; }
                            else
                            {
                                data[i] = dataRow[i].ToString();
                            }
                        }
                    }

                    int count = 0;
                    for (int i = 0; i <= colBallSr.Length + colBallSr.Length - 2; i = i + 2)
                    {
                        data[i + lengthMarks] = poslBall[count, j].ToString();
                        data[i + lengthMarks + 1] = colBallSr[count].ToString();
                        count++;
                    }

                    data[dataGridView1.Columns.Count - 2] = srBall.ToString("N2");

                    data[dataGridView1.Columns.Count - 1] = (Convert.ToSingle(data[dataGridView1.Columns.Count - 3]) - Convert.ToSingle(data[dataGridView1.Columns.Count - 2])).ToString("N2");

                    dataGridView1.Rows.Add(data);

                    for (int i = 0; i < dataGridView1.Columns.Count - 3; i++)
                    {
                        if (i % 2 != 0)
                        {
                            try
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
                            }
                            catch
                            {
                                dataGridView1[i, j].ToolTipText = "";
                            }
                        }
                    }

                    float numberBall = Convert.ToSingle(dataGridView1[dataGridView1.Columns.Count - 3, j].Value);

                    if (Properties.Settings.Default.colorIndicateOn == true)
                    {
                        if (numberBall >= ballStep[2])
                        {
                            dataGridView1[dataGridView1.Columns.Count - 3, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fiveColor, System.Globalization.NumberStyles.HexNumber));
                        }
                        else if (numberBall < ballStep[2] && numberBall >= ballStep[1])
                        {
                            dataGridView1[dataGridView1.Columns.Count - 3, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.fourColor, System.Globalization.NumberStyles.HexNumber));
                        }
                        else if (numberBall < ballStep[1] && numberBall >= ballStep[0])
                        {
                            dataGridView1[dataGridView1.Columns.Count - 3, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.threeColor, System.Globalization.NumberStyles.HexNumber));
                        }
                        else if (numberBall < ballStep[0] && numberBall >= 2)
                        {
                            dataGridView1[dataGridView1.Columns.Count - 3, j].Style.BackColor = Color.FromArgb(int.Parse(Properties.Settings.Default.twoColor, System.Globalization.NumberStyles.HexNumber));
                        }
                    }
                    else
                    {
                        dataGridView1[dataGridView1.Columns.Count - 3, j].Style.BackColor = Color.White;
                    }


                    if (Convert.ToSingle(data[dataGridView1.Columns.Count - 3]) - Convert.ToSingle(data[dataGridView1.Columns.Count - 2]) > 0)
                    {
                        if (Properties.Settings.Default.colorIndicateOn == true)
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.White;
                        }
                    }
                    else if (Convert.ToSingle(data[dataGridView1.Columns.Count - 3]) - Convert.ToSingle(data[dataGridView1.Columns.Count - 2]) == 0)
                    {
                        if (Properties.Settings.Default.colorIndicateOn == true)
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        if (Properties.Settings.Default.colorIndicateOn == true)
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            dataGridView1[dataGridView1.Columns.Count - 1, j].Style.BackColor = Color.White;
                        }
                    }
                }

                mainProgressBar.Value = mainProgressBar.Value + 20;

                List<int> checkedRows = new List<int>();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    List<List<int>> ball = new List<List<int>>();

                    for (int j = 1; j < 11; j++)
                    {
                        List<int> ballBuff = new List<int>();

                        for (int k = lengthMarks; k < dataGridView1.Columns.Count - 4; k = k + 2)
                        {
                            if (Convert.ToInt16(dataGridView1[k + 1, i].Value) == j)
                            {
                                ballBuff.Add(Convert.ToInt16(dataGridView1[k, i].Value));
                            }
                        }
                        ball.Add(ballBuff);
                    }

                    //код для отсечения не нужных чисел

                    //int[] countBalls = new int[10]; // ghjdthbnm

                    bool newMatch = false;

                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    { //&& dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value.ToString() != "fail" 
                        bool trueCheck = true;

                        for (int g = 0; g < checkedRows.Count; g++)
                        {
                            if (k == checkedRows[g])
                            {
                                trueCheck = false;
                            }
                        }

                        if (k != i && trueCheck && dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 3].Value.ToString() == dataGridView1.Rows[k].Cells[dataGridView1.Columns.Count - 3].Value.ToString())
                        {
                            List<List<int>> ballTest = new List<List<int>>();

                            for (int j = 1; j < 11; j++)
                            {
                                List<int> ballBuff = new List<int>();

                                for (int l = lengthMarks; l < dataGridView1.Columns.Count - 4; l = l + 2)
                                {
                                    if (Convert.ToInt16(dataGridView1[l + 1, k].Value) == j)
                                    {
                                        ballBuff.Add(Convert.ToInt16(dataGridView1[l, k].Value));
                                    }
                                }
                                ballTest.Add(ballBuff);
                            }

                            int[,] count = new int[2, 4];

                            for (int h = 0; h < 10; h++)
                            {
                                for (int g = 0; g < ball[h].Count; g++)
                                {
                                    for (int f = 2; f < 6; f++)
                                    {
                                        if (ball[h][g] == f)
                                        {
                                            count[0, f - 2]++;
                                            break;
                                        }
                                    }
                                }

                                for (int g = 0; g < ballTest[h].Count; g++)
                                {
                                    for (int f = 2; f < 6; f++)
                                    {
                                        if (ballTest[h][g] == f)
                                        {
                                            count[1, f - 2]++;
                                            break;
                                        }
                                    }
                                }
                            }

                            bool notMatch = true;

                            for (int g = 0; g < 4; g++)
                            {
                                bool exitFor = false;

                                if (count[0, g] != count[1, g])
                                {
                                    notMatch = false;
                                    exitFor = true;
                                }

                                if (exitFor) break;
                            }

                            if (notMatch)
                            {
                                dataGridView1.Rows.RemoveAt(i); //.RemoveAt(i) //[i].Cells[dataGridView1.Columns.Count - 1].Value = "fail";
                                checkedRows.Add(i);
                                newMatch = true;
                            }
                        }
                    }

                    if (newMatch) i = -1;
                }

                mainProgressBar.Value = mainProgressBar.Value + 20;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool startNew = false;

                    for (int k = lengthMarks; k < dataGridView1.Columns.Count - 4; k++)
                    {
                        if (k % 2 == 0)
                        {
                            for (int f = 0; f < 10; f++)
                            {
                                if ((Convert.ToInt16(dataGridView1[k, i].Value) < typeIndividual[0, f] || Convert.ToInt16(dataGridView1[k, i].Value) > typeIndividual[1, f]) && Convert.ToInt16(dataGridView1[k + 1, i].Value) == f + 1 && typeIndividual[0, f] != 0 && typeIndividual[1, f] != 0)
                                {
                                    dataGridView1.Rows.RemoveAt(i);
                                    startNew = true;
                                }
                            }
                        }
                    }

                    if (startNew) i = -1;
                }

                mainProgressBar.Value = mainProgressBar.Value + 20;

                ballRange.Enabled = true;
                filterMarks.Enabled = true;
                sorts.Enabled = true;
            }
            else
            {
                dataGridView1 = grid.selectBallsGrid;
            }

            autoResizeTable();
        }

        private void updateFilterTable(object sender, EventArgs e)
        {
            filterTable(Convert.ToSingle(toolStripComboBox2.Text), Convert.ToSingle(toolStripComboBox1.Text), twoMark.Checked, threeMark.Checked, fourMark.Checked, fiveMark.Checked, dataRow.Length, positive.Checked, neutral.Checked, negative.Checked);

            upValues.Checked = false;
            downValues.Checked = false;
        }

        private void выбратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int select = dataGridView1.CurrentRow.Index;
            int countBallsAdd = 0, countWeightsAdd = 0;

            selectedBalls = new int[colBallSr.Length];
            selectedWeights = new int[colBallSr.Length];

            for (int i = lengthMarks; i < dataGridView1.Columns.Count - 3; i++)
            {
                if (i % 2 == 0)
                {
                    selectedBalls[countBallsAdd] = Convert.ToInt16(dataGridView1[i, select].Value);
                    countBallsAdd++;
                }
                else
                {
                    selectedWeights[countWeightsAdd] = Convert.ToInt16(dataGridView1[i, select].Value);
                    countWeightsAdd++;
                }
            }
            this.Close();
        }

        private void autoResizeTable()
        {
            for (int k = 0; k < dataGridView1.Columns.Count; k++)
            {
                dataGridView1.AutoResizeColumn(k, DataGridViewAutoSizeColumnMode.DisplayedCells);
            }

            for (int k = 0; k < dataGridView1.Rows.Count; k++)
            {
                dataGridView1.AutoResizeRow(k, DataGridViewAutoSizeRowMode.AllCells);
            }
        }

        private void selectBalls_Shown(object sender, EventArgs e)
        {
            updateTable(num, poslBall, colBallSr, outSrBall, dataRow, srBall);

            updateSelectBallsGrid(dataGridView1);

            autoResizeTable();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
            twoMark.Checked = true;
            threeMark.Checked = true;
            fourMark.Checked = true;
            fiveMark.Checked = true;
            upValues.Checked = false;
            downValues.Checked = false;

            filterTable(Convert.ToSingle(toolStripComboBox2.Text), Convert.ToSingle(toolStripComboBox1.Text), twoMark.Checked, threeMark.Checked, fourMark.Checked, fiveMark.Checked, dataRow.Length, positive.Checked, neutral.Checked, negative.Checked);
        }

        private void поВозростаниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            downValues.Checked = false;
            dataGridView1.Sort(dataGridView1.Columns["ball"], ListSortDirection.Descending);
        }

        private void поУбываниюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            upValues.Checked = false;
            dataGridView1.Sort(dataGridView1.Columns["ball"], ListSortDirection.Ascending);
        }
    }
}
