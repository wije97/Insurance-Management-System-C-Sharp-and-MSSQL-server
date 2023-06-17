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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnBackVPAy_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnPayIDsearch_Click(object sender, EventArgs e)
        {
            if (txtPayIDSearch.Text == "")
            {
                MessageBox.Show("Please enter NIC!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("Select * FROM dbo.[Payment] WHERE paymentID='" + txtPayIDSearch.Text + "';", con);
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                    dgvViewPay.DataSource = null;
                    dgvViewPay.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgvViewPay.AutoGenerateColumns = false;
                        dgvViewPay.ColumnCount = 5;

                        dgvViewPay.Columns[0].HeaderText = "Payment ID";
                        dgvViewPay.Columns[0].DataPropertyName = "paymentID";

                        dgvViewPay.Columns[1].HeaderText = "Customer ID";
                        dgvViewPay.Columns[1].DataPropertyName = "customerID";

                        dgvViewPay.Columns[2].HeaderText = "Policy No";
                        dgvViewPay.Columns[2].DataPropertyName = "policyNo";

                        dgvViewPay.Columns[3].HeaderText = "Amount";
                        dgvViewPay.Columns[3].DataPropertyName = "amount";

                        dgvViewPay.Columns[4].HeaderText = "Date";
                        dgvViewPay.Columns[4].DataPropertyName = "date";


                        dgvViewPay.DataSource = table;
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

        private void btnUpdatePay_Click(object sender, EventArgs e)
        {
            if(txtAmountPay.Text=="" )
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE dbo.[Payment] SET amount='" + txtAmountPay.Text + "', date='" + dtpPaymentDateView.Text + "' WHERE paymentID='" + txtPayIDSearch.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtAmountPay.ResetText();
                        txtPayIDSearch.ResetText();
                        dtpPaymentDateView.ResetText();

                        dgvViewPay.DataSource = null;
                        dgvViewPay.Rows.Clear();

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

        private void btnDeletePAy_Click(object sender, EventArgs e)
        {
            if (txtAmountPay.Text == "" )
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.[Payment] WHERE paymentID='" + txtPayIDSearch.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtAmountPay.ResetText();
                        txtPayIDSearch.ResetText();
                        dtpPaymentDateView.ResetText();

                        dgvViewPay.DataSource = null;
                        dgvViewPay.Rows.Clear();

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

        private void dgvViewPay_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvViewPay.Rows[e.RowIndex];
                    txtAmountPay.Text = row.Cells[3].Value.ToString();
                    dtpPaymentDateView.Text = row.Cells[4].Value.ToString();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
