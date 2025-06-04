using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public partial class RentalManagenent : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public RentalManagenent()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db1.mdf;Integrated Security=True;");

            CenterGroupBox();
            this.Resize += (s, e) => CenterGroupBox();
        }
        private void CenterGroupBox()
        {
            // Horizontally position
            int spaceBetween = 50;

            // Calculate total width of both controls + gap
            int totalWidth = groupBox1.Width + dataGridView1.Width + spaceBetween;

            // Start X to center them as a unit
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            groupBox1.Left = startX;
            dataGridView1.Left = groupBox1.Right + spaceBetween;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;

            // Vertically center
            groupBox1.Top = (this.ClientSize.Height + groupBox1.Height) / 6;
            dataGridView1.Top = (this.ClientSize.Height + groupBox1.Height) / 6;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 11;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCustname.Text != "" && txtModel.Text != "" && txtRent.Text != "" && txtRent.Text != "" && toCarDate.Text != "" && fromCarDate.Text != "")
            {
                con.Open();

                // Duplication Check
                string checkQuery = "SELECT COUNT(*) FROM rentalManagement WHERE custFullName = @fullname and carModel = @model";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@fullname", txtCustname.Text);
                checkCmd.Parameters.AddWithValue("@model", txtModel.Text);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Customer Already Exist !", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                // Data Insertion 
                string qry = "insert into rentalManagement (custFullName,carModel,fromDate,toDate,rentBill) values (@custFullName,@carModel,@fromDate,@toDate,@rentBill)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("custFullName", txtCustname.Text);
                cmd.Parameters.AddWithValue("carModel", txtModel.Text);
                cmd.Parameters.AddWithValue("fromDate", fromCarDate.Value.Date);
                cmd.Parameters.AddWithValue("toDate", toCarDate.Value.Date);
                cmd.Parameters.AddWithValue("rentBill", txtRent.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Details", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard lfm = new AdminDashboard();
            this.Hide();
            lfm.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustname.Text != "" && txtModel.Text != "" && txtRent.Text != "" && toCarDate.Text != "" && fromCarDate.Text != "")
            {
                con.Open();
                int id = Convert.ToInt32(txtId.Text);
                string qry = "delete from rentalManagement where id='" + id + "'";
                cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Details", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearData()
        {
            txtId.Clear();
            txtCustname.Clear();
            txtModel.Clear();
            txtRent.Clear();
        }

        private void loadData()
        {
            con.Open();

            // Loading Data
            string qry = "select * from rentalManagement";
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            // Renaming Column Names
            dataGridView1.Columns["custFullName"].HeaderText = "Customer Name";
            dataGridView1.Columns["carModel"].HeaderText = "Car Model";
            dataGridView1.Columns["fromDate"].HeaderText = "From Date";
            dataGridView1.Columns["toDate"].HeaderText = "To Date";
            dataGridView1.Columns["rentBill"].HeaderText = "Rent Bill";

            con.Close();
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int hoveredRowIndex = -1;
            if (e.RowIndex >= 0 && e.RowIndex != hoveredRowIndex)
            {
                hoveredRowIndex = e.RowIndex;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dgr = dataGridView1.Rows[index];
            txtId.Text = dgr.Cells[0].Value.ToString();
            txtCustname.Text = dgr.Cells[1].Value.ToString();
            txtModel.Text = dgr.Cells[2].Value.ToString();
            fromCarDate.Text = dgr.Cells[3].Value.ToString();
            toCarDate.Text = dgr.Cells[4].Value.ToString();
            txtRent.Text = dgr.Cells[5].Value.ToString();
        }

        private void RentalManagenent_Load(object sender, EventArgs e)
        {
            clearData();
            loadData();
        }
    }
}
