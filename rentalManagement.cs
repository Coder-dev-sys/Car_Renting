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

namespace final
{
    public partial class rentalManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public rentalManagement()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromdat = fromDate.Value.Date;
                DateTime todat = toDate.Value.Date;
                if (txtUsername.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && fromdat != null && todat != null && txtBill.Text != "")
                {
                    con.Open();

                    // Duplication check
                    String query = "select count(*) from rentalManagement where username=@userName and CarModel=@model";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@model", txtCarModel.Text);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Customer Already Exists !", "Dulication Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                        return;
                    }

                    // Data Insertion
                    String qry = "insert into rentalManagement(username,CarModel,FromDate,ToDate,RentPerDay,TotalBilling,PaymentStatus) values (@userName,@carModel,@fromDate,@toDate,@rentPerDay,@rentBill,@PaymentStatus)";
                    cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("userName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("carModel", txtCarModel.Text);
                    cmd.Parameters.AddWithValue("fromDate", fromDate.Text);
                    cmd.Parameters.AddWithValue("toDate", toDate.Text);
                    cmd.Parameters.AddWithValue("rentPerDay", txtRentPerDay.Text);
                    cmd.Parameters.AddWithValue("rentBill", txtBill.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", "Pending");
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Customer Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Added !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromdat = fromDate.Value.Date;
                DateTime todat = toDate.Value.Date;
                if (txtUsername.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && fromdat != null && todat != null && txtBill.Text != "")
                {
                    con.Open();

                    // Duplication check
                    String query = "select count(*) from rentalManagement where username=@userName and CarModel=@model";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@model", txtCarModel.Text);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Customer Already Exists !", "Dulication Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                        return;
                    }

                    // Data Insertion
                    cmd = new SqlCommand(("update rentalManagement set username=@userName,CarModel=@carModel,FromDate=@fromDate,ToDate=@toDate,RentPerDay=@rentPerDay,TotalBilling=@rentBill where id=@id"), con);
                    cmd.Parameters.AddWithValue("id", txtId.Text);
                    cmd.Parameters.AddWithValue("userName", txtUsername.Text);
                    cmd.Parameters.AddWithValue("carModel", txtCarModel.Text);
                    cmd.Parameters.AddWithValue("fromDate", fromDate.Text);
                    cmd.Parameters.AddWithValue("toDate", toDate.Text);
                    cmd.Parameters.AddWithValue("rentPerDay", txtRentPerDay.Text);
                    cmd.Parameters.AddWithValue("rentBill", txtBill.Text);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Customer Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Updated !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromdat = fromDate.Value.Date;
                DateTime todat = toDate.Value.Date;
                if (txtUsername.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && fromdat != null && todat != null && txtBill.Text != "")
                {
                    con.Open();
                    int id = Convert.ToInt32(txtId.Text);
                    string query = "delete from rentalManagement where id='" + id + "'";
                    cmd = new SqlCommand(query, con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Customer Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void rentalManagement_Load(object sender, EventArgs e)
        {
            loadData();
            txtUsername.Focus();
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void clearData()
        {
            txtId.Text = "";
            txtUsername.Text = "Username";
            txtCarModel.Text = "Car Model";
            txtRentPerDay.Text = "Rent Per Day";
            fromDate.Value = Convert.ToDateTime("01-01-2024 05:57");
            toDate.Value = Convert.ToDateTime("02-01-2024 06:35");
            txtBill.Text = "Rent Bill";
        }

        private void loadData()
        {
            try
            {
                dataGridView1.Visible = true;
                lblnorental.Visible = false;
                con.Open();
                String query = "select * from rentalManagement";
                cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count <= 0)
                {
                    dataGridView1.Visible = false;
                    lblnorental.Visible = true;
                }
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["username"].HeaderText = "User name";
                dataGridView1.Columns["carModel"].HeaderText = "Car Model";
                dataGridView1.Columns["TotalDays"].HeaderText = "Total Days";
                dataGridView1.Columns["fromDate"].HeaderText = "From Date";
                dataGridView1.Columns["toDate"].HeaderText = "Due   Date";
                dataGridView1.Columns["rentPerDay"].HeaderText = "Rent /  Day";
                dataGridView1.Columns["TotalBilling"].HeaderText = "Bill";
                dataGridView1.Columns["PaymentStatus"].HeaderText = "Payment  Status";
                con.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dgr = dataGridView1.Rows[index];
                txtId.Text = dgr.Cells[0].Value.ToString();
                txtUsername.Text = dgr.Cells[8].Value.ToString();
                txtCarModel.Text = dgr.Cells[1].Value.ToString();
                fromDate.Value = Convert.ToDateTime(dgr.Cells[3].Value.ToString());
                toDate.Value = Convert.ToDateTime(dgr.Cells[4].Value.ToString());
                txtRentPerDay.Text = dgr.Cells[5].Value.ToString();
                txtBill.Text = dgr.Cells[6].Value.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
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

        private void btnVehicleMng_Click(object sender, EventArgs e)
        {
            carManagement cr = new carManagement();
            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void btnRentalMng_Click(object sender, EventArgs e)
        {
            rentalManagement rm = new rentalManagement();
            this.Hide();
            rm.ShowDialog();
            this.Close();
        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            userManagement um = new userManagement();
            this.Hide();
            um.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        /*  btnVehicleMng2 Hover */
        private void btnVehicleMng2_MouseEnter(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void btnVehicleMng2_MouseLeave(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        /*  btnUserMng2 Hover */
        private void btnUserMng2_MouseLeave(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        private void btnUserMng2_MouseEnter(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  btnRentalMng2 Hover */
        private void btnRentalMng2_MouseEnter(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void btnRentalMng2_MouseLeave(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  btnLogout Hover */
        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  btnInsert Hover */
        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            btnInsert.BackColor = System.Drawing.Color.Green;
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            btnInsert.BackColor = System.Drawing.Color.ForestGreen;
        }

        /*  btnClear Hover */
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        /*  btnUpdate Hover */
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
        }

        /*  btnDelete Hover */
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = System.Drawing.Color.OrangeRed;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
        private void revenuebtn_MouseEnter(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void revenuebtn_MouseLeave(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        private void revenuebtn_Click(object sender, EventArgs e)
        {
            revenue rev = new revenue();
            this.Hide();
            rev.ShowDialog();
            this.Close();
        }
    }
}