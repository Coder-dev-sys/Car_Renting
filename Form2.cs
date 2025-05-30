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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "" && txtAddress.Text == "" && txtMobileNo.Text == "" && txtPwd.Text == "" && txtUsername.Text == "")
            {
                MessageBox.Show("Fill All Input Box !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form1 fm = new Form1();
                fm.Show();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPwd.Clear();
            txtMobileNo.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
        }
    }
}
