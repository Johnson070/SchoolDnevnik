using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class dnevnikWebBrowser : Form
    {
        public dnevnikWebBrowser()
        {
            InitializeComponent();

            webBrowser1.ScriptErrorsSuppressed = true;

            webBrowser1.Navigate("https://login.dnevnik.ru/login/");

            SetWebBrowserCompatiblityLevel();
        }

        private static void SetWebBrowserCompatiblityLevel()
        {
            string appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            int lvl = 1000 * GetBrowserVersion();
            bool fixVShost = File.Exists(Path.ChangeExtension(Application.ExecutablePath, ".vshost.exe"));

            WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".exe", lvl);
            if (fixVShost) WriteCompatiblityLevel("HKEY_LOCAL_MACHINE", appName + ".vshost.exe", lvl);

            WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".exe", lvl);
            if (fixVShost) WriteCompatiblityLevel("HKEY_CURRENT_USER", appName + ".vshost.exe", lvl);
        }

        private static void WriteCompatiblityLevel(string root, string appName, int lvl)
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(root + @"\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", appName, lvl);
            }
            catch (Exception)
            {
            }
        }

        public static int GetBrowserVersion()
        {
            string strKeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer";
            string[] ls = new string[] { "svcVersion", "svcUpdateVersion", "Version", "W2kVersion" };

            int maxVer = 0;
            for (int i = 0; i < ls.Length; ++i)
            {
                object objVal = Microsoft.Win32.Registry.GetValue(strKeyPath, ls[i], "0");
                string strVal = Convert.ToString(objVal);
                if (strVal != null)
                {
                    int iPos = strVal.IndexOf('.');
                    if (iPos > 0)
                        strVal = strVal.Substring(0, iPos);

                    int res = 0;
                    if (int.TryParse(strVal, out res))
                        maxVer = Math.Max(maxVer, res);
                }
            }

            return maxVer;
        }

        public List<string> marks = new List<string>();
        public List<string> weights = new List<string>();
        public List<string> names = new List<string>();
        public bool insertMarks = true;

        private void copyMarks_Click(object sender, EventArgs e)
        {
            marks.Clear();
            weights.Clear();
            names.Clear();

            string html = webBrowser1.DocumentText;

            var parser = new HtmlParser();
            var document = parser.ParseDocument(html);

            if (webBrowser1.Url.ToString().Contains("tab=period"))
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
            webBrowser1.Navigate("https://login.dnevnik.ru/login/");
            this.Text = webBrowser1.Url.ToString();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void upPage_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void updatePage_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void clearCookies_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.Text = webBrowser1.Url.ToString();
        }
    }
}
