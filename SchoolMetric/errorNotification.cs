using System;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
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
            if (message.Text == "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...")
            {
                message.ForeColor = Color.Black;
                message.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (message.Text == "")
            {
                message.ForeColor = Color.Gray;
                message.Text = "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (message.Text == "Постарайтесь здесь подробно описать ошибку или проблему которая возникла у Вас при работе программы. Или напишите здесь ваши пожелания и комментарии...")
            {
                message.ForeColor = Color.Black;
                message.Text = "";
            }

            try
            {
                MailAddress from = new MailAddress("metricschool.report@gmail.com");
                MailAddress to = new MailAddress("v.veber@me.com");
                MailMessage m = new MailMessage(from, to);
                m.Subject = mailHeader.Text;
                m.IsBodyHtml = false;
                m.Body = message.Text + "\n\n\n\nАдрес для ответа:   " + fromEmail.Text;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("metricschool.report@gmail.com", "0SUeCVmzsIv*kwgj&pGJ6J&7GH!6ivHRc457"),
                    EnableSsl = true
                };

                for (int i = 0; i < attachments.Items.Count; i++)
                {
                    Attachment attach = new Attachment(attachments.Items[i].ToString(), MediaTypeNames.Application.Octet);
                    m.Attachments.Add(attach);
                }

                smtp.Send(m);
                MessageBox.Show("Письмо успешно отправлено. Спасибо!");
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат электронной почты. Почта должна иметь окончания - @gmail/yandex/mail/bk/list и другие");
                mailHeader.Text = "";
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
            if (attachments.Items.Count < 10) {
                OpenFileDialog openFile = new OpenFileDialog();

                openFile.Filter = "png Файл (*.png)|*.png|jpg Файл (*.jpg)|*.jpg|Все файлы (*.*)|*.*";
                openFile.RestoreDirectory = true;
                openFile.RestoreDirectory = true;
                openFile.Multiselect = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    for (int i = 0; i < openFile.FileNames.Length; i++)
                    {
                        attachments.Items.Add(openFile.FileNames[i]);
                    }

                    attachments.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Максимальное количество прикреплённых вложений 10!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (attachments.SelectedIndex != -1)
            {
                attachments.Items.RemoveAt(attachments.SelectedIndex);
            }
        }
    }
}
