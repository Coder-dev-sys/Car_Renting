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
    public partial class carManagement : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        OpenFileDialog dialog = new OpenFileDialog();
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Github Projects\Car Renting\WinFormsApp1\Database1.mdf;Integrated Security=True;Encrypt=False";
        public carManagement()
        {
            InitializeComponent();
            dgv1.AlternatingRowsDefaultCellStyle.BackColor=System.Drawing.Color.AliceBlue;
        }

        private void carManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadData();
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }
        private void clearData()
        {
            txtId.Text = "";
            txtCarBand.Text = "";
            txtCarModel.Text = "";
            txtRentPerDay.Text = "";
            chkAvailability.SelectedIndex = -1;
            chkType.SelectedIndex = -1;
            txtimagepath.Text = "";
            btnImg.BackgroundImage = null;
        }


        private void loadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                dgv1.Visible = true;
                lblnocars.Visible = false;
                string query = "select *from carManagement";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!dt.Columns.Contains("Image")) 
                    dt.Columns.Add("Image", typeof(System.Drawing.Image));
                if (dt.Rows.Count <= 0)
                {
                    dgv1.Visible = false;
                    lblnocars.Visible = true;
                }
                foreach (DataRow row in dt.Rows)
                {
                    string imgpath = row["ImagePath"].ToString();
                    if (!string.IsNullOrEmpty(imgpath) && System.IO.File.Exists(imgpath))
                    {
                        try
                        {
                            row["Image"] = System.Drawing.Image.FromFile(imgpath);
                        }
                        catch
                        {
                            row["Image"] = null;
                        }
                    }
                    else
                    {
                        row["Image"] = null;
                    }
                }
                dgv1.DataSource = dt;

                if (dgv1.Columns["Image"] != null)
                {
                    dgv1.Columns["Image"].HeaderText = "Image";
                    ((DataGridViewImageColumn)dgv1.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dgv1.Columns["Image"].Width = 80;
                }
                if (dgv1.Columns["ImagePath"] != null && dgv1.Columns["Id"] != null)
                {
                    dgv1.Columns["ImagePath"].Visible = false;
                    dgv1.Columns["Id"].Visible = false;
                }

                // Renaming Columns
                dgv1.Columns["brand"].HeaderText = "Brand";
                dgv1.Columns["model"].HeaderText = "Model";
                dgv1.Columns["rentPerDay"].HeaderText = "Rent/Day";
                dgv1.Columns["availability"].HeaderText = "Status";
                dgv1.Columns["type"].HeaderText = "Type";
                dgv1.Columns["ImagePath"].HeaderText = "Picture";
            }
        }

        private void btnUpImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files (*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtimagepath.Text = dialog.FileName;
                    btnImg.BackgroundImage = Image.FromFile(dialog.FileName);
                    btnImg.BackgroundImageLayout = ImageLayout.Stretch;
                    btnImg.Text = "";
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            adminDashboard ad = new adminDashboard();
            this.Hide();
            ad.ShowDialog();
            this.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dgr = dgv1.Rows[index];
                txtId.Text = dgr.Cells[0].Value.ToString();
                txtCarBand.Text = dgr.Cells[1].Value.ToString();
                txtCarModel.Text = dgr.Cells[2].Value.ToString();
                txtRentPerDay.Text = dgr.Cells[3].Value.ToString();
                chkAvailability.Text = dgr.Cells[4].Value.ToString();
                chkType.Text = dgr.Cells[5].Value.ToString();
                int hoveredRowIndex = -1;
                if (e.RowIndex >= 0 && e.RowIndex != hoveredRowIndex)
                {
                    hoveredRowIndex = e.RowIndex;
                    dgv1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                DataGridViewRow dgr = dgv1.Rows[index];
                txtId.Text = dgr.Cells[0].Value.ToString();
                txtCarBand.Text = dgr.Cells[1].Value.ToString();
                txtCarModel.Text = dgr.Cells[2].Value.ToString();
                txtRentPerDay.Text = dgr.Cells[3].Value.ToString();
                chkAvailability.Text = dgr.Cells[4].Value.ToString();
                chkType.Text = dgr.Cells[5].Value.ToString();
                txtimagepath.Text = dgr.Cells[6].Value.ToString();
                showimageonbutton(txtimagepath.Text);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void dgv1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int hoveredRowIndex = -1;
            if (e.RowIndex >= 0 && e.RowIndex != hoveredRowIndex)
            {
                hoveredRowIndex = e.RowIndex;
                dgv1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void dgv1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCarBand.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && chkAvailability.Text != "" && chkType.Text != "")
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    String imagePath = txtimagepath.Text;
                    // Duplication check
                    String query = "select count(*) from carManagement where brand=@brand and model=@model";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@brand", txtCarBand.Text);
                    cmd.Parameters.AddWithValue("@model", txtCarModel.Text);
                    int exists = (int)cmd.ExecuteScalar();
                    if (exists > 0)
                    {
                        MessageBox.Show("Vehicle Already Exists !", "Dulication Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                        return;
                    }

                    // Data Insertion

                    // 1. Picture
                    string destFolder = Path.Combine(Application.StartupPath, "CarImages");
                    if (!Directory.Exists(destFolder))
                        Directory.CreateDirectory(destFolder);
                    string destPath = Path.Combine(destFolder, Path.GetFileName(imagePath));
                    if (File.Exists(imagePath) && !File.Exists(destPath))
                        File.Copy(imagePath, destPath);

                    // 2. Data
                    String qry = "insert into carManagement(brand,model,rentPerDay,availability,type,ImagePath) values (@brand,@model,@rentPerDay,@availability,@type,@ImagePath)";
                    cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("brand", txtCarBand.Text);
                    cmd.Parameters.AddWithValue("model", txtCarModel.Text);
                    cmd.Parameters.AddWithValue("rentPerDay", txtRentPerDay.Text);
                    cmd.Parameters.AddWithValue("availability", chkAvailability.Text);
                    cmd.Parameters.AddWithValue("type", chkType.Text);
                    cmd.Parameters.AddWithValue("ImagePath", destPath);

                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Vehicle Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vehicle Not Added !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "jpg files (*.jpg)|*.jpg|png files(*.png)|*.png|All Files(*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtimagepath.Text = ofd.FileName;
                    showimageonbutton(ofd.FileName);
                }
            }
        }
        private void showimageonbutton(string imagepath)
        {
            if (!string.IsNullOrEmpty(imagepath) && System.IO.File.Exists(imagepath))
            {
                try
                {
                    if (btnImg.BackgroundImage != null)
                    {
                        btnImg.BackgroundImage.Dispose();
                        btnImg.BackgroundImage = null;
                    }
                    btnImg.BackgroundImage = System.Drawing.Image.FromFile(imagepath);
                    btnImg.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch
                {
                    btnImg.BackgroundImage = null;
                }
            }
            else
            {
                btnImg.BackgroundImage = null;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCarBand.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && chkAvailability.Text != "" && chkType.Text != "")
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    String imagePath = txtimagepath.Text;
                    string destFolder = Path.Combine(Application.StartupPath, "CarImages");
                    if (!Directory.Exists(destFolder))
                        Directory.CreateDirectory(destFolder);
                    string destPath = Path.Combine(destFolder, Path.GetFileName(imagePath));
                    if (File.Exists(imagePath) && !File.Exists(destPath))
                        File.Copy(imagePath, destPath);

                    // 2. Data
                    String qry = "update carManagement set brand=@brand,model=@model,rentPerDay=@rentPerDay,availability=@availability,type=@type,ImagePath=@img where Id=@id";
                    cmd = new SqlCommand(qry, con);
                    cmd.Parameters.AddWithValue("id", txtId.Text);
                    cmd.Parameters.AddWithValue("brand", txtCarBand.Text);
                    cmd.Parameters.AddWithValue("model", txtCarModel.Text);
                    cmd.Parameters.AddWithValue("rentPerDay", txtRentPerDay.Text);
                    cmd.Parameters.AddWithValue("availability", chkAvailability.Text);
                    cmd.Parameters.AddWithValue("type", chkType.Text);
                    cmd.Parameters.AddWithValue("img", destPath);

                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Vehicle Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vehicle Not Updated !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }
        }

        /*  btnVehicleMng2 Hover */
        private void btnVehicleMng2_MouseEnter(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
            label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(191)))));
        }

        private void btnVehicleMng2_MouseLeave(object sender, EventArgs e)
        {
            btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        /*  btnRentalMng2 Hover */
        private void btnRentalMng2_MouseEnter(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void btnRentalMng2_MouseLeave(object sender, EventArgs e)
        {
            btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        /*  btnUserMng2 Hover */
        private void btnUserMng2_MouseLeave(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
           label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }

        private void btnUserMng2_MouseEnter(object sender, EventArgs e)
        {
            btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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

        /*  btnInsert Hover */
        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            btnInsert.BackColor = System.Drawing.Color.Green;
        }

        private void btnInsert_MouseLeave(object sender, EventArgs e)
        {
            btnInsert.BackColor = System.Drawing.Color.ForestGreen;
        }

        /*  btnClear Hover */
        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        }

        /*  btnUpdate Hover */
        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
        }

        /*  btnDelete Hover */
        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = System.Drawing.Color.OrangeRed;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtCarBand.Text != "" && txtCarModel.Text != "" && txtRentPerDay.Text != "" && chkAvailability.Text != "" && chkType.Text != "")
                {
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    int id = Convert.ToInt32(txtId.Text);
                    string query = "delete from carManagement where Id='" + id + "'";
                    cmd = new SqlCommand(query, con);
                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                    if (i == 1)
                    {
                        MessageBox.Show("Vehicle Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vehicle Not Deleted !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Fill All Details !", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void dgv1_CellClick(object sender, EventArgs e)
        {

        }

        private void revenuebtn_Click(object sender, EventArgs e)
        {
            revenue rev = new revenue();
            this.Hide();
            rev.ShowDialog();
            this.Close();
        }

        private void revenuebtn_MouseEnter(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
        }

        private void revenuebtn_MouseLeave(object sender, EventArgs e)
        {
            revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
        }
    }
}
