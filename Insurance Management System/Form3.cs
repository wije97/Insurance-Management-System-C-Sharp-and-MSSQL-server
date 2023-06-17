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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            if(txtAgentCode.Text=="" || txtAgentName.Text=="" || txtAgentNIC.Text=="" || txtAgentAddress.Text=="" || txtAgentMobile.Text=="" || txtAgentUserName.Text=="" || txtAgentPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO  dbo.[User](NIC, name_with_initials, address, gender) " + " VALUES ('" + txtAgentNIC.Text + "','" + txtAgentName.Text + "','" + txtAgentAddress.Text + "','" + cmbAgentGender.Text +"')",con);
                SqlCommand cmd2 = new SqlCommand("INSERT INTO  dbo.[Agent](agentCode,NIC, username, password) " + " VALUES ('" + txtAgentCode.Text + "','" + txtAgentNIC.Text + "','" + txtAgentUserName.Text + "','" + txtAgentPassword.Text + "')", con);
                SqlCommand cmd3 = new SqlCommand("INSERT INTO  dbo.[userMobile](NIC, mobile) " + " VALUES ('" + txtAgentNIC.Text + "','" + txtAgentMobile.Text + "')", con);

                int i = cmd1.ExecuteNonQuery();
                int j = cmd2.ExecuteNonQuery();
                int m = cmd3.ExecuteNonQuery();
                if (i != 0 && j !=0 && m !=0)
                {
                    txtAgentAddress.ResetText();
                    txtAgentCode.ResetText();
                    txtAgentMobile.ResetText();
                    txtAgentName.ResetText();
                    txtAgentNIC.ResetText();
                    txtAgentPassword.ResetText();
                    txtAgentUserName.ResetText();

                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Data not Saved");
                }
            }
        }

        private void btnAgentBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
