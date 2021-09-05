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
    public partial class Form4 : MaterialForm
    {
        public static string passingtext1;
        public static string passingtext2;
        public static string passingtext3;
        public static string passingtext4;
        public static string passingtext5;
        public static string passingtext6;
        public static string passingtext7;
        public static string passingtext8;
        public static string passingtext9;
        public static string passingtext10;
        public static string passingtext11;
        public static string passingtext12;
        public Form4()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }
        SqlConnection con;
        SqlDataAdapter adp;
        SqlCommand com;
        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EHO63KS;Initial Catalog=food_order;Integrated Security=True");
        }

        private void Txt_dispaly_Click(object sender, EventArgs e)
        {
            con.Open();
            adp = new SqlDataAdapter("select * from client",con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new SqlCommand("delete from client where Eamil='" + materialSingleLineTextField13.Text + "'", con);
            int i = com.ExecuteNonQuery();
            if (i == 1)
            { MessageBox.Show(this, "Record Cleared Succesfuly", "Successed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                con.Close();
                com.Dispose();
            }
            else
            {
                MessageBox.Show(this, "Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Btn_updateneapolitan_Click(object sender, EventArgs e)
        {
            passingtext1 = txt_neapolitan.Text;
        

        }

        private void Btn_updatepepperoni_Click(object sender, EventArgs e)
        {
            passingtext2 = materialSingleLineTextField1.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatehawaiian_Click(object sender, EventArgs e)
        {
            passingtext3 = materialSingleLineTextField2.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updateseafood_Click(object sender, EventArgs e)
        {
            passingtext4 = materialSingleLineTextField3.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatemexican_Click(object sender, EventArgs e)
        {
            passingtext5 = materialSingleLineTextField4.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatemushroom_Click(object sender, EventArgs e)
        {
            passingtext6 = materialSingleLineTextField6.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatecocacola_Click(object sender, EventArgs e)
        {
            passingtext7 = materialSingleLineTextField10.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatepepsi_Click(object sender, EventArgs e)
        {
            passingtext8 = materialSingleLineTextField8.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatemoster_Click(object sender, EventArgs e)
        {
            passingtext9 = materialSingleLineTextField7.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updatesprite_Click(object sender, EventArgs e)
        {
            passingtext10 = materialSingleLineTextField9.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updateredbull_Click(object sender, EventArgs e)
        {
            passingtext11 = materialSingleLineTextField11.Text;
            Form3 frm3 = new Form3();
        }

        private void Btn_updaterockstar_Click(object sender, EventArgs e)
        {
            passingtext12 = materialSingleLineTextField12.Text;
            Form3 frm3 = new Form3();
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {//if (txt_neapolitan.Text == null)
           // {
               
            //}

            //else
            //{
                passingtext1 = txt_neapolitan.Text;
                passingtext2 = materialSingleLineTextField1.Text;
                passingtext3 = materialSingleLineTextField2.Text;
                passingtext4 = materialSingleLineTextField3.Text;
                passingtext5 = materialSingleLineTextField4.Text;
                passingtext6 = materialSingleLineTextField6.Text;

                passingtext7 = materialSingleLineTextField10.Text;
                passingtext8 = materialSingleLineTextField8.Text;
                passingtext9 = materialSingleLineTextField7.Text;
                passingtext10 = materialSingleLineTextField9.Text;
                passingtext11 = materialSingleLineTextField11.Text;
                passingtext12 = materialSingleLineTextField12.Text;
            //}


            MessageBox.Show(this, "Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);





        }
    }
}
