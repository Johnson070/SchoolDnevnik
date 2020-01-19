using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class addValuesDnevnik : Form
    {
        weights weightsMarksData;

        public List<string> namesMarks = new List<string>();
        public List<string> weightMarks = new List<string>();
        public List<string> weightBuff = new List<string>();
        public bool insertMarks = true;
        bool saveMarks = false;


        public addValuesDnevnik(List<string> weights)
        {
            InitializeComponent();

            for (int i = 0; i < weights.Count;i++)
            {
                weightBuff.Add(weights[i]);
            }

            if (Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал")))
            {
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\marksName.json")))
                {
                    string marksName = "";

                    StreamReader openSettings = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\marksName.json"));
                    try
                    {
                        marksName = openSettings.ReadLine();
                    }
                    catch { }
                    finally
                    {
                        openSettings.Close();
                    }

                    //string weightsText = JsonConvert.SerializeObject(marksName);

                    weightsMarksData = JsonConvert.DeserializeObject<weights>(marksName);

                    //MessageBox.Show($"{settingsValues[0]}\n{settingsValues[1]}\n{settingsValues[2]}\n{settingsValues[3]}\n{settingsValues[4]}\n{settingsValues[5]}\n{settingsValues[6]}\n{settingsValues[7]}\n{settingsValues[8]}\n{settingsValues[9]}\n{settingsValues[10]}\n{settingsValues[11]}\n{settingsValues[12]}\n{settingsValues[13]}\n{settingsValues[14]}\n{settingsValues[15]}");

            
                }
                else
                {
                    string[] namesMarks = new string[25] { "Ответ на уроке", "Работа на уроке", "Диктант", "Работа с контурными картами", "Самостоятельная работа", "Контрольное списывание", "Словарный диктант", "Проверочная работа", "Аудирование", "Сочинение", "Изложение", "Практическая работа", "Лабораторная работа", "Творческая работа", "Контрольная", "Административная контрольная работа", "Итоговая контрольная работа", "Контрольный диктант", "Итоговый контрольный диктант", "Тест", "Зачет", "Государственная итоговая аттестация", "Входная контрольная работа", "Входной контрольный диктант", "Работа над ошибками" };
                    int[] weigthMarks = new int[25] { 6,6,7,7,7,7,7,7,8,8,8,9,9,9,10,10,10,10,10,10,10,10,10,10,10};

                    StreamWriter saveSettings = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\marksName.json"));
                    try
                    {
                        weights myCollection = new weights();
                        myCollection.weightsMarks = new weightsMarks[25];

                        for (int i = 0; i < 25; i++)
                        {
                            myCollection.weightsMarks[i] = new weightsMarks()
                            {
                                name = namesMarks[i],
                                weight = weigthMarks[i]
                            };
                        }

                        weightsMarksData = myCollection;

                        saveSettings.Write(JsonConvert.SerializeObject(myCollection)); //Formatting.Indented 
                    }
                    catch { }
                    finally
                    {
                        saveSettings.Close();
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал"));
            }



            //вставка весов и названий работ
            if (weights.Count > 0)
            {
                List<string> names = new List<string> { weights[0] };

                for (int i = 0; i < weights.Count; i++)
                {
                    for (int j = 0; j < names.Count; j++)
                    {
                        if (weights[i] == names[j])
                        {
                            for (int k = 0; k < weights.Count; k++)
                            {
                                if (weights[k] == names[j])
                                {
                                    weights.RemoveAt(k);
                                    k = -1;
                                }
                            }

                            i = -1;
                        }
                        else
                        {
                            bool match = false;
                            for (int k = 0; k < weights.Count; k++)
                            {
                                for (int f = 0; f < names.Count; f++)
                                {
                                    if (weights[k] == names[f]) match = true;
                                }
                            }

                            if (!match) names.Add(weights[i]);
                        }
                    }
                }

                dataGridView1.Rows.Clear();

                for (int i = 0; i < names.Count; i ++)
                {
                    dataGridView1.Rows.Add();
                }

                for (int i = 0; i < names.Count; i++)
                {
                    dataGridView1[0, i].Value = names[i];

                    for (int k = 0; k < weightsMarksData.weightsMarks.Length; k++)
                    {
                        if (weightsMarksData.weightsMarks[k].name == names[i])
                        {
                            dataGridView1[1, i].Value = (dataGridView1.Columns[1] as DataGridViewComboBoxColumn).Items[weightsMarksData.weightsMarks[k].weight-1];
                            break;
                        }
                    }
                }

                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1[1,i].Value == null)
                    {
                        notFoundNames.Add(dataGridView1[0, i].Value.ToString());
                    }
                }

                Width = dataGridView1[0,0].Size.Width + dataGridView1[1, 0].Size.Width + 40;
            }
        }

        List<string> notFoundNames = new List<string>();
        List<string> notFoundWeights = new List<string>();

        class weights
        {
            public weightsMarks[] weightsMarks { get; set; }
        }

        class weightsMarks
        {
            public string name { get; set; }
            public int weight { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveWeigths();
        }

        private void saveWeigths()
        {
            bool truePos = true;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[1, i].Value == null)
                {
                    truePos = false;
                }
            }

            if (truePos)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1[0, i].Value != null)
                        namesMarks.Add(dataGridView1[0, i].Value.ToString());

                    if (dataGridView1[1, i].Value != null)
                        weightMarks.Add(dataGridView1[1, i].Value.ToString());
                }

                StreamWriter saveSettings = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Электронный журнал\\marksName.json"));
                try
                {
                    weights myCollection = new weights();
                    myCollection.weightsMarks = new weightsMarks[weightsMarksData.weightsMarks.Length + notFoundNames.Count];

                    int count = 0;

                    for (int i = 0; i < weightsMarksData.weightsMarks.Length; i++)
                    {
                        for (int j = 0; j < weightMarks.Count; j++)
                        {
                            if (weightsMarksData.weightsMarks[i].name == namesMarks[j] && weightsMarksData.weightsMarks[i].weight != Convert.ToInt16(this.weightMarks[j]))
                            {
                                weightsMarksData.weightsMarks[i].weight = Convert.ToInt16(this.weightMarks[j]);
                            }
                        }

                        for (int k = 0; k < weightBuff.Count; k++)
                        {
                            for (int j = 0; j < weightsMarksData.weightsMarks.Length; j++)
                            {
                                if (weightBuff[k] == weightsMarksData.weightsMarks[j].name)
                                {
                                    this.weightBuff[k] = weightsMarksData.weightsMarks[j].weight.ToString();
                                    break;
                                }
                            }
                        }


                        myCollection.weightsMarks[i] = new weightsMarks()
                        {
                            name = weightsMarksData.weightsMarks[i].name,
                            weight = weightsMarksData.weightsMarks[i].weight
                        };

                        count++;
                    }

                    int countAddMarks = 0;

                    for (int i = 0; i < notFoundNames.Count; i++)
                    {
                        for (int j = 0; j < namesMarks.Count; j++)
                        {
                            if (notFoundNames[i] == namesMarks[j])
                            {
                                notFoundWeights.Add(weightMarks[j]);
                            }
                        }

                        myCollection.weightsMarks[count] = new weightsMarks()
                        {
                            name = notFoundNames[countAddMarks],
                            weight = Convert.ToInt16(notFoundWeights[countAddMarks])
                        };

                        countAddMarks++;
                        count++;
                    }

                    for (int i = 0; i < weightBuff.Count; i++)
                    {
                        for (int j = 0; j < myCollection.weightsMarks.Length; j++)
                        {
                            if (weightBuff[i] == myCollection.weightsMarks[j].name)
                            {
                                weightBuff[i] = myCollection.weightsMarks[j].weight.ToString();
                            }

                        }
                    }

                    saveSettings.Write(JsonConvert.SerializeObject(myCollection)); //Formatting.Indented 
                }
                catch { }
                finally
                {
                    saveSettings.Close();
                }

                saveMarks = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Проверьте правильность заполнения весов работ!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void addValuesDnevnik_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saveMarks) 
                insertMarks = false;

            //saveWeigths();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int val;

                try
                {
                    val = Convert.ToInt16(dataGridView1[1, i].Value);

                    
                }
                catch {
                    dataGridView1[1, i].Value = null;
                }
            }
        }
    }
}
