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
    public partial class Form2 : MaterialForm

    {
        public Form2()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

        }


        SqlConnection con;
        SqlCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-EHO63KS;Initial Catalog=food_order;Integrated Security=True");
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            if(txt_Fname.Text != "" & txt_Lname.Text != "" & txt_email.Text != "" && txt_contactNo.Text != "" && txt_addressLine1.Text != ""&& txt_addressLine2.Text != "" && txt_addressLine3.Text != "" && txt_password.Text != "" && txt_confirmPwd.Text!= "")
            {
                if (materialCheckBox1.Checked == true && txt_password.Text == txt_confirmPwd.Text)
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("Insert into client values ('" + txt_Fname.Text + "','" + txt_Lname.Text + "','" + txt_email.Text + "','" + txt_contactNo.Text + "','" + txt_addressLine1.Text + "','" + txt_addressLine2.Text + "','" + txt_addressLine3.Text + "','" + txt_password.Text + "')", con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_Fname.Clear(); txt_Lname.Clear(); txt_email.Clear(); txt_contactNo.Clear(); txt_addressLine1.Clear(); txt_addressLine2.Clear(); txt_addressLine3.Clear(); txt_password.Clear(); txt_confirmPwd.Clear();

                        }
                        else
                        {
                            MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         
                        }
                        con.Close();
                        cmd.Dispose();
                    }
                    catch(SqlException)
                    {
                        MessageBox.Show(this, "Please check again", "Error#1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(this, "Please check again", "Error#2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Check the form and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                

        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
        }
    }
    
}
