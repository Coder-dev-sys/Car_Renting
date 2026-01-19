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
using System.IO;

namespace final
{
    public partial class booking : Form
    {
        private string selectedcarmodel = null;
        private decimal selectedcarrentprice = 0;
        private Panel selectedcarpanel = null;
        private int totaldays = 0;
        private decimal totalbilling1 = 0;
        private string username;
        private Panel panelmybooking = null;
        private string selectedcartype = null;
        public booking(string username)
        {
            InitializeComponent();
            this.username = username;
            //centergroupbox();
           // this.Resize += (s, e) => centergroupbox();
            lblusername.Text = "WELCOME, " + username + " ! ";
        }

        private void resetbookingstate()
        {
            selectedcarmodel = null;
            selectedcarrentprice = 0;
            selectedcarpanel = null;
            totaldays = 0;
            totalbilling1 = 0;
            totaldayslbl.Text = " ";
            carpanel.Controls.Clear();
            panelinvoice.Controls.Clear();
            panelinvoice.Visible = false;
            if (panelmybooking != null)
                panelmybooking.Visible = false;

        }
        private void seden_Click(object sender, EventArgs e)
        {
            if (panelmybooking != null)
                panelmybooking.Visible = false;
            resetbookingstate();
            selectedcartype = "Sedan";
            groupBox2.Visible = true;
        }
        private void suv_Click(object sender, EventArgs e)
        {
            if (panelmybooking != null)
                panelmybooking.Visible = false;
            resetbookingstate();
            selectedcartype = "SUV";
            groupBox2.Visible = true;
        }

        private void luxury_Click(object sender, EventArgs e)
        {
            if (panelmybooking != null)
                panelmybooking.Visible = false;
            resetbookingstate();
            selectedcartype = "Luxury";
            groupBox2.Visible = true;
        }

        private void events_Click(object sender, EventArgs e)
        {
            if (panelmybooking != null)
                panelmybooking.Visible = false;
            resetbookingstate();
            selectedcartype = "Event";
            groupBox2.Visible = true;
        }

        private void pickdrop_Click(object sender, EventArgs e)
        {
            if (panelmybooking != null)
                panelmybooking.Visible = false;
            resetbookingstate();
            selectedcartype = "Pick-Drop";
            groupBox2.Visible = true;
        }

        private void btn_date_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedcartype))
            {
                MessageBox.Show("PLEASE SELECT A CAR TYPE FIRST...");
                return;
            }
            showcarselecetion(selectedcartype);
        }
        private void showcarselecetion(string CarType)
        {
            groupBox2.Visible = true;
            DateTime fromdat = fromdate.Value.Date;
            DateTime todat = todate.Value.Date;
            totaldays = (todat - fromdat).Days + 1;
            if (totaldays < 1)
            {
                totaldayslbl.Text = "INVALID DATE RANGE";
                carpanel.Visible = false;
                return;
            }
            else
            {
                totaldayslbl.Text = totaldays.ToString() + " DAYS";
            }
            carpanel.Visible = true;
            carpanel.Controls.Clear();
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False";
            string query;
            SqlCommand cmd;
            query = "SELECT * from CarManagement Where Type=@Type and availability=@Available";
            cmd = new SqlCommand(query);
            string Available = Available1.Text;
            cmd.Parameters.AddWithValue("@Type", CarType);
            cmd.Parameters.AddWithValue("@Available", Available);
            carpanel.Visible = true;
            int yoffset = 20;
            int panelheight = 120;
            int panelspacing = 15;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                cmd.Connection = conn;
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    bool hasRows = false;
                    while (reader.Read())
                    {
                        hasRows = true;
                        Panel carPanel = new Panel();
                        carPanel.BackColor = Color.FromArgb(240, 248, 255);
                        carPanel.BorderStyle = BorderStyle.FixedSingle;
                        carPanel.Size = new Size(carpanel.Width - 40, panelheight);
                        carPanel.Location = new Point(10, yoffset);
                        carPanel.Cursor = Cursors.Hand;

                        //car name
                        Label lblname = new Label();
                        lblname.Text = "Name : " + reader["brand"].ToString();
                        lblname.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblname.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                        //lblname.Location = new Point(20, 15);
                        lblname.Location = new Point(205, 15);
                        lblname.AutoSize = true;
                        carPanel.Controls.Add(lblname);
                        
                        //car model
                        Label lblmodel = new Label();
                        lblmodel.Text = "Model : " + reader["Model"].ToString();
                        lblmodel.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblmodel.ForeColor = Color.Black;
                        //lblmodel.Location = new Point(20, 50);
                        lblmodel.Location = new Point(205, 47);
                        lblmodel.AutoSize = true;
                        carPanel.Controls.Add(lblmodel);

                        //car price
                        Label lblprice = new Label();
                        lblprice.Text = "Price : " + Convert.ToDecimal(reader["rentPerDay"]).ToString("N2");
                        lblprice.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblprice.ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
                        //lblprice.Location = new Point(20, 80);
                        lblprice.Location = new Point(205, 80);
                        lblprice.AutoSize = true;
                        carPanel.Controls.Add(lblprice);

                        //car Image
                        string imagepath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null;
                        PictureBox picturebox1 = new PictureBox();
                        picturebox1.Size = new Size(160, 100);
                        picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                        //picturebox1.Location = new Point(carpanel.Width - 199, 27);
                        picturebox1.Location = new Point(20, 10);
                        picturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (File.Exists(imagepath))
                        {
                            picturebox1.Image = Image.FromFile(imagepath);
                        }
                        carPanel.Controls.Add(picturebox1);

                        //store car info in 
                        carPanel.Tag = new
                        {
                            Model = reader["Model"].ToString(),
                            RentPrice = Convert.ToDecimal(reader["rentPerDay"])
                        };

                        //for selection
                        carPanel.Click += carpanel_Click;
                        foreach (Control ctrl in carPanel.Controls)
                        {
                            ctrl.Click += (s, ev) => carpanel_Click(carPanel, ev);
                        }
                        carpanel.Controls.Add(carPanel);
                        yoffset += panelheight + panelspacing;
                    }
                    if (!hasRows)
                    {
                        Label lblnocar = new Label();
                        lblnocar.Text = "NO CAR FOUND";
                        lblnocar.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                        lblnocar.ForeColor = Color.Red;
                        lblnocar.Location = new Point(20, 50);
                        lblnocar.AutoSize = true;
                        carpanel.Controls.Add(lblnocar);
                    }
                    else
                    {
                        Button btnbooknow = new Button
                        {
                            Text = "Book Now",
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.White,
                            BackColor = Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219))))),
                            Size = new Size(120, 40),
                            Location = new Point(carpanel.Width - 150, yoffset + 20)
                        };
                        carpanel.Controls.Add(btnbooknow);
                        btnbooknow.Click += btnbooknow_click;
                        btnbooknow.Enabled = true;
                        panelinvoice.Visible = true;
                    }
                }

            }
        }
        private void btnbooknow_click(object sender, EventArgs e)
        {
            if (selectedcarpanel == null)
            {
                MessageBox.Show("PLEASE SELECT A CAR FIRST");
                return;
            }

            if (totaldays < 1)
            {
                MessageBox.Show("PLEASE SELECT A VALID DATE RANGE ");
                return;
            }
            //calculate bill
            this.totalbilling1 = selectedcarrentprice * totaldays;

            //show invoice in panelinvoice
            Label lblinvoicetitle = new Label
            {
                Text = "INVOICE",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                Location = new Point(100, 20),
                AutoSize = true
            };
            panelinvoice.Controls.Add(lblinvoicetitle);

            Label lblmodel = new Label
            {
                Text = "CAR MODEL : " + selectedcarmodel,
                Font = new Font("Segoe UI", 12),
                Location = new Point(100, 60),
                AutoSize = true
            };
            panelinvoice.Controls.Add(lblmodel);

            Label lbldays = new Label
            {
                Text = "TOTAL DAYS : " + totaldays,
                Font = new Font("Segoe UI", 12),
                Location = new Point(100, 90),
                AutoSize = true
            };
            panelinvoice.Controls.Add(lbldays);

            Label lblrent = new Label
            {
                Text = "RENT PER DAY : " + selectedcarrentprice.ToString("N2"),
                Font = new Font("Segoe UI", 12),
                Location = new Point(100, 120),
                AutoSize = true
            };
            panelinvoice.Controls.Add(lblrent);

            Label lbltotal = new Label
            {
                Text = "TOTAL BILLING : " + totalbilling1,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(100, 150),
                AutoSize = true
            };
            panelinvoice.Controls.Add(lbltotal);

            Button btnsubmit = new Button
            {
                Text = "SUBMIT BOOKING",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.DarkSlateBlue,
                Size = new Size(150, 40),
                Location = new Point(100, 200)
            };
            btnsubmit.Click += btnsubmit_Click;
            panelinvoice.Controls.Add(btnsubmit);

        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            //store in database
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False";
            string qrery = "INSERT INTO rentalManagement (CarModel,TotalDays,FromDate,ToDate,RentPerDay,TotalBilling,username,PaymentStatus) VALUES(@CarModel,@TotalDays,@FromDate,@ToDate,@RentPerDay,@TotalBilling,@username,@PaymentStatus)";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand(qrery, conn))
            {
                cmd.Parameters.AddWithValue("@CarModel", selectedcarmodel);
                cmd.Parameters.AddWithValue("@TotalDays", totaldays);
                cmd.Parameters.AddWithValue("@FromDate", fromdate.Value.Date);
                cmd.Parameters.AddWithValue("@ToDate", todate.Value.Date);
                cmd.Parameters.AddWithValue("@RentPerDay", selectedcarrentprice);
                cmd.Parameters.AddWithValue("@TotalBilling", totalbilling1);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@PaymentStatus", "Pending");
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("BOOKING SUBMITTED SUCCESSFULLY !!");
            panelinvoice.Visible = false;
            carpanel.Visible = false;
            groupBox2.Visible = false;
            selectedcarmodel = null;
            selectedcarrentprice = 0;
            selectedcarpanel = null;
            totaldays = 0;
            totalbilling1 = 0;
            fromdate.Value = DateTime.Today;
            todate.Value = DateTime.Today;
            totaldayslbl.Text = " ";
            carpanel.Controls.Clear();

        }
        private void carpanel_Click(object sender, EventArgs e)
        {
            if (selectedcarpanel != null)
            {
                selectedcarpanel.BackColor = Color.FromArgb(240, 248, 255);
            }
            selectedcarpanel = sender as Panel;
            selectedcarpanel.BackColor = Color.LightSkyBlue;

            dynamic tag = selectedcarpanel.Tag;
            selectedcarmodel = tag.Model;
            selectedcarrentprice = tag.RentPrice;
        }

        private void mybooking_Click(object sender, EventArgs e)
        {
            panelinvoice.Visible = false;
            carpanel.Visible = false;
            groupBox2.Visible = false;

            //prepare or clear the booking panel
            if (panelmybooking == null)
            {
                panelmybooking = new Panel
                {
                    Name = "panelmybookings",
                    AutoScroll = true,
                    BackColor= Color.White,
                    Size = new Size(carpanel.Width, carpanel.Height),
                    Location = carpanel.Location,
                    BorderStyle = BorderStyle.None
                };
                this.Controls.Add(panelmybooking);
                panelmybooking.BringToFront();
            }
            panelmybooking.Controls.Clear();
            panelmybooking.Visible = true;

            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False";
            string query = "SELECT Id,CarModel,TotalDays,FromDate,ToDate,RentPerDay,TotalBilling,PaymentStatus from rentalManagement where username=@username";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int yoffset = 10;
                    int panelheight = 120;
                    int panelspacing = 15;
                    bool hasrows = false;

                    while (reader.Read())
                    {
                        hasrows = true;
                        Panel bookingpanel = new Panel
                        {
                            BackColor = Color.FromArgb(240, 248, 255),
                            BorderStyle = BorderStyle.FixedSingle,
                            Size = new Size(panelmybooking.Width - 40, panelheight),
                            Location = new Point(20, yoffset)
                        };

                        //car model
                        Label lblmodel = new Label
                        {
                            Text = "Car Model : " + (reader["CarModel"] != DBNull.Value ? reader["CarModel"].ToString() : ""),
                            Font = new Font("Segoe UI", 14, FontStyle.Bold),
                            ForeColor = Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80))))),
                            Location = new Point(20, 15),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lblmodel);

                        //DATE
                        DateTime fromdate = reader["FromDate"] != DBNull.Value ? Convert.ToDateTime(reader["FromDate"]) : DateTime.MinValue;
                        DateTime todate = reader["ToDate"] != DBNull.Value ? Convert.ToDateTime(reader["ToDate"]) : DateTime.MinValue;
                        Label lblDates = new Label
                        {
                            Text="FROM : "+fromdate.ToString("dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture)+" to : "+todate.ToString("dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.Black,
                            Location = new Point(20, 50),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lblDates);

                        //TOTAL DAYS
                        Label lbldays = new Label
                        {
                            Text = "Total Days : " + (reader["TotalDays"] != DBNull.Value ? reader["TotalDays"].ToString() : ""),
                            Font = new Font("Segoe UI", 12),
                            Location = new Point(300, 15),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lbldays);

                        //rent per day
                        Label lblrent = new Label
                        {
                            Text = "Rent/Day : " + (reader["RentPerDay"] != DBNull.Value ? Convert.ToDecimal(reader["RentPerDay"]).ToString("N2") : "0.00"),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.DarkGreen,
                            Location = new Point(20, 80),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lblrent);

                        //Total Billing
                        Label lbltotal = new Label
                        {
                            Text = "Total : " + (reader["TotalBilling"] != DBNull.Value ? Convert.ToDecimal(reader["TotalBilling"]).ToString("N2") : "0.00"),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.DarkGreen,
                            Location = new Point(200, 80),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lbltotal);

                        //payment status
                        string paymentstatus = reader["PaymentStatus"] != DBNull.Value ? reader["PaymentStatus"].ToString().Trim() : "";
                        bool ispaid = string.Equals(paymentstatus, "Paid", StringComparison.OrdinalIgnoreCase);

                        //payment status label
                        Label lblpaymentstatus = new Label
                        {
                            Text = ispaid ? "Payment Done" : "Pending",
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = ispaid ? Color.MediumSeaGreen : Color.OrangeRed,
                            Location = new Point(500, 15),
                            AutoSize = true
                        };
                        bookingpanel.Controls.Add(lblpaymentstatus);

                        //pay now butoon
                        Button btnpaynow = new Button
                        {
                            Text = "PAY NOW",
                            BackColor = Color.MediumSeaGreen,
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Size = new Size(100, 35),
                            Location = new Point(500, 45),
                            Tag = reader["Id"]
                        };
                        if (ispaid)
                        {
                            btnpaynow.Enabled = false;
                            btnpaynow.Text = "PAID";
                            btnpaynow.BackColor = Color.Gray;
                        }
                        btnpaynow.Click += btnpaynow_click;
                        bookingpanel.Controls.Add(btnpaynow);

                        //cancel button
                        Button btncancel = new Button
                        {
                            Text = "CANCEL",
                            BackColor = Color.IndianRed,
                            ForeColor = Color.White,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Size = new Size(100, 35),
                            Location = new Point(620, 45),
                            Tag = reader["Id"]
                        };
                        btncancel.Click += btncancel_click;
                        bookingpanel.Controls.Add(btncancel);

                        panelmybooking.Controls.Add(bookingpanel);
                        yoffset += panelheight + panelspacing;
                    }
                    if (!hasrows)
                    {
                        Label lblnobooking = new Label
                        {
                            Text = "NO BOOKING FOUND",
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.Gray,
                            Location = new Point(20, 30),
                            AutoSize = true
                        };
                        panelmybooking.Controls.Add(lblnobooking);
                    }
                }
            }
        }

        private void btncancel_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int bookingId = Convert.ToInt32(btn.Tag);

            var result = MessageBox.Show("ARE YOU SURE YOU WANT TO CANCEL THIS BOOKING ?", "CONFIRM CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False";
                string deletequery = "DELETE from rentalManagement where Id=@id and username=@username";
                using (SqlConnection conn = new SqlConnection(connectionstring))
                using (SqlCommand cmd = new SqlCommand(deletequery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookingId);
                    cmd.Parameters.AddWithValue("@username", username);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("BOOKING CANCELLED ", "CANCELLED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mybooking_Click(null, null);
            }
        }
        private void btnpaynow_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int bookingId = Convert.ToInt32(btn.Tag);
            PaymentForm paymentform = new PaymentForm(bookingId, username);
            this.Hide();
            this.Close();
            if (paymentform.ShowDialog() == DialogResult.OK)
            {
                mybooking_Click(null, null);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
