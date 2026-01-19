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
    public partial class login : Form
    {
        SqlConnection con;
        public login()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
        }

        private void btnlogin1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin123")
                {
                    adminDashboard ad = new adminDashboard();
                    this.Hide();
                    ad.ShowDialog();
                    this.Close();
                }
                else
                {
                    con.Open();
                    String query = "select count(*) from userManagement where userName=@username and password=@password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox2.Text);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        string username = textBox1.Text;
                        booking booking1 = new booking(username);
                        this.Hide();
                        booking1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User Doesn't Exists !", "Please Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter Info In Both Input Box !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void signup_Click_1(object sender, EventArgs e)
        {
            register reg = new register();
            this.Hide();
            reg.ShowDialog();
            this.Close();
        }

        /*  btnLogin Hover */
        private void btnlogin1_MouseEnter(object sender, EventArgs e)
        {
            btnlogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void btnlogin1_MouseLeave(object sender, EventArgs e)
        {
            btnlogin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  lblRegister Hover */
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }
    }
}
