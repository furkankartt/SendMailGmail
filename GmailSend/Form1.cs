using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GmailSend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            textBoxKime.Text = "";
            textBoxBilgi.Text = "";
            textBoxKonu.Text = "";
            textBoxIcerik.Text = "";
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;

            smtpClient.Credentials = new NetworkCredential("denemesurumu379@gmail.com", "***");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("denemesurumu379@gmail.com", "frknkrt");

            if(textBoxKime.Text!="" && textBoxKonu.Text != "" && textBoxIcerik.Text != "")
            {
                if(textBoxBilgi.Text != "")
                {
                    mail.To.Add(textBoxKime.Text);

                    mail.CC.Add(textBoxBilgi.Text);

                    mail.Subject = textBoxKonu.Text;
                    mail.IsBodyHtml = true;
                    mail.Body = textBoxIcerik.Text;

                    mail.Attachments.Add(new Attachment(@"C:\Users\220\Desktop\Mail\Rapor.xlsx"));
                    mail.Attachments.Add(new Attachment(@"C:\Users\220\Desktop\Mail\Sonuc.pptx"));

                    smtpClient.Send(mail);

                    Temizle();
                    MessageBox.Show("Mailiniz başarılı bir şekilde gönderilmiştir.");
                }
                else
                {
                    mail.To.Add(textBoxKime.Text);
                    mail.Subject = textBoxKonu.Text;
                    mail.IsBodyHtml = true;
                    mail.Body = textBoxIcerik.Text;

                    mail.Attachments.Add(new Attachment(@"C:\Users\220\Desktop\Mail\Rapor.xlsx"));
                    mail.Attachments.Add(new Attachment(@"C:\Users\220\Desktop\Mail\Sonuc.pptx"));

                    smtpClient.Send(mail);

                    Temizle();
                    MessageBox.Show("Mailiniz başarılı bir şekilde gönderilmiştir.");
                }
            }
            else
            {
                MessageBox.Show("'*' olan yerleri boş geçemezsiniz.");
            }
        }
    }
}
