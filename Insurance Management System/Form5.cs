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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCustomerBack_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text=="" || txtCustomerName.Text=="" || txtCustomerNIC.Text =="" || txtCustomerAddress.Text=="" || txtCustomerMobile.Text=="" || txtCustomerReligion.Text=="" || txtCustomerNationality.Text=="")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO  dbo.[User](NIC, name_with_initials, address, gender) " + " VALUES ('" + txtCustomerNIC.Text + "','" + txtCustomerName.Text + "','" + txtCustomerAddress.Text + "','" + cmbCustomerGender.Text + "')", con);
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO  dbo.[Customer](customerID,NIC, DOB, religion, nationality) " + " VALUES ('" + txtCustomerID.Text + "','" + txtCustomerNIC.Text + "','" + dtpCustomerDOB.Text + "','" + txtCustomerReligion.Text + "','" + txtCustomerNationality.Text + "')", con);
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO  dbo.[userMobile](NIC, mobile) " + " VALUES ('" + txtCustomerNIC.Text + "','" + txtCustomerMobile.Text +  "')", con);

                    int i = cmd1.ExecuteNonQuery();
                    int j = cmd2.ExecuteNonQuery();
                    int m = cmd3.ExecuteNonQuery();
                    if (i != 0 && j != 0 && m!=0)
                    {
                        Form6 form6 = new Form6();
                        form6.txtAddPolicyCID.Text = txtCustomerID.Text;
                        form6.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Data not Saved");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }
    }
}
