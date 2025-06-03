using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public LoginForm()
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
            panel2.Top = (this.ClientSize.Height - groupBox1.Height) / 5;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPwd.Text != "")
            {
                if (txtUsername.Text == "admin" && txtPwd.Text == "admin123@")
                {
                    AdminDashboard adm = new AdminDashboard();
                    this.Hide();
                    adm.ShowDialog();
                    this.Close();
                }
                else
                {
                    con.Open();

                    // User Exist or not
                    string checkQuery = "SELECT COUNT(*) FROM userManagement WHERE userName = @userName and password = @pwd";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                    checkCmd.Parameters.AddWithValue("@userName", txtUsername.Text);
                    checkCmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        string loggedInUsername = txtUsername.Text;
                        carRent adm = new carRent(loggedInUsername);
                        this.Hide();
                        adm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User Doesn't Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Both Input Box !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPwd.Clear();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm fm = new RegistrationForm();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }
    }
}
