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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnBackVP_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void btnSearchIDVP_Click(object sender, EventArgs e)
        {
            if (txtSearchIDVP.Text == "")
            {
                MessageBox.Show("Please enter NIC!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT *  FROM dbo.[Policy]" + " WHERE  policyNo='" + txtSearchIDVP.Text + "';", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);


                    /*DataSet ds = new DataSet();
                    adapter.Fill(ds, "Policy");
                    dgvAdmin.DataSource = ds.Tables["Policy"].DefaultView;*/

                    dgvViewPolicy.DataSource = null;
                    dgvViewPolicy.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgvViewPolicy.AutoGenerateColumns = false;
                        dgvViewPolicy.ColumnCount = 15;

                        dgvViewPolicy.Columns[0].HeaderText = "Policy No";
                        dgvViewPolicy.Columns[0].DataPropertyName = "policyNo";

                        dgvViewPolicy.Columns[1].HeaderText = "Customer ID";
                        dgvViewPolicy.Columns[1].DataPropertyName = "customerID";

                        dgvViewPolicy.Columns[2].HeaderText = "Agent Code";
                        dgvViewPolicy.Columns[2].DataPropertyName = "agentCode";

                        dgvViewPolicy.Columns[3].HeaderText = "Type";
                        dgvViewPolicy.Columns[3].DataPropertyName = "type";

                        dgvViewPolicy.Columns[4].HeaderText = "Monthly Premium";
                        dgvViewPolicy.Columns[4].DataPropertyName = "monthly_premium";

                        dgvViewPolicy.Columns[5].HeaderText = "Annual Premium";
                        dgvViewPolicy.Columns[5].DataPropertyName = "annual_premium";

                        dgvViewPolicy.Columns[6].HeaderText = "Hospital Plan";
                        dgvViewPolicy.Columns[6].DataPropertyName = "hospital_plan";

                        dgvViewPolicy.Columns[7].HeaderText = "Critical Illness Cover";
                        dgvViewPolicy.Columns[7].DataPropertyName = "critical_illness_cover";

                        dgvViewPolicy.Columns[8].HeaderText = "Accident Death Cover";
                        dgvViewPolicy.Columns[8].DataPropertyName = "accident_death_cover";

                        dgvViewPolicy.Columns[9].HeaderText = "Natural Death Cover";
                        dgvViewPolicy.Columns[9].DataPropertyName = "natural_death_cover";

                        dgvViewPolicy.Columns[10].HeaderText = "Opened Age";
                        dgvViewPolicy.Columns[10].DataPropertyName = "opened_age";

                        dgvViewPolicy.Columns[11].HeaderText = "Start Date";
                        dgvViewPolicy.Columns[11].DataPropertyName = "start_date";

                        dgvViewPolicy.Columns[12].HeaderText = "End Date";
                        dgvViewPolicy.Columns[12].DataPropertyName = "end_date";

                        dgvViewPolicy.Columns[13].HeaderText = "Maturity Money";
                        dgvViewPolicy.Columns[13].DataPropertyName = "maturity_money";

                        dgvViewPolicy.Columns[14].HeaderText = "Duration";
                        dgvViewPolicy.Columns[14].DataPropertyName = "duration";

                        dgvViewPolicy.DataSource = table;
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Policy for this Policy No!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateVP_Click(object sender, EventArgs e)
        {
            if(txtPolicyNoVP.Text=="" || txtTypeVP.Text=="" || txtDurationVP.Text=="" || txtMatuMoneyVP.Text=="" || txtOpenedDateVP.Text=="" || txtNaturalCoverVP.Text=="" || txtAccidentCoverVP.Text=="" || txtIllnessCoverVP.Text=="" || txtxHospitalCoverVP.Text=="" || txtMonthPreVP.Text=="" || txtAnnPremVP.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE dbo.[Policy] SET type='" + txtTypeVP.Text + "', duration='" + txtDurationVP.Text + "', maturity_money='" + txtMatuMoneyVP.Text + "', start_date='" + dtpStartDateVP.Text + "', end_date='" + dtpEndDateVP.Text + "', opened_age='" + txtOpenedDateVP.Text + "', natural_death_cover='" + txtNaturalCoverVP.Text + "', accident_death_cover='" + txtAccidentCoverVP.Text + "', critical_illness_cover='" + txtIllnessCoverVP.Text + "', hospital_plan='" + txtxHospitalCoverVP.Text + "', monthly_premium='" + txtMonthPreVP.Text + "', annual_premium='" + txtAnnPremVP.Text + "' WHERE policyNo='" + txtPolicyNoVP.Text + "';", con);
                    
                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0 )
                    {
                        txtAccidentCoverVP.ResetText();
                        txtAnnPremVP.ResetText();
                        txtDurationVP.ResetText();
                        txtIllnessCoverVP.ResetText();
                        txtMatuMoneyVP.ResetText();
                        txtMonthPreVP.ResetText();
                        txtNaturalCoverVP.ResetText();
                        txtOpenedDateVP.ResetText();
                        txtPolicyNoVP.ResetText();
                        txtSearchIDVP.ResetText();
                        txtTypeVP.ResetText();
                        txtxHospitalCoverVP.ResetText();

                        dgvViewPolicy.DataSource = null;
                        dgvViewPolicy.Rows.Clear();
                        MessageBox.Show("Data Updated");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteVP_Click(object sender, EventArgs e)
        {
            if (txtPolicyNoVP.Text == "" || txtTypeVP.Text == "" || txtDurationVP.Text == "" || txtOpenedDateVP.Text == "" || txtNaturalCoverVP.Text == "" || txtAccidentCoverVP.Text == "" || txtIllnessCoverVP.Text == "" || txtxHospitalCoverVP.Text == "" || txtMonthPreVP.Text == "" || txtAnnPremVP.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.[Policy]  WHERE policyNo='" + txtPolicyNoVP.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtAccidentCoverVP.ResetText();
                        txtAnnPremVP.ResetText();
                        txtDurationVP.ResetText();
                        txtIllnessCoverVP.ResetText();
                        txtMatuMoneyVP.ResetText();
                        txtMonthPreVP.ResetText();
                        txtNaturalCoverVP.ResetText();
                        txtOpenedDateVP.ResetText();
                        txtPolicyNoVP.ResetText();
                        txtSearchIDVP.ResetText();
                        txtTypeVP.ResetText();
                        txtxHospitalCoverVP.ResetText();

                        dgvViewPolicy.DataSource = null;
                        dgvViewPolicy.Rows.Clear();

                        MessageBox.Show("Data Deleted");

                    }
                    else
                    {
                        MessageBox.Show("Delete Error!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void dgvViewPolicy_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvViewPolicy.Rows[e.RowIndex];
                txtPolicyNoVP.Text = row.Cells[0].Value.ToString();
                txtTypeVP.Text = row.Cells[3].Value.ToString();
                txtDurationVP.Text = row.Cells[14].Value.ToString();
                txtMatuMoneyVP.Text = row.Cells[13].Value.ToString();
                dtpStartDateVP.Text = row.Cells[11].Value.ToString();
                dtpEndDateVP.Text = row.Cells[12].Value.ToString();
                txtOpenedDateVP.Text = row.Cells[10].Value.ToString();
                txtNaturalCoverVP.Text = row.Cells[9].Value.ToString();
                txtAccidentCoverVP.Text = row.Cells[8].Value.ToString();
                txtIllnessCoverVP.Text = row.Cells[7].Value.ToString();
                txtxHospitalCoverVP.Text = row.Cells[6].Value.ToString();
                txtMonthPreVP.Text = row.Cells[4].Value.ToString();
                txtAnnPremVP.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
