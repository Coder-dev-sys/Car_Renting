using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPwd.Text == "")
            {
                MessageBox.Show("Enter Both Input Box !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtUsername.Text == "admin" || txtPwd.Text=="admin123@")
            {
                AdminDashboard adm = new AdminDashboard();
                this.Hide();
                adm.ShowDialog();
                this.Close();
            }
            else
            {

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
