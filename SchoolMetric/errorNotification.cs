using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMetric
{
    public partial class errorNotification : Form
    {
        public errorNotification()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...")
            {
                textBox2.ForeColor = Color.Black;
                textBox2.Text = "";
            }

            try
            {
                MailAddress from = new MailAddress("metricschool.report@gmail.com");
                MailAddress to = new MailAddress("v.veber@me.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = textBox1.Text;
                m.IsBodyHtml = false;
                m.Body = textBox2.Text + "\n\n\n\nАдрес для ответа:   " + textBox3.Text;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("metricschool.report@gmail.com", "0SUeCVmzsIv*kwgj&pGJ6J&7GH!6ivHRc457"),
                    EnableSsl = true
                };

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    Attachment attach = new Attachment(comboBox1.Items[i].ToString(), MediaTypeNames.Application.Octet);
                    m.Attachments.Add(attach);
                }

                smtp.Send(m);
                MessageBox.Show("Письмо успешно отправлено. Спасибо!");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");
                textBox1.Text = "";
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Строка с адресом не должна быть пуста");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.HelpLink);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count < 10) {
                OpenFileDialog openFile = new OpenFileDialog();

                openFile.Filter = "png Файл (*.png)|*.png|jpg Файл (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
                openFile.RestoreDirectory = true;
                openFile.RestoreDirectory = true;
                openFile.Multiselect = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFile.FileNames.Length; i++)
                    {
                        comboBox1.Items.Add(openFile.FileNames[i]);
                    }

                    comboBox1.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Максимальное количество прикреплённых вложений 10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
                comboBox1.Text = "";
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
    }
}
