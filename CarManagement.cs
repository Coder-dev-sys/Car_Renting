using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class CarManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public CarManagement()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Project\Car Renting\WinFormsApp1\db1.mdf';Integrated Security=True");

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
            groupBox1.Top = (this.ClientSize.Height + groupBox1.Height) / 7;
            dataGridView1.Top = (this.ClientSize.Height + groupBox1.Height) / 7;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 11;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" && txtModel.Text != "" && txtRent.Text != "" && chkAvailability.Text != "")
            {
                con.Open();

                // Duplication Check
                string checkQuery = "SELECT COUNT(*) FROM carManagement WHERE brand = @brand and model = @model";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                checkCmd.Parameters.AddWithValue("@model", txtModel.Text);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Brand And Model already registered!", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                // Data Insertion 
                string qry = "insert into carManagement (brand,model,rentPerDay,availability) values (@brand,@model,@rentPerDay,@availability)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("model", txtModel.Text);
                cmd.Parameters.AddWithValue("rentPerDay", txtRent.Text);
                cmd.Parameters.AddWithValue("availability", chkAvailability.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Vehicle Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vehicle Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Vehicle Details !", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" && txtModel.Text != "" && txtRent.Text != "" && chkAvailability.Text != "")
            {
                con.Open();
                cmd = new SqlCommand(("update carManagement set brand=@brand, model=@model, rentPerDay=@rentPerDay, availability=@availability where id=@id"), con);
                cmd.Parameters.AddWithValue("id", txtId.Text);
                cmd.Parameters.AddWithValue("brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("model", txtModel.Text);
                cmd.Parameters.AddWithValue("rentPerDay", txtRent.Text);
                cmd.Parameters.AddWithValue("availability", chkAvailability.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Vehicle Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vehicle Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Vehicle Details !", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dgr = dataGridView1.Rows[index];
            txtId.Text = dgr.Cells[0].Value.ToString();
            txtBrand.Text = dgr.Cells[1].Value.ToString();
            txtModel.Text = dgr.Cells[2].Value.ToString();
            txtRent.Text = dgr.Cells[3].Value.ToString();
            chkAvailability.Text = dgr.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtBrand.Text != "" && txtModel.Text != "" && txtRent.Text != "" && chkAvailability.Text != "")
            {
                con.Open();
                int id = Convert.ToInt32(txtId.Text);
                string qry = "delete from carManagement where id='" + id + "'";
                cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("Vehicle Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vehicle Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Vehicle Details !", "Missing Info.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtId.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtRent.Clear();
            chkAvailability.SelectedIndex = -1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard fm = new AdminDashboard();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void loadData()
        {
            con.Open();
            
            // Loading Data
            string qry = "select * from carManagement";
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            // Renaming Column Names
            dataGridView1.Columns["brand"].HeaderText = "Car Brand";
            dataGridView1.Columns["model"].HeaderText = "Car Model";
            dataGridView1.Columns["rentPerDay"].HeaderText = "Rent / Day";
            dataGridView1.Columns["availability"].HeaderText = "Status";

            con.Close();
        }
        private void CarManagement_Load(object sender, EventArgs e)
        {
            loadData();
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
    }
}