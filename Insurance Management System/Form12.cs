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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnAgentSearch_Click(object sender, EventArgs e)
        {
            txtCHeckPayment.ResetText();
            txtCustomerSearch.ResetText();

            if (txtAgentSearch.Text == "")
            {
                MessageBox.Show("Please enter Agent Code!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SP_GetCustomersByAgent", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@AgentCode", txtAgentSearch.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                dataViewResult.DataSource = null;
                dataViewResult.Rows.Clear();
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dataViewResult.AutoGenerateColumns = false;
                    dataViewResult.ColumnCount = 6;

                    dataViewResult.Columns[0].HeaderText = "Customer ID";
                    dataViewResult.Columns[0].DataPropertyName = "customerID";

                    dataViewResult.Columns[1].HeaderText = "Policy No";
                    dataViewResult.Columns[1].DataPropertyName = "policyNo";

                    dataViewResult.Columns[2].HeaderText = "Type";
                    dataViewResult.Columns[2].DataPropertyName = "type";

                    dataViewResult.Columns[3].HeaderText = "Annual Premium";
                    dataViewResult.Columns[3].DataPropertyName = "annual_premium";

                    dataViewResult.Columns[4].HeaderText = "Start Date";
                    dataViewResult.Columns[4].DataPropertyName = "start_date";

                    dataViewResult.Columns[5].HeaderText = "Duration";
                    dataViewResult.Columns[5].DataPropertyName = "duration";


                    dataViewResult.DataSource = table;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Agent Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {

            txtAgentSearch.ResetText();
            txtCHeckPayment.ResetText();

            if (txtCustomerSearch.Text == "")
            {
                MessageBox.Show("Please enter Customer ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SP_GetClaimsByCustomer", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@CustomerID", txtCustomerSearch.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                dataViewResult.DataSource = null;
                dataViewResult.Rows.Clear();
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    dataViewResult.AutoGenerateColumns = false;
                    dataViewResult.ColumnCount = 4;

                    dataViewResult.Columns[0].HeaderText = "Claim ID";
                    dataViewResult.Columns[0].DataPropertyName = "claimID";

                    dataViewResult.Columns[1].HeaderText = "Policy No";
                    dataViewResult.Columns[1].DataPropertyName = "policyNo";

                    dataViewResult.Columns[2].HeaderText = "Amount";
                    dataViewResult.Columns[2].DataPropertyName = "amount";

                    dataViewResult.Columns[3].HeaderText = "Issued Date";
                    dataViewResult.Columns[3].DataPropertyName = "issued_date";

                    dataViewResult.DataSource = table;
                    con.Close();
                }
                else
                {
                    MessageBox.Show("No Claim Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCHeckPayment_Click(object sender, EventArgs e)
        {

            txtAgentSearch.ResetText();
            txtCustomerSearch.ResetText();

            if (txtCHeckPayment.Text == "")
            {
                MessageBox.Show("Please enter Customer ID!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("Select * FROM TV_PaymentsByCustomer(@CustomerID)", con);
                    cmd1.CommandType = CommandType.Text;
                    cmd1.Parameters.AddWithValue("@CustomerID", txtCHeckPayment.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                    dataViewResult.DataSource = null;
                    dataViewResult.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dataViewResult.AutoGenerateColumns = false;
                        dataViewResult.ColumnCount = 5;

                        dataViewResult.Columns[0].HeaderText = "Payment ID";
                        dataViewResult.Columns[0].DataPropertyName = "paymentID";

                        dataViewResult.Columns[1].HeaderText = "Customer ID";
                        dataViewResult.Columns[1].DataPropertyName = "customerID";

                        dataViewResult.Columns[2].HeaderText = "Policy No";
                        dataViewResult.Columns[2].DataPropertyName = "policyNo";

                        dataViewResult.Columns[3].HeaderText = "Amount";
                        dataViewResult.Columns[3].DataPropertyName = "amount";

                        dataViewResult.Columns[4].HeaderText = "Date";
                        dataViewResult.Columns[4].DataPropertyName = "date";


                        dataViewResult.DataSource = table;
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Payment Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAgentSearch.ResetText();
            txtCustomerSearch.ResetText();
            txtCHeckPayment.ResetText();

            dataViewResult.DataSource = null;
            dataViewResult.Rows.Clear();
        }
    }
}
