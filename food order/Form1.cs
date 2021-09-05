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


namespace food_order
{
    public partial class Form1 : MaterialForm
    {
        public static string passmail;
        public Form1()
        {
            InitializeComponent();
            LoadUsernamePassword();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }
        SqlConnection con;
        SqlCommand cmd;
        private void Label_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
               
                if (txt_username.Text == "admin" && txt_password.Text == "password")
                {
                    this.Hide();
                    Form4 fm4 = new Form4();
                    fm4.ShowDialog();

                }
                else
                {
                    SqlCommand cmd = new SqlCommand("select * from client where Eamil like @username and Password = @password;");
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Connection = con;
                    con.Open();
                    SaveUsernamePassword();
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                    con.Close();
                    passmail = txt_username.Text;

                    bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                    if (loginSuccessful)
                    {

                        this.Hide();
                        Form3 frm3 = new Form3();
                        frm3.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show(this, "Username or Password is Incorrect! Please try again", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
                    }
                }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EHO63KS;Initial Catalog=food_order;Integrated Security=True");
            LoadUsernamePassword();
        }

       public void SaveUsernamePassword()
        {
            if(check_remember.Checked==true)
            {
                Properties.Settings.Default.Username = txt_username.Text;
                Properties.Settings.Default.Password = txt_password.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }
      public  void LoadUsernamePassword()
        {
            if(Properties.Settings.Default.Username !=string.Empty)
            {
                txt_username.Text = Properties.Settings.Default.Username;
                txt_password.Text = Properties.Settings.Default.Password;
                check_remember.Checked = true;
            }

        }

        private void Check_showhide_CheckedChanged(object sender, EventArgs e)
        {
            if(check_showhide.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_password_Click(object sender, EventArgs e)
        {

        }

        private void Label_forgot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();

        }

        private void Check_remember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

        
    
}
