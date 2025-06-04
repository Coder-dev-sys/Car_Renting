using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class UserManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public UserManagement()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True;Multiple Active Result Sets=True;Encrypt=False");

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
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                con.Open();

                // Duplication Check
                string checkQuery = "SELECT COUNT(*) FROM userManagement WHERE userName = @userName and password = @pwd";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                checkCmd.Parameters.AddWithValue("@pwd", txtPassword.Text);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("User Already Exist !", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }

                // Data Insertion 
                string qry = "insert into userManagement (userName,password) values (@userName,@pwd)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("userName", txtUsername.Text);
                cmd.Parameters.AddWithValue("pwd", txtPassword.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                con.Open();
                cmd = new SqlCommand(("update userManagement set userName=@userName, password=@pwd where id=@id"), con);
                cmd.Parameters.AddWithValue("id", txtCustId.Text);
                cmd.Parameters.AddWithValue("userName", txtUsername.Text);
                cmd.Parameters.AddWithValue("pwd", txtPassword.Text);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                con.Open();
                int id = Convert.ToInt32(txtCustId.Text);
                string qry = "delete from userManagement where id='" + id + "'";
                cmd = new SqlCommand(qry, con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MessageBox.Show("User Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard fm = new AdminDashboard();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void clearData()
        {
            txtCustId.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void loadData()
        {
            con.Open();

            // Loading Data
            string qry = "select * from userManagement";
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            // Renaming Column Names
            dataGridView1.Columns["userName"].HeaderText = "Username";
            dataGridView1.Columns["fullName"].HeaderText = "Full Name";
            dataGridView1.Columns["mobileNo"].HeaderText = "Mobile No.";
            dataGridView1.Columns["address"].HeaderText = "Address";
            dataGridView1.Columns["password"].HeaderText = "Password";

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
            txtCustId.Text = dgr.Cells[0].Value.ToString();
            txtUsername.Text = dgr.Cells[4].Value.ToString();
            txtPassword.Text = dgr.Cells[5].Value.ToString();
        }
    }
}
