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
using System.Data.Sql;

namespace final
{
    public partial class revenue : Form
    {
        SqlConnection con;
        public revenue()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
            InitializeComponent();
        }
        private int getRevenue()
        {
            int count = 0;
            string qry = "select sum(TotalBilling) from rentalManagement where PaymentStatus='Paid'";
            SqlCommand cmd = new SqlCommand(qry, con);
            con.Open();
            count = (int)cmd.ExecuteScalar();
            con.Close();
            return count;
        }
        private void revenue_Click(object sender, EventArgs e)
        {
            revenue rev= new revenue();
            this.Hide();
            rev.ShowDialog();
            this.Close();
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

        private void revenue_Load(object sender, EventArgs e)
        {
            revbtn.Text=Convert.ToString(getRevenue());

            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }
        private void btnVehicleMng2_MouseEnter(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void btnVehicleMng2_MouseLeave(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        /*  btnRentalMng2 Hover */
        private void btnRentalMng2_MouseEnter(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void btnRentalMng2_MouseLeave(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        /*  btnUserMng2 Hover */
        private void btnUserMng2_MouseLeave(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
           label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        private void btnUserMng2_MouseEnter(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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

        /*  revenuebtn Hover */
        private void revenuebtn_MouseEnter(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void revenuebtn_MouseLeave(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void label9_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }  
    }
}
