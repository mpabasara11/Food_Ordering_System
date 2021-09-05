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
    public partial class Form6 : MaterialForm
    {
        public Form6()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        SqlConnection con;
        SqlCommand cmd;

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
           
            

            con.Open();
            Form4 frm4 = new Form4();
            cmd = new SqlCommand("update client set Password='" + txt_newpw.Text+ "'where Eamil='"+ materialLabel1.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show(this, "password updated successfuly");
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
                con.Close();
            }
            else
            {
                MessageBox.Show(this, "password not updated");
            }
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EHO63KS;Initial Catalog=food_order;Integrated Security=True");
            materialLabel1.Text = Form5.passingMail;
        }
    }
}
