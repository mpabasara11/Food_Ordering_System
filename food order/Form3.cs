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
using System.Net;
using System.Net.Mail;



namespace food_order
{

    public partial class Form3 : MaterialForm
    {
        public static string to;
        public static string passingMail;


        public Form3()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }


        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Tab_controller_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Panel15_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Panel17_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel14_Paint(object sender, PaintEventArgs e)
        {

        }



        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Panel16_Paint(object sender, PaintEventArgs e)
        {

        }


        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_addcart_Click(object sender, EventArgs e)
        {
            if (check_neapolitan.Checked == true)
            {
                labl_neapolitan.Enabled = true;
                lbl_neapolitan.Enabled = true;

                int n1 = Convert.ToInt16(numeric_neapolitan.Value);
                int l1 = Convert.ToInt16(label_pizzaneapolitan.Text);
                int t1 = l1 * n1;
                lbl_neapolitan.Text = t1.ToString();
            }
            else
            {
                labl_neapolitan.Enabled = false;
                lbl_neapolitan.Enabled = false;

            }


            if (check_pepperoni.Checked == true)
            {
                labl_pepperoni.Enabled = true;
                lbl_pepperoni.Enabled = true;
                int n2 = Convert.ToInt16(numeric_pepperoni.Value);
                int l2 = Convert.ToInt16(label_pizzapepperoni.Text);
                int t2 = l2 * n2;
                lbl_pepperoni.Text = t2.ToString();
            }
            else
            {
                labl_pepperoni.Enabled = false;
                lbl_pepperoni.Enabled = false;
            }


            if (check_hawaiian.Checked == true)
            {
                labl_hawaiian.Enabled = true;
                lbl_hawaiian.Enabled = true;
                int n3 = Convert.ToInt16(numeric_hawaiian.Value);
                int l3 = Convert.ToInt16(label_pizzahawaiin.Text);
                int t3 = l3 * n3;
                lbl_hawaiian.Text = t3.ToString();
            }
            else
            {
                labl_hawaiian.Enabled = false;
                lbl_hawaiian.Enabled = false;
            }


            if (check_seafood.Checked == true)
            {
                labl_seafood.Enabled = true;
                lbl_seafood.Enabled = true;
                int n4 = Convert.ToInt16(numeric_seafood.Value);
                int l4 = Convert.ToInt16(label_pizzaseafood.Text);
                int t4 = l4 * n4;
                lbl_seafood.Text = t4.ToString();
            }
            else
            {
                labl_seafood.Enabled = false;
                lbl_seafood.Enabled = false;
            }


            if (check_mexican.Checked == true)
            {
                labl_mexican.Enabled = true;
                lbl_mexican.Enabled = true;
                int n5 = Convert.ToInt16(numeric_mexican.Value);
                int l5 = Convert.ToInt16(label_pizzamexican.Text);
                int t5 = l5 * n5;
                lbl_mexican.Text = t5.ToString();
            }
            else
            {
                labl_mexican.Enabled = false;
                lbl_mexican.Enabled = false;
            }



            if (check_mushroom.Checked == true)
            {
                labl_mushroom.Enabled = true;
                lbl_mushroom.Enabled = true;
                int n6 = Convert.ToInt16(numeric_mushroom.Value);
                int l6 = Convert.ToInt16(label_pizzamushroom.Text);
                int t6 = l6 * n6;
                lbl_mushroom.Text = t6.ToString();
            }
            else
            {
                labl_mushroom.Enabled = false;
                lbl_mushroom.Enabled = false;
            }

            MessageBox.Show(this, "Successfully Add to Your Cart", "information", MessageBoxButtons.OK, MessageBoxIcon.None);
            check_neapolitan.Checked = false;
            check_pepperoni.Checked = false;
            check_hawaiian.Checked = false;
            check_mexican.Checked = false;
            check_mushroom.Checked = false;
            check_seafood.Checked = false;

          
        }


        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Tab_pizza_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            materialLabel11.Text = Form1.passmail;
         
        }

        private void Label_pizzaneapolitan_Click(object sender, EventArgs e)
        {

        }


        private void Btn_addcartdrink_Click(object sender, EventArgs e)
        {
            try
            {

                if (check_cocacola.Checked == true)
                {
                    labl_Cocacola.Enabled = true;
                    lbl_cocacola.Enabled = true;
                    int n7 = Convert.ToInt16(numeric_cocacola.Value);
                    int l7 = Convert.ToInt16(label_cocoacola.Text);
                    int t7 = l7 * n7;
                    lbl_cocacola.Text = t7.ToString();
                }
                else
                {
                    labl_Cocacola.Enabled = false;
                    lbl_cocacola.Enabled = false;
                }

                if (check_pepsi.Checked == true)
                {
                    labl_Pepsi.Enabled = true;
                    lbl_pepsi.Enabled = true;
                    int n8 = Convert.ToInt16(numeric_pepsi.Value);
                    int l8 = Convert.ToInt16(label_pepsi.Text);
                    int t8 = l8 * n8;
                    lbl_pepsi.Text = t8.ToString();

                }
                else
                {
                    labl_Pepsi.Enabled = false;
                    lbl_pepsi.Enabled = false;
                }

                if (check_monster.Checked == true)
                {
                    labl_Monster.Enabled = true;
                    lbl_monster.Enabled = true;
                    int n9 = Convert.ToInt16(numeric_monster.Value);
                    int l9 = Convert.ToInt16(label_monster.Text);
                    int t9 = l9 * n9;
                    lbl_monster.Text = t9.ToString();
                }
                else
                {
                    labl_Monster.Enabled = false;
                    lbl_monster.Enabled = false;
                }

                if (check_sprite.Checked == true)
                {
                    labl_sprite.Enabled = true;
                    lbl_sprite.Enabled = true;
                    int n10 = Convert.ToInt16(numeric_sprite.Value);
                    int l10 = Convert.ToInt16(label_sprite.Text);
                    int t10 = l10 * n10;
                    lbl_sprite.Text = t10.ToString();
                }
                else
                {
                    labl_sprite.Enabled = false;
                    lbl_sprite.Enabled = false;
                }

                if (check_redbull.Checked == true)
                {
                    labl_redbull.Enabled = true;
                    lbl_redbull.Enabled = true;
                    int n11 = Convert.ToInt16(numeric_redbull.Value);
                    int l11 = Convert.ToInt16(label_redbull.Text);
                    int t11 = l11 * n11;
                    lbl_redbull.Text = t11.ToString();
                }
                else
                {
                    labl_redbull.Enabled = false;
                    lbl_redbull.Enabled = false;
                }

                if (check_rockstar.Checked == true)
                {
                    labl_rockstar.Enabled = true;
                    lbl_rockstar.Enabled = true;
                    int n12 = Convert.ToInt16(numeric_rockstar.Value);
                    int l12 = Convert.ToInt16(label_rockstar.Text);
                    int t12 = l12 * n12;
                    lbl_rockstar.Text = t12.ToString();
                }
                else
                {
                    labl_rockstar.Enabled = false;
                    lbl_rockstar.Enabled = false;
                }

                MessageBox.Show(this, "Successfully Add to Cart", "information", MessageBoxButtons.OK, MessageBoxIcon.None);
                check_sprite.Checked = false;
                check_cocacola.Checked = false;
                check_pepsi.Checked = false;
                check_redbull.Checked = false;
                check_rockstar.Checked = false;
                check_monster.Checked = false;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tab_mycart_Click(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            label_pizzaneapolitan.Text = Form4.passingtext1;
            label_pizzapepperoni.Text = Form4.passingtext2;
            label_pizzahawaiin.Text = Form4.passingtext3;
            label_pizzaseafood.Text = Form4.passingtext4;
            label_pizzamexican.Text = Form4.passingtext5;
            label_pizzamushroom.Text = Form4.passingtext6;

            label_cocoacola.Text = Form4.passingtext7;
            label_pepsi.Text = Form4.passingtext8;
            label_monster.Text = Form4.passingtext9;
            label_sprite.Text = Form4.passingtext10;
            label_redbull.Text = Form4.passingtext11;
            label_rockstar.Text = Form4.passingtext12;
        }

        private void Btn_buy_Click(object sender, EventArgs e)
        {
            string Cname = "<h1>Customer -" + materialLabel11.Text + "</h1>";
            string orderP = "<h3>Pizza Neapolitan ="+numeric_neapolitan.Value+"</h3>"+"</br>"+ "<h3>Pizza Pepperoni =" + numeric_pepperoni.Value + "</h3>"+"</br>"+"<h3>Pizza Hawaiian =" +numeric_hawaiian.Value+"</h3>"+"</br>"+"<h3>Pizza Seafood ="+numeric_seafood.Value+"</h3>"+"</br>"+"<h3>pizza mexican ="+numeric_mexican.Value+"</h3>"+"</br>"+"<h3>pizza mushroom ="+numeric_mushroom.Value+"</h3>";
            string orderD = "<h3>Cocacola =" + numeric_cocacola.Value + "</h3>" + "</br>" + "<h3>Pepsi =" + numeric_pepsi.Value + "</h3>" + "</br>" + "<h3>Monster =" + numeric_monster.Value + "</h3>" + "</br>" + "<h3>Sprite ="  +numeric_sprite.Value+ "</h3>" + "</br>" + "<h3>Redbull =" + numeric_redbull.Value + "</h3>" + "</br>" + "<h3>Rockstar =" + numeric_rockstar.Value + "</h3>";

            ;

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
                String htmlbody =Cname+" "+orderP+" "+orderD;
                MailAddress fromEmail = new MailAddress(materialLabel11.Text, "Client");
                MailAddress toEmail = new MailAddress("mpabasara11@gmail.com", "Shop");
                MailMessage message = new MailMessage()
                {

                    From = fromEmail,
                    Subject = "Order",
                   Body = htmlbody

                };
                message.IsBodyHtml = true;
                message.To.Add(toEmail);
                client.SendCompleted += Client_SendCompleted;
                client.SendMailAsync(message);
                passingMail = "mpabasara11@gmail.com";
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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MaterialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_sub1_Click(object sender, EventArgs e)
        {

        }
    }
 
    
}
