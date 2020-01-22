using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using DotNetBrowser;
using DotNetBrowser.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class dnevnikWebBrowser : Form
    {

        private readonly BrowserView browserView;
        public dnevnikWebBrowser()
        {
            InitializeComponent();

            DotNetBrowser.Helper.irDeveloper.ModifyInMemory.ActivateMemoryPatching();

            //Browser browser = BrowserFactory.Create();

            //// Load "http://www.google.com" URL
            //browser.LoadURL("http://www.google.com");

            //// Dispose Browser instance.
            //browser.Dispose();

            //DotNetBrowser.BrowserFactory.Create();

            dnevnikWeb.URL = "https://login.dnevnik.ru/login/";

            dnevnikWeb.Browser.ZoomEnabled = true;
        }

        public List<string> marks = new List<string>();
        public List<string> weights = new List<string>();
        public List<string> names = new List<string>();
        public bool insertMarks = false;

        private void copyMarks_Click(object sender, EventArgs e)
        {
            marks.Clear();
            weights.Clear();
            names.Clear();

            string html = dnevnikWeb.Browser.GetHTML();

            var parser = new HtmlParser();
            var document = parser.ParseDocument(html);

            if (dnevnikWeb.URL.ToString().Contains("tab=period"))
            {
                string marksText;

                foreach (IElement element in document.QuerySelectorAll("td[style].tac"))
                {
                    marksText = element.Text().Replace("Н", string.Empty);

                    string resultString = "";

                    for (int g = 0; g < marksText.Length; g++)
                    {
                        string stringText = marksText[g].ToString();

                        if (stringText == "2" || stringText == "3" || stringText == "4" || stringText == "5") resultString += stringText;
                    }

                    marks.Add(resultString);
                }

                foreach (IElement element in document.QuerySelectorAll("span[title]"))
                {
                    if (element.GetAttribute("class") != "mark lsR")
                        weights.Add(element.GetAttribute("title").Substring(0, element.GetAttribute("title").IndexOf(',')));
                    //listBox3.Items.Add(element.GetAttribute("title").Substring(0, element.GetAttribute("title").IndexOf(',')));
                }

                foreach (IElement element in document.QuerySelectorAll(".s2"))
                {
                    names.Add(element.Text());
                    //listBox2.Items.Add(element.Text());
                }

                if (names.Count != 0 && weights.Count != 0 && marks.Count != 0)
                {
                    addValuesDnevnik frm = new addValuesDnevnik(weights);

                    frm.ShowDialog();


                    if (frm.weightBuff.Count != 0)
                    {
                        for (int i = 0; i < frm.weightBuff.Count; i++)
                        {
                            weights.Add(frm.weightBuff[i]);
                        }

                        insertMarks = frm.insertMarks;

                        if (frm.insertMarks)
                            this.Close();
                    }
                    else
                    {
                        weights.Clear();
                        marks.Clear();
                        names.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Невозможно скопировать оценки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Невозможно скопировать оценки!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openSite_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("https://login.dnevnik.ru/login/");
            dnevnikWeb.URL = "https://login.dnevnik.ru/login/";
            this.Text = dnevnikWeb.URL.ToString();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            dnevnikWeb.Browser.GoBack();
        }

        private void upPage_Click(object sender, EventArgs e)
        {
            dnevnikWeb.Browser.GoForward();
        }

        private void updatePage_Click(object sender, EventArgs e)
        {
            dnevnikWeb.Browser.Reload();
        }

        private void scaleValueChanged(object sender, EventArgs e)
        {
            float scaleZoom = Convert.ToInt32(scaleItemsValue.Text.Replace("%", ""));

            if (scaleZoom < 100)
            {
                scaleZoom = (scaleZoom - 100);
            }

            dnevnikWeb.Browser.ZoomLevel = scaleZoom / 100;
        }

        private void dnevnikWebBrowser_Shown(object sender, EventArgs e)
        {
            
        }

        private void dnevnikWebBrowser_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (dnevnikWeb != null)
            {
                dnevnikWeb.Dispose();
                dnevnikWeb.Browser.Dispose();
            }
        }
    }
}
