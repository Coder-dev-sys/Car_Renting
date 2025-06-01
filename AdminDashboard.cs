using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WinFormsApp1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            CenterGroupBox();
            this.Resize += (s, e) => CenterGroupBox();
        }
        private void CenterGroupBox()
        {
            // Horizontally center
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            btnLogout.Left = (this.ClientSize.Width - panel1.Width) / 2;

            // Vertically center
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 5;
            btnLogout.Top = (this.ClientSize.Height - btnLogout.Height) / 3;
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

        }

        private void btnUserMng_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerMng_Click(object sender, EventArgs e)
        {

        }

        private void btnTotalInccome_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lfm = new LoginForm();
            this.Hide();
            lfm.ShowDialog();
            this.Close();
        }
    }
}
