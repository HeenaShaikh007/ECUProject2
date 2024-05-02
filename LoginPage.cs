using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECUProject2
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")

            {
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=LIN59019477\\SQLEXPRESS;Initial Catalog=\"ECU Project\";Integrated Security=True;Encrypt=False");
                    SqlCommand cmd = new SqlCommand("select * from login where Email_Id = @Email_Id and Password = @Password", con);

                    cmd.Parameters.AddWithValue("@Email_Id", tbUsername.Text);

                    cmd.Parameters.AddWithValue("@Password", tbPassword.Text);


                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                     da.Fill(dt);
                    //int i = dt.Tables[0].Rows.Count;
                    if (dt.Rows.Count >0)
                    {
                        global.Email_Id = dt.Rows[0]["Email_Id"].ToString();
                        this.Hide();
                        Start start = new Start();
                        start.Show();
                             
                    }

                    
                    /*if (dt.Rows.Count > 0)

                    {

                        MessageBox.Show("Welcome to ECU", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }*/

                    else

                    {

                        MessageBox.Show("Invalid Username or Password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                }

                catch (Exception ex)

                {


                    MessageBox.Show(ex.Message);

                }

            }

            else

            {

                MessageBox.Show("Please fill both fields", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
                if (cbShowPassword.Checked == true)
                {
                    tbPassword.UseSystemPasswordChar = false;
                }
                else
                {
                    tbPassword.UseSystemPasswordChar = true;
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
    }

