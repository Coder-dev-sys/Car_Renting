using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class carRent : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        private string loggedInUserName;
        public carRent(string username)
        {
            InitializeComponent();
            loggedInUserName = username;
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

        // Calculate Days
        private void CalculateBookingDays(object sender, EventArgs e)
        {
            DateTime fromDate = fromCarDate.Value.Date;
            DateTime toDate = toCarDate.Value.Date;

            if (toDate >= fromDate)
            {
                int totalDays = (toDate - fromDate).Days + 1;
                lblDays.Text = $"{totalDays}";
                if (decimal.TryParse(txtRent.Text, out decimal rentPerDay))
                {
                    decimal total = totalDays * rentPerDay;
                    lblBill.Text = $"₹{total}";
                }
            }
            else
            {
                lblDays.Text = "Invalid date range";
                lblBill.Text = "";
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
        }

        private void clearData()
        {
            txtId.Clear();
            txtBrand.Clear();
            txtModel.Clear();
            txtRent.Clear();
            lblBill.Text = "";
            lblDays.Text = "";
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

        private void carRent_Load(object sender, EventArgs e)
        {
            loadData();
            clearData();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm fm = new LoginForm();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtModel.Text == "" || txtBrand.Text == "")
            {
                MessageBox.Show("Please select a vehicle and valid Dates first.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if vehicle is available or not
            con.Open();
            string chkAvailabilityQuery = "select availability from carManagement where model = @carModel";
            cmd = new SqlCommand(chkAvailabilityQuery, con);
            cmd.Parameters.AddWithValue("@carModel", txtModel.Text);
            string availability = cmd.ExecuteScalar()?.ToString();
            con.Close();
            if (availability != null && availability.ToLower() != "available")
            {
                MessageBox.Show("This vehicle is currently not Available!", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if same booking already exists or not
            con.Open();
            string checkQuery = @"select count(*) from rentalManagement where custFullName = (select fullName from userManagement where userName = @userName) and carModel = @carModel";
            cmd = new SqlCommand(checkQuery, con);
            cmd.Parameters.AddWithValue("@userName", loggedInUserName);
            cmd.Parameters.AddWithValue("@carModel", txtModel.Text);
            int exists = (int)cmd.ExecuteScalar();
            con.Close();
            if (exists > 0)
            {
                MessageBox.Show("You have already booked this vehicle !", "Duplicate Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert booking
            con.Open();
            string insertQuery = @"insert into rentalManagement (custFullName, carModel, fromDate, toDate, rentBill) select fullName, @carModel, @fromDate, @toDate, @rentBill from userManagement where userName = @userName";
            cmd = new SqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@carModel", txtModel.Text);
            cmd.Parameters.AddWithValue("@fromDate", fromCarDate.Value.Date);
            cmd.Parameters.AddWithValue("@toDate", toCarDate.Value.Date);
            cmd.Parameters.AddWithValue("@rentBill", lblBill.Text.Replace("₹", ""));
            cmd.Parameters.AddWithValue("@userName", loggedInUserName);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
            {
                MessageBox.Show("Vehicle Booked Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearData();
                con.Close();
            }
            else
            {
                MessageBox.Show("Booking failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
