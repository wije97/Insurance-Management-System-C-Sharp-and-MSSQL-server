using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Insurance_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT username, password  FROM dbo.[Agent]" + " WHERE  username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "';", con);

                    SqlDataReader reader = cmd1.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        reader.Close();

                        SqlCommand cmd2 = new SqlCommand("SELECT username, password  FROM dbo.[Admin]" + " WHERE  username='" + txtUsername.Text + "' AND password='" + txtPassword.Text + "';", con);

                        SqlDataReader reader2 = cmd2.ExecuteReader();

                        if (reader2.Read() == true)
                        {

                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();

                            reader2.Close();
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            txtUsername.ResetText();
                            txtPassword.ResetText();

                            reader2.Close();
                            con.Close();
                        }
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.ResetText();
                txtPassword.ResetText();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }
    }
}
