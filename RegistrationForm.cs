using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public RegistrationForm()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True;Multiple Active Result Sets=True;Encrypt=False");

            CenterGroupBox();
            this.Resize += (s, e) => CenterGroupBox();
        }
        private void CenterGroupBox()
        {
            // Horizontally center
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            panel2.Left = (this.ClientSize.Width - groupBox1.Width) / 2;

            // Vertically center
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
            panel2.Top = (this.ClientSize.Height - groupBox1.Height) / 11;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text != "" && txtAddress.Text != "" && txtMobileNo.Text != "" && txtPwd.Text != "" || txtUsername.Text != "")
            {
                con.Open();

                // Duplication Check
                string checkQuery = "SELECT COUNT(*) FROM userManagement WHERE userName = @userName OR password = @password";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                checkCmd.Parameters.AddWithValue("@password", txtPwd.Text);
                int exists = (int)checkCmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("Username or Password already registered!", "Duplicate Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return; 
                }

                // Data Insertion 
                string qry = "insert into userManagement (fullName,mobileNo,address,userName,password) values (@fullName,@mobileNo,@address,@userName,@password)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("fullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("mobileNo", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("userName", txtUsername.Text);
                cmd.Parameters.AddWithValue("password", txtPwd.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (i == 1)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                clearData();

                // Redirecting To Login page
                LoginForm fm = new LoginForm();
                this.Hide();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill All Details !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearData()
        {
            txtUsername.Clear();
            txtPwd.Clear();
            txtMobileNo.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm fm = new LoginForm();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
