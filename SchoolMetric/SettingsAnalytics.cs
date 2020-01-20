using System;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class SettingsAnalytics : Form
    {
        public int colBalls = 0;
        public int[] type = new int[10];
        public int[,] typeIndividual = new int[2,10];

        public SettingsAnalytics()
        {
            InitializeComponent();

            addDataMenuCount(Properties.Settings.Default.oneWeight, 1, Properties.Settings.Default.oneText);
            addDataMenuCount(Properties.Settings.Default.twoWeight, 2, Properties.Settings.Default.twoText);
            addDataMenuCount(Properties.Settings.Default.threeWeight, 3, Properties.Settings.Default.threeText);
            addDataMenuCount(Properties.Settings.Default.fourWeight, 4, Properties.Settings.Default.fourText);
            addDataMenuCount(Properties.Settings.Default.fiveWeight, 5, Properties.Settings.Default.fiveText);
            addDataMenuCount(Properties.Settings.Default.sixWeight, 6, Properties.Settings.Default.sixText);
            addDataMenuCount(Properties.Settings.Default.sevenWeight, 7, Properties.Settings.Default.sevenText);
            addDataMenuCount(Properties.Settings.Default.eightWeight, 8, Properties.Settings.Default.eightText);
            addDataMenuCount(Properties.Settings.Default.nineWeight, 9, Properties.Settings.Default.nineText);
            addDataMenuCount(Properties.Settings.Default.tenWeight, 10, Properties.Settings.Default.tenText);

            pos = 0;

            addDataMenuIndividual(Properties.Settings.Default.oneWeight, 1, Properties.Settings.Default.oneText);
            addDataMenuIndividual(Properties.Settings.Default.twoWeight, 2, Properties.Settings.Default.twoText);
            addDataMenuIndividual(Properties.Settings.Default.threeWeight, 3, Properties.Settings.Default.threeText);
            addDataMenuIndividual(Properties.Settings.Default.fourWeight, 4, Properties.Settings.Default.fourText);
            addDataMenuIndividual(Properties.Settings.Default.fiveWeight, 5, Properties.Settings.Default.fiveText);
            addDataMenuIndividual(Properties.Settings.Default.sixWeight, 6, Properties.Settings.Default.sixText);
            addDataMenuIndividual(Properties.Settings.Default.sevenWeight, 7, Properties.Settings.Default.sevenText);
            addDataMenuIndividual(Properties.Settings.Default.eightWeight, 8, Properties.Settings.Default.eightText);
            addDataMenuIndividual(Properties.Settings.Default.nineWeight, 9, Properties.Settings.Default.nineText);
            addDataMenuIndividual(Properties.Settings.Default.tenWeight, 10, Properties.Settings.Default.tenText);

            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                countWeights.Rows[i].Cells[2].Value = (countWeights.Columns[2] as DataGridViewComboBoxColumn).Items[0];
            }


            ////this.Width = Math.Max(type1Label.Width, Math.Max(type2Label.Width, Math.Max(type3Label.Width, Math.Max(type4Label.Width, Math.Max(type5Label.Width, Math.Max(type6Label.Width, Math.Max(type7Label.Width, Math.Max(type8Label.Width, Math.Max(type9Label.Width, type10Label.Width))))))))) + 240;
            StartPosition = FormStartPosition.CenterScreen;
        }

        int pos;

        private void addDataMenuCount(bool state, int _pos, string text)
        {
            if (state)
            {
                countWeights.Rows.Add();
                countWeights.Rows[pos].Cells[0].Value = _pos;
                countWeights.Rows[pos].Cells[1].Value = text;

                pos++;
            }
        }

        private void addDataMenuIndividual(bool state, int _pos, string text)
        {
            if (state)
            {
                individualWeigthsСomplexity.Rows.Add();
                individualWeigthsСomplexity.Rows[pos].Cells[0].Value = _pos;
                individualWeigthsСomplexity.Rows[pos].Cells[1].Value = text;
                individualWeigthsСomplexity.Rows[pos].Cells[2].Value = (individualWeigthsСomplexity.Columns[2] as DataGridViewComboBoxColumn).Items[0];
                individualWeigthsСomplexity.Rows[pos].Cells[3].Value = (individualWeigthsСomplexity.Columns[3] as DataGridViewComboBoxColumn).Items[3];
                //dataGridView1.Rows[pos].Cells[4].Value = (dataGridView1.Columns[4] as DataGridViewComboBoxColumn).Items[2];

                pos++;
            }
        }

        public bool closeButton = true;

        private void ValueChanged(object sender, EventArgs e)
        {
            //updateNum();

            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                colBalls += Convert.ToInt16(countWeights.Rows[i].Cells[2].Value);
            }

            //colBalls = Convert.ToInt16(type1.Value + type2.Value + type3.Value + type4.Value + type5.Value + type6.Value + type7.Value + type8.Value + type9.Value + type10.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                if (Convert.ToInt16(countWeights.Rows[i].Cells[2].Value) != 0)
                {
                    type[Convert.ToInt16(countWeights.Rows[i].Cells[0].Value) - 1] = Convert.ToInt16(countWeights.Rows[i].Cells[2].Value);
                }
                else
                {
                    type[Convert.ToInt16(countWeights.Rows[i].Cells[0].Value) - 1] = 0;
                }
            }

            colBalls = 0;

            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                colBalls += Convert.ToInt16(countWeights.Rows[i].Cells[2].Value);
            }

            closeButton = false;

            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                typeIndividual[0, Convert.ToInt16(individualWeigthsСomplexity.Rows[i].Cells[0].Value) - 1] = Convert.ToInt16(individualWeigthsСomplexity.Rows[i].Cells[2].Value);
                typeIndividual[1, Convert.ToInt16(individualWeigthsСomplexity.Rows[i].Cells[0].Value) - 1] = Convert.ToInt16(individualWeigthsСomplexity.Rows[i].Cells[3].Value);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                countWeights.Rows[i].Cells[2].Value = 0;
            }

            colBalls = 0;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            colBalls = 0;

            for (int i = 0; i < countWeights.Rows.Count; i++)
            {
                colBalls += Convert.ToInt16(countWeights.Rows[i].Cells[2].Value);
            }

            
        }

        private void CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }
    }
}
