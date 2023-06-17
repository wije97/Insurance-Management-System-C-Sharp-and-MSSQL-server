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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnBackClaim_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            if (txtClaimID.Text == "" || txtPolicyNoClaim.Text == "" || txtClaimStatus.Text == "" || txtClaimAmount.Text == "" || txtClaimIssuedBy.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO  dbo.[Claim](claimID, customerID, policyNo, amount, status, issued_by, issued_date) " + " VALUES ('" + txtClaimID.Text + "','" + txtCustomeID.Text + "','" + txtPolicyNoClaim.Text + "','" + txtClaimAmount.Text + "','" + txtClaimStatus.Text + "','" + txtClaimIssuedBy.Text + "','" + dtpClaimIDate.Text +"')", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0 )
                    {
                        txtClaimAmount.ResetText();
                        txtClaimID.ResetText();
                        txtClaimIssuedBy.ResetText();
                        txtClaimStatus.ResetText();
                        txtCustomeID.ResetText();
                        txtPolicyNoClaim.ResetText();

                        MessageBox.Show("Data Saved");
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
