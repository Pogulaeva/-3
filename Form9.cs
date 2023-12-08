using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace IS_FISU
{
    public partial class CommentForDeletingWindow : Form
    {
        public CommentForDeletingWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите отправить сообщение?", "", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {

                AMessageToClient();
                this.Hide();
                var myForm = new ChooseOrderListWindow();
                myForm.Show();
            }
        }
        private void AMessageToClient()
        {
            try
            {
                SmtpClient mySmptpClient = new SmtpClient("smtp.mail.ru")
                {
                    UseDefaultCredentials = true,
                    EnableSsl = true
                };

                System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("dudkin.alesha@internet.ru", "9Sd75uki21AhbgGkGzjn");
                mySmptpClient.Credentials = basicAuthenticationInfo;

                MailAddress from = new MailAddress("dudkin.alesha@internet.ru", "Интернет-Магазин");
                MailAddress to = new MailAddress("dudkin.alesha@internet.ru", "Клиенту");
                MailMessage myMail = new MailMessage(from, to)
                {
                    Subject = "Отменённый заказ",
                    SubjectEncoding = System.Text.Encoding.UTF8,

                    Body = CommentBox.Text,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    IsBodyHtml = false
                };
                mySmptpClient.Send(myMail);

            }
            catch (SmtpException ex)
            {
                throw new ApplicationException("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
