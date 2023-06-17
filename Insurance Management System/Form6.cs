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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnPolicyBack_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            if (txtPolicyNo.Text=="" || txtPolicyType.Text=="" || txtPolicyDuration.Text=="" || txtPolicyMatuMoney.Text=="" || txtPolicyOpenedDate.Text=="" || txtPolicyNaturalCover.Text=="" || txtPolicyAccidentCover.Text=="" || txtPolicyIllnessCover.Text=="" || txtxPolicyHospitalCover.Text=="" ||txtPolicyMonthPre.Text=="" || txtPolicyAnnPrem.Text=="" || txtPaymentAmount.Text=="")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO  dbo.[Policy](policyNo, customerID, agentCode, type, monthly_premium, annual_premium, hospital_plan, critical_illness_cover, accident_death_cover, natural_death_cover, opened_age, start_date, end_date, maturity_money, duration) " + " VALUES ('" + txtPolicyNo.Text + "','" + txtAddPolicyCID.Text + "','" + txtAgentCodeAP.Text + "','" + txtPolicyType.Text + "','" + txtPolicyMonthPre.Text + "','" + txtPolicyAnnPrem.Text + "','" + txtxPolicyHospitalCover.Text + "','" + txtPolicyIllnessCover.Text + "','" + txtPolicyAccidentCover.Text + "','" + txtPolicyNo.Text + "','" + txtPolicyOpenedDate.Text + "','" + dtpPolicyStartDate.Text  + "','" + dtpPolicyEndDate.Text + "','" + txtPolicyMatuMoney.Text + "','" + txtPolicyDuration.Text + "')", con);
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO  dbo.[Payment](customerID, policyNo, amount, date) " + " VALUES ('" + txtAddPolicyCID.Text + "','" + txtPolicyNo.Text + "','" + txtPaymentAmount.Text + "','" + dtpPaymentDate.Text + "')", con);

                    int i = cmd1.ExecuteNonQuery();
                    int j = cmd2.ExecuteNonQuery();
                    if (i != 0 && j != 0)
                    {
                        MessageBox.Show("Data Saved");

                        txtAddPolicyCID.ResetText();
                        txtAgentCodeAP.ResetText();
                        txtPolicyAccidentCover.ResetText();
                        txtPolicyAnnPrem.ResetText();
                        txtPolicyDuration.ResetText();
                        txtPolicyIllnessCover.ResetText();
                        txtPolicyMatuMoney.ResetText();
                        txtPolicyMonthPre.ResetText();
                        txtPolicyNaturalCover.ResetText();
                        txtPolicyNo.ResetText();
                        txtPolicyOpenedDate.ResetText();
                        txtPolicyType.ResetText();
                        txtxPolicyHospitalCover.ResetText();
                        txtPaymentAmount.ResetText();
                        dtpPaymentDate.ResetText();
                        dtpPolicyEndDate.ResetText();
                        dtpPolicyStartDate.ResetText();

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
