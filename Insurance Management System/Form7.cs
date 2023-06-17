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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnBackVC_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnPolicyVC_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void btnSearchIDVC_Click(object sender, EventArgs e)
        {
            if (txtSearchIDVC.Text == "")
            {
                MessageBox.Show("Please enter NIC!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT dbo.[Customer].customerID, dbo.[Customer].NIC, dbo.[Customer].DOB, dbo.[Customer].religion, dbo.[Customer].nationality , dbo.[User].name_with_initials, dbo.[User].address, dbo.[User].gender, dbo.[userMobile].mobile FROM dbo.[Customer] LEFT JOIN dbo.[User] ON dbo.[User].NIC = dbo.[Customer].NIC LEFT JOIN dbo.[userMobile] ON dbo.[User].NIC = dbo.[userMobile].NIC WHERE dbo.[User].NIC='" + txtSearchIDVC.Text + "';", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd1);

                    dgvViewCustomer.DataSource = null;
                    dgvViewCustomer.Rows.Clear();
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        dgvViewCustomer.AutoGenerateColumns = false;
                        dgvViewCustomer.ColumnCount = 9;

                        dgvViewCustomer.Columns[0].HeaderText = "Customer ID";
                        dgvViewCustomer.Columns[0].DataPropertyName = "customerID";

                        dgvViewCustomer.Columns[1].HeaderText = "Name";
                        dgvViewCustomer.Columns[1].DataPropertyName = "name_with_initials";

                        dgvViewCustomer.Columns[2].HeaderText = "NIC";
                        dgvViewCustomer.Columns[2].DataPropertyName = "NIC";

                        dgvViewCustomer.Columns[3].HeaderText = "Gender";
                        dgvViewCustomer.Columns[3].DataPropertyName = "gender";

                        dgvViewCustomer.Columns[4].HeaderText = "Address";
                        dgvViewCustomer.Columns[4].DataPropertyName = "address";

                        dgvViewCustomer.Columns[5].HeaderText = "Mobile";
                        dgvViewCustomer.Columns[5].DataPropertyName = "mobile";

                        dgvViewCustomer.Columns[6].HeaderText = "Date of Birth";
                        dgvViewCustomer.Columns[6].DataPropertyName = "DOB";

                        dgvViewCustomer.Columns[7].HeaderText = "Religion";
                        dgvViewCustomer.Columns[7].DataPropertyName = "religion";

                        dgvViewCustomer.Columns[8].HeaderText = "Nationality";
                        dgvViewCustomer.Columns[8].DataPropertyName = "nationality";


                        dgvViewCustomer.DataSource = table;
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("No Customer Record!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdateVC_Click(object sender, EventArgs e)
        {
            if(txtCusIDVCustomer.Text =="" || txtNameVC.Text=="" || txtNICVC.Text=="" || txtAddressVC.Text=="" || txtMobileVC.Text=="" || txtReligionVC.Text=="" || txtNationalityVC.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("UPDATE dbo.[User] SET name_with_initials='" + txtNameVC.Text + "', gender='" + cmbGenderVC.Text + "', address='" + txtAddressVC.Text + "' WHERE NIC='" + txtNICVC.Text + "';", con);
                    SqlCommand cmd2 = new SqlCommand("UPDATE dbo.[Customer] SET DOB='" + dtpDOBVC.Text + "', religion='" + txtReligionVC.Text + "', nationality='" + txtNationalityVC.Text  + "' WHERE NIC='" + txtNICVC.Text + "';", con);
                    SqlCommand cmd3 = new SqlCommand("UPDATE dbo.[userMobile] SET  mobile='" + txtMobileVC.Text + "' WHERE NIC='" + txtNICVC.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    int j = cmd2.ExecuteNonQuery();
                    int m = cmd3.ExecuteNonQuery();
                    if (i != 0 && j != 0 && m != 0)
                    {
                        txtAddressVC.ResetText();
                        txtCusIDVCustomer.ResetText();
                        txtMobileVC.ResetText();
                        txtNameVC.ResetText();
                        txtNationalityVC.ResetText();
                        txtNICVC.ResetText();
                        txtReligionVC.ResetText();
                        txtSearchIDVC.ResetText();
                        dtpDOBVC.ResetText();

                        dgvViewCustomer.DataSource = null;
                        dgvViewCustomer.Rows.Clear();

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

        private void btnDeleteVC_Click(object sender, EventArgs e)
        {
            if (txtCusIDVCustomer.Text == "" || txtNameVC.Text == "" || txtNICVC.Text == "" || txtAddressVC.Text == "" || txtMobileVC.Text == "" || txtReligionVC.Text == "" || txtNationalityVC.Text == "")
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=InsuranceDB;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.[Customer]  WHERE NIC='" + txtNICVC.Text + "';", con);

                    int i = cmd1.ExecuteNonQuery();
                    if (i != 0)
                    {
                        txtAddressVC.ResetText();
                        txtCusIDVCustomer.ResetText();
                        txtMobileVC.ResetText();
                        txtNameVC.ResetText();
                        txtNationalityVC.ResetText();
                        txtNICVC.ResetText();
                        txtReligionVC.ResetText();
                        txtSearchIDVC.ResetText();
                        dtpDOBVC.ResetText();

                        dgvViewCustomer.DataSource = null;
                        dgvViewCustomer.Rows.Clear();

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

        private void dgvViewCustomer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvViewCustomer.Rows[e.RowIndex];
                    txtCusIDVCustomer.Text = row.Cells[0].Value.ToString();
                    txtNameVC.Text = row.Cells[1].Value.ToString();
                    txtNICVC.Text = row.Cells[2].Value.ToString();
                    cmbGenderVC.Text = row.Cells[3].Value.ToString(); 
                    txtAddressVC.Text = row.Cells[4].Value.ToString();
                    txtMobileVC.Text = row.Cells[5].Value.ToString(); 
                    dtpDOBVC.Text = row.Cells[6].Value.ToString();
                    txtReligionVC.Text = row.Cells[7].Value.ToString();
                    txtNationalityVC.Text = row.Cells[8].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
