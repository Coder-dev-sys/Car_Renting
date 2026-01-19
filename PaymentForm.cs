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
    public partial class PaymentForm : Form
    {
        SqlConnection con;
        private int bookingId;
        private string username;
        
       
       public PaymentForm(int bookingId, string username)
        {
            InitializeComponent();

            // Connection With DB
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False");
            this.bookingId = bookingId;
            this.username = username;
            lblTitle.Text = "Payment For Booking ID " + bookingId;
            GBUPI.Visible = false;
            gbcard.Visible = false;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // Simple Validation
            if(string.IsNullOrWhiteSpace(txtCardNumber.Text)||string.IsNullOrWhiteSpace(txtCardName.Text)||string.IsNullOrWhiteSpace(txtExpiry.Text)||string.IsNullOrWhiteSpace(txtCvv.Text))
            {
                lblStatus.Text = "Please Fill In All Details !";
                return;
            }
            try 
            {
                string updateQuery = "update rentalManagement set PaymentStatus='Paid' where Id=@id and username=@username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con)) 
                {
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Text = "Payment Successful !";
                btnPay.Enabled = false;

                Application.DoEvents();
                System.Threading.Thread.Sleep(600);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
               // lblStatus.Text = "Payment Faild : " + ex.Message;
                lblStatus.Text =ex.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupi_click(object sender, EventArgs e)
        {
            GBUPI.Visible = false;
            gbcard.Visible = false;
            GBUPI.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbcard.Visible = false;
            GBUPI.Visible=false;
            gbcard.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Simple Validation
            if (string.IsNullOrWhiteSpace(txtref.Text))
            {
                lblStatus.Text = "Please Fill In All Details !";
                return;
            }
            try
            {
                string updateQuery = "update rentalManagement set PaymentStatus='Paid' where Id=@id and username=@username";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.Parameters.AddWithValue("@username", username);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                lblsuss.Visible = true;
                btnPay.Enabled = false;

                Application.DoEvents();
                System.Threading.Thread.Sleep(600);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                // lblStatus.Text = "Payment Faild : " + ex.Message;
                lblStatus.Text = ex.Message;
            }
        }
    }
}
