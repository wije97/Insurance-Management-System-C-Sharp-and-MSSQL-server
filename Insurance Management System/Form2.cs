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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSearchPNAdmin_Click(object sender, EventArgs e)
        {
            if (txtSearchPNOAdmin.Text == "")
            {
                MessageBox.Show("Please enter Policy No!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT *  FROM dbo.[Policy]" + " WHERE  policyNo='" + txtSearchPNOAdmin.Text + "';", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);
                    

                    /*DataSet ds = new DataSet();
                    adapter.Fill(ds, "Policy");
                    dgvAdmin.DataSource = ds.Tables["Policy"].DefaultView;*/

                    dgvAdmin.DataSource = null;
                    dgvAdmin.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgvAdmin.AutoGenerateColumns = false;
                        dgvAdmin.ColumnCount = 15;

                        dgvAdmin.Columns[0].HeaderText = "Policy No";
                        dgvAdmin.Columns[0].DataPropertyName = "policyNo";

                        dgvAdmin.Columns[1].HeaderText = "Customer ID";
                        dgvAdmin.Columns[1].DataPropertyName = "customerID";

                        dgvAdmin.Columns[2].HeaderText = "Agent Code";
                        dgvAdmin.Columns[2].DataPropertyName = "agentCode";

                        dgvAdmin.Columns[3].HeaderText = "Type";
                        dgvAdmin.Columns[3].DataPropertyName = "type";

                        dgvAdmin.Columns[4].HeaderText = "Monthly Premium";
                        dgvAdmin.Columns[4].DataPropertyName = "monthly_premium";

                        dgvAdmin.Columns[5].HeaderText = "Annual Premium";
                        dgvAdmin.Columns[5].DataPropertyName = "annual_premium";

                        dgvAdmin.Columns[6].HeaderText = "Hospital Plan";
                        dgvAdmin.Columns[6].DataPropertyName = "hospital_plan";

                        dgvAdmin.Columns[7].HeaderText = "Critical Illness Cover";
                        dgvAdmin.Columns[7].DataPropertyName = "critical_illness_cover";

                        dgvAdmin.Columns[8].HeaderText = "Accident Death Cover";
                        dgvAdmin.Columns[8].DataPropertyName = "accident_death_cover";

                        dgvAdmin.Columns[9].HeaderText = "Natural Death Cover";
                        dgvAdmin.Columns[9].DataPropertyName = "natural_death_cover";

                        dgvAdmin.Columns[10].HeaderText = "Opened Age";
                        dgvAdmin.Columns[10].DataPropertyName = "opened_age";

                        dgvAdmin.Columns[11].HeaderText = "Start Date";
                        dgvAdmin.Columns[11].DataPropertyName = "start_date";

                        dgvAdmin.Columns[12].HeaderText = "End Date";
                        dgvAdmin.Columns[12].DataPropertyName = "end_date";

                        dgvAdmin.Columns[13].HeaderText = "Maturity Money";
                        dgvAdmin.Columns[13].DataPropertyName = "maturity_money";

                        dgvAdmin.Columns[14].HeaderText = "Duration";
                        dgvAdmin.Columns[14].DataPropertyName = "duration";

                        dgvAdmin.DataSource = table;
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

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT *  FROM dbo.[Customer_vs_Policy]", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

            dgvAdmin.DataSource = null;
            dgvAdmin.Rows.Clear();
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {

                dgvAdmin.AutoGenerateColumns = false;
                dgvAdmin.ColumnCount = 8;

                dgvAdmin.Columns[0].HeaderText = "Customer ID";
                dgvAdmin.Columns[0].DataPropertyName = "customerID";

                dgvAdmin.Columns[1].HeaderText = "DOB";
                dgvAdmin.Columns[1].DataPropertyName = "DOB";

                dgvAdmin.Columns[2].HeaderText = "Policy No";
                dgvAdmin.Columns[2].DataPropertyName = "policyNo";

                dgvAdmin.Columns[3].HeaderText = "Type";
                dgvAdmin.Columns[3].DataPropertyName = "type";

                dgvAdmin.Columns[4].HeaderText = "Annual Premium";
                dgvAdmin.Columns[4].DataPropertyName = "annual_premium";

                dgvAdmin.Columns[5].HeaderText = "Start Date";
                dgvAdmin.Columns[5].DataPropertyName = "start_date";

                dgvAdmin.Columns[6].HeaderText = "End Date";
                dgvAdmin.Columns[6].DataPropertyName = "end_date";

                dgvAdmin.Columns[7].HeaderText = "Maturity Money";
                dgvAdmin.Columns[7].DataPropertyName = "maturity_money";

                dgvAdmin.DataSource = table;
                con.Close();
            }
            else
            {
                MessageBox.Show("No Policies!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = null;
            dgvAdmin.Rows.Clear();

            txtSearchPNOAdmin.ResetText();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.Show();
            this.Hide();
        }
    }
}
