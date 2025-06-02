using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class CarManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;

        public CarManagement()
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=database1;Integrated Security=True;Multiple Active Result Sets=True;Encrypt=False");

            CenterGroupBox();
            this.Resize += (s, e) => CenterGroupBox();
        }
        private void CenterGroupBox()
        {
            // Horizontally position
            int spaceBetween = 50;

            // Calculate total width of both controls + gap
            int totalWidth = groupBox1.Width + dataGridView1.Width + spaceBetween;

            // Start X to center them as a unit
            int startX = (this.ClientSize.Width - totalWidth) / 2;

            groupBox1.Left = startX;
            dataGridView1.Left = groupBox1.Right + spaceBetween;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;

            // Vertically center
            groupBox1.Top = (this.ClientSize.Height + groupBox1.Height) / 6;
            dataGridView1.Top = (this.ClientSize.Height + groupBox1.Height) / 6;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 11;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtBrand.Text != "" || txtModel.Text !="" || txtRent.Text !="")
            {
                con.Open();
                string qry = "insert into carManagement (brand,model,rentPerDay,availability) values (@brand,@model,@rentPerDay,@availability)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("model", txtModel.Text);
                cmd.Parameters.AddWithValue("rentPerDay", txtRent.Text);
                cmd.Parameters.AddWithValue("availability", chkAvailability.Text);
                int i= cmd.ExecuteNonQuery();
                if (i==1)
                {
                    MessageBox.Show("Vehicle Added Successfully");
                }
                con.Close();
                clearData();
            }
            else
            {
                MessageBox.Show("Vehicle Not Added");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void clearData()
        {
            txtBrand.Clear();
            txtModel.Clear();
            txtRent.Clear();
            chkAvailability.Items.Clear();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard fm = new AdminDashboard();
            this.Hide();
            fm.ShowDialog();
            this.Close();
        }

        private void loadData()
        {
            con.Open();
            string qry = "select * from carManagement";
            cmd = new SqlCommand(qry, con);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void CarManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}