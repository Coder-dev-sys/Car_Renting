using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public AdminDashboard()
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
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;

            // Vertically center
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 5;
        }

        // Row Counter UDFs
        private int GetCarCount()
        {
            int count = 0;
            string qry = "SELECT COUNT(*) FROM carManagement";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }
        private int GetCustCount()
        {
            int count = 0;
            string qry = "SELECT COUNT(*) FROM rentalManagement";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }
        private int GetUserCount()
        {
            int count = 0;
            string qry = "SELECT COUNT(*) FROM userManagement";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }
        private void btnCarMng_Click(object sender, EventArgs e)
        {
            CarManagement cm = new CarManagement();
            this.Hide();
            cm.ShowDialog();
            this.Close();
        }

        private void btnRentalMng_Click(object sender, EventArgs e)
        {
            RentalManagenent cm = new RentalManagenent();
            this.Hide();
            cm.ShowDialog();
            this.Close();
        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {
            UserManagement cm = new UserManagement();
            this.Hide();
            cm.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lfm = new LoginForm();
            this.Hide();
            lfm.ShowDialog();
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            btnCarMng.Text = $"{GetCarCount()}";
            btnUserMng.Text = $"{GetUserCount()}";
            btnRentalMng.Text= $"{GetCustCount()}";
        }
    }
}
