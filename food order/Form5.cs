using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;



namespace food_order
{
    public partial class Form5 : MaterialForm
    {
       
        public static string to;
        public static string passingMail;
        public Form5()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
         

        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
           


            try
            {
                SmtpClient client = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = "mpabasara11@gmail.com",
                        Password = "zikhmtzksfoojcre"
                    }
                };
                String htmlbody = "<h1>Your Verification Code is</h1>" + "<p> 1123 </p>";
                MailAddress fromEmail = new MailAddress("mpabasara11@gmail.com", "malindu");
                MailAddress toEmail = new MailAddress(txt_email.Text, "Client");
                MailMessage message = new MailMessage()
                {

                    From = fromEmail,
                    Subject ="Verification Code",
                    Body = htmlbody

                };
                message.IsBodyHtml = true;
                message.To.Add(toEmail);
                client.SendCompleted += Client_SendCompleted;
                client.SendMailAsync(message);
                passingMail = txt_email.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email not send", ex.Message);
            }
        }
        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Some Error. Please Check Again \n" + e.Error.Message, "Error");
                return;
            }
            MessageBox.Show("Sent Successfully", "Done");
        }

        private void Btn_verify_Click(object sender, EventArgs e)
        {
            if(txt_code.Text==1123.ToString())
            {
                to = txt_email.Text;
                Form6 frm6 = new Form6();
                this.Hide();
                frm6.Show();
                
            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }
    }
}
