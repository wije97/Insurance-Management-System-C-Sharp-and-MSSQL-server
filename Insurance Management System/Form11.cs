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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnBackVP_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnClaimIDsearch_Click(object sender, EventArgs e)
        {
            if (txtClaimIDSearch.Text == "")
            {
                MessageBox.Show("Please enter NIC!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT *  FROM dbo.[Claim]" + " WHERE  claimID='" + txtClaimIDSearch.Text + "';", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                    dgvViewClaim.DataSource = null;
                    dgvViewClaim.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgvViewClaim.AutoGenerateColumns = false;
                        dgvViewClaim.ColumnCount = 7;

                        dgvViewClaim.Columns[0].HeaderText = "Claim ID";
                        dgvViewClaim.Columns[0].DataPropertyName = "claimID";

                        dgvViewClaim.Columns[1].HeaderText = "Customer ID";
                        dgvViewClaim.Columns[1].DataPropertyName = "customerID";

                        dgvViewClaim.Columns[2].HeaderText = "Policy No";
                        dgvViewClaim.Columns[2].DataPropertyName = "policyNo";

                        dgvViewClaim.Columns[3].HeaderText = "Amount";
                        dgvViewClaim.Columns[3].DataPropertyName = "amount";

                        dgvViewClaim.Columns[4].HeaderText = "Status";
                        dgvViewClaim.Columns[4].DataPropertyName = "status";

                        dgvViewClaim.Columns[5].HeaderText = "Issued By";
                        dgvViewClaim.Columns[5].DataPropertyName = "issued_by";

                        dgvViewClaim.Columns[6].HeaderText = "Issued Date";
                        dgvViewClaim.Columns[6].DataPropertyName = "issued_date";


                        dgvViewClaim.DataSource = table;
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Claim Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }  
            }
        }

        private void btnUpdateClaim_Click(object sender, EventArgs e)
        {
            if (txtAmountViewClaim.Text=="" || txtStatusViewClaim.Text=="")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {

                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE dbo.[Claim] SET amount='" + txtAmountViewClaim.Text + "', status='" + txtStatusViewClaim.Text + "' WHERE claimID='" + txtClaimIDSearch.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtClaimIDSearch.ResetText();
                        txtAmountViewClaim.ResetText();
                        txtStatusViewClaim.ResetText();

                        dgvViewClaim.DataSource = null;
                        dgvViewClaim.Rows.Clear();

                        MessageBox.Show("Data Updated");

                    }
                    else
                    {
                        MessageBox.Show("Update Error!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteClaim_Click(object sender, EventArgs e)
        {
            if (txtAmountViewClaim.Text == "" || txtStatusViewClaim.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.[Claim]  WHERE claimID='" + txtClaimIDSearch.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtClaimIDSearch.ResetText();
                        txtAmountViewClaim.ResetText();
                        txtStatusViewClaim.ResetText();

                        dgvViewClaim.DataSource = null;
                        dgvViewClaim.Rows.Clear();

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

        private void dgvViewClaim_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvViewClaim.Rows[e.RowIndex];
                    txtStatusViewClaim.Text = row.Cells[4].Value.ToString();
                    txtAmountViewClaim.Text = row.Cells[3].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvViewClaim.DataSource = null;
            dgvViewClaim.Rows.Clear();

            txtClaimIDSearch.ResetText();
        }

        private void btnviewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT *  FROM dbo.[Claim_vs_Payment]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

            dgvViewClaim.DataSource = null;
            dgvViewClaim.Rows.Clear();
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                dgvViewClaim.AutoGenerateColumns = false;
                dgvViewClaim.ColumnCount = 9;

                dgvViewClaim.Columns[0].HeaderText = "Customer ID";
                dgvViewClaim.Columns[0].DataPropertyName = "customerID";

                dgvViewClaim.Columns[1].HeaderText = "Claim ID";
                dgvViewClaim.Columns[1].DataPropertyName = "claimID";

                dgvViewClaim.Columns[2].HeaderText = "Policy No";
                dgvViewClaim.Columns[2].DataPropertyName = "policyNo";

                dgvViewClaim.Columns[3].HeaderText = "Amount";
                dgvViewClaim.Columns[3].DataPropertyName = "amount";

                dgvViewClaim.Columns[4].HeaderText = "Status";
                dgvViewClaim.Columns[4].DataPropertyName = "status";

                dgvViewClaim.Columns[5].HeaderText = "Issued By";
                dgvViewClaim.Columns[5].DataPropertyName = "issued_by";

                dgvViewClaim.Columns[6].HeaderText = "Issued Date";
                dgvViewClaim.Columns[6].DataPropertyName = "issued_date";

                dgvViewClaim.Columns[7].HeaderText = "Payment ID";
                dgvViewClaim.Columns[7].DataPropertyName = "paymentID";

                dgvViewClaim.Columns[8].HeaderText = "Date";
                dgvViewClaim.Columns[8].DataPropertyName = "date";


                dgvViewClaim.DataSource = table;
                con.Close();
            }
            else
            {
                MessageBox.Show("No Claim Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
