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
    public partial class register : Form
    {
        SqlConnection con;
        public register()
        {
            InitializeComponent(); 
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && richTextBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                con.Open();
                String query = "select count(*) from userManagement where userName=@username or password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox4.Text);
                cmd.Parameters.AddWithValue("@password", textBox5.Text);
                int exists = (int)cmd.ExecuteScalar();
                if (exists > 0)
                {
                    MessageBox.Show("User Already Exists !", "Duplication Found !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    con.Close();
                    return;
                }
                try
                { 
                    // Data Insertion
                String qry = "insert into userManagement(fullName,mobileNo,email,address,userName,password) values (@fullname,@mobileno,@email,@address,@username,@password)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("fullname", textBox1.Text);
                cmd.Parameters.AddWithValue("mobileno", textBox2.Text);
                cmd.Parameters.AddWithValue("email", textBox3.Text);
                cmd.Parameters.AddWithValue("address", richTextBox1.Text);
                cmd.Parameters.AddWithValue("username", textBox4.Text);
                cmd.Parameters.AddWithValue("password", textBox5.Text);
                int i = cmd.ExecuteNonQuery();

                if (i == 1)
                {
                    MessageBox.Show("Registered Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Not Registered !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cleardata();
                login lg = new login();
                this.Hide();
                lg.ShowDialog();
                this.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Please Enter Valid Mobile NO", "Error");
                }
            }
            else
            {
                MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleardata()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            cleardata();
        }

        private void backbtn_Click_1(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void register_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        /*  signupbtn Hover */
        private void signupbtn_MouseEnter(object sender, EventArgs e)
        {
            signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void signupbtn_MouseLeave(object sender, EventArgs e)
        {
            signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  reset_btn Hover */
        private void reset_btn_MouseEnter(object sender, EventArgs e)
        {
            reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void reset_btn_MouseLeave(object sender, EventArgs e)
        {
            reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  lblLogin Hover */
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }
    }
}
