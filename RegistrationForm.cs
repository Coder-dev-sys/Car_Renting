using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
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
            if (txtFullName.Text == "" || txtAddress.Text == "" || txtMobileNo.Text == "" || txtPwd.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Fill All Input Box !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginForm fm = new LoginForm();
                this.Hide();
                fm.ShowDialog();
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPwd.Clear();
            txtMobileNo.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            txtConfPwd.Clear();
        }
    }
}
