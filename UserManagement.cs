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
    public partial class userManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public userManagement()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtUsernm.Text != "" && txtPwd.Text != "")
            {
                con.Open();

                // Duplication check
                String query = "select count(*) from userManagement where userName=@unm and password=@pwd";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@unm", txtUsernm.Text);
                cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                int exists = (int)cmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("User Already Exists !", "Dulication Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                // Data Insertion
                String qry = "insert into userManagement(email,userName,password) values (@email,@userName,@password)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("userName", txtUsernm.Text);
                cmd.Parameters.AddWithValue("password", txtPwd.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 1)
                {
                    MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Added !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearData();
                loadData();
            }
            else
            {
                MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearData()
        {
            txtId.Text = "";
            txtEmail.Text = "";
            txtUsernm.Text = "";
            txtPwd.Text = "";
        }

        private void loadData()
        {
            dataGridView1.Visible = true;
            lblnouser.Visible = false;
            con.Open();
            String query = "select * from userManagement";
            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count <= 0)
            {
                dataGridView1.Visible = false;
                lblnouser.Visible = true;
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["fullName"].HeaderText = "Customer Name";
            dataGridView1.Columns["mobileNo"].HeaderText = "Mobile No.";
            dataGridView1.Columns["email"].HeaderText = "Email ID";
            dataGridView1.Columns["address"].HeaderText = "Address";
            dataGridView1.Columns["userName"].HeaderText = "Username";
            dataGridView1.Columns["password"].HeaderText = "Password";
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtUsernm.Text != "" && txtPwd.Text != "")
            {
                con.Open();
                cmd = new SqlCommand(("update userManagement set email=@email,userName=@usernm,password=@pwd where id=@id"), con);
                cmd.Parameters.AddWithValue("id", txtId.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("usernm", txtUsernm.Text);
                cmd.Parameters.AddWithValue("pwd", txtPwd.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Updated !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtUsernm.Text != "" && txtPwd.Text != "")
            {
                con.Open();
                int id = Convert.ToInt32(txtId.Text);
                string query = "delete from userManagement where id='" + id + "'";
                cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void userManagement_Load(object sender, EventArgs e)
        {
            loadData();
            txtEmail.Focus();
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dgr = dataGridView1.Rows[index];
            txtId.Text = dgr.Cells[0].Value.ToString();
            txtEmail.Text = dgr.Cells[3].Value.ToString();
            txtUsernm.Text = dgr.Cells[5].Value.ToString();
            txtPwd.Text = dgr.Cells[6].Value.ToString();
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

        private void btnVehicleMng2_Click(object sender, EventArgs e)
        {
            carManagement cr = new carManagement();
            this.Hide();
            cr.ShowDialog();
            this.Close();
        }

        private void btnRentalMng2_Click(object sender, EventArgs e)
        {
            rentalManagement rm = new rentalManagement();
            this.Hide();
            rm.ShowDialog();
            this.Close();
        }

        private void btnUserMng2_Click(object sender, EventArgs e)
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

        /*  btnRentalMng2 Hover */
        private void btnRentalMng2_MouseEnter(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void btnRentalMng2_MouseLeave(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        /*  btnUserMng2 Hover */
        private void btnUserMng2_MouseEnter(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void btnUserMng2_MouseLeave(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            this.Hide();
            ad.ShowDialog();
            this.Close();
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
