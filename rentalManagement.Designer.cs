namespace final
{
    partial class rentalManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblnorental = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtRentPerDay = new System.Windows.Forms.TextBox();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.revenuebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUserMng2 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRentalMng2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.btnVehicleMng2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBack = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(396, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 481);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.lblnorental);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtUsername);
            this.groupBox2.Controls.Add(this.txtCarModel);
            this.groupBox2.Controls.Add(this.txtRentPerDay);
            this.groupBox2.Controls.Add(this.fromDate);
            this.groupBox2.Controls.Add(this.toDate);
            this.groupBox2.Controls.Add(this.txtBill);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(11, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 428);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // lblnorental
            // 
            this.lblnorental.AutoSize = true;
            this.lblnorental.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblnorental.ForeColor = System.Drawing.Color.Red;
            this.lblnorental.Location = new System.Drawing.Point(513, 186);
            this.lblnorental.Name = "lblnorental";
            this.lblnorental.Size = new System.Drawing.Size(180, 30);
            this.lblnorental.TabIndex = 34;
            this.lblnorental.Text = "No Rental Found";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(195, 378);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 40);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(361, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(474, 365);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseLeave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label20.Location = new System.Drawing.Point(15, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(188, 25);
            this.label20.TabIndex = 30;
            this.label20.Text = "+ Add / Edit Rentals";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(40, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(215, 29);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.Tag = "";
            this.txtUsername.Text = "Username";
            // 
            // txtCarModel
            // 
            this.txtCarModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarModel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtCarModel.ForeColor = System.Drawing.Color.Gray;
            this.txtCarModel.Location = new System.Drawing.Point(40, 122);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(215, 29);
            this.txtCarModel.TabIndex = 15;
            this.txtCarModel.Text = "Car Model";
            // 
            // txtRentPerDay
            // 
            this.txtRentPerDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentPerDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtRentPerDay.ForeColor = System.Drawing.Color.Gray;
            this.txtRentPerDay.Location = new System.Drawing.Point(40, 272);
            this.txtRentPerDay.Name = "txtRentPerDay";
            this.txtRentPerDay.Size = new System.Drawing.Size(215, 29);
            this.txtRentPerDay.TabIndex = 18;
            this.txtRentPerDay.Text = "Rent Per Day";
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.fromDate.Location = new System.Drawing.Point(40, 172);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(215, 29);
            this.fromDate.TabIndex = 16;
            this.fromDate.Value = new System.DateTime(2024, 1, 1, 5, 57, 0, 0);
            // 
            // toDate
            // 
            this.toDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.toDate.Location = new System.Drawing.Point(40, 222);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(215, 29);
            this.toDate.TabIndex = 17;
            this.toDate.Value = new System.DateTime(2024, 1, 2, 6, 35, 0, 0);
            // 
            // txtBill
            // 
            this.txtBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBill.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.txtBill.ForeColor = System.Drawing.Color.Gray;
            this.txtBill.Location = new System.Drawing.Point(40, 322);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(215, 29);
            this.txtBill.TabIndex = 19;
            this.txtBill.Text = "Rent Bill";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsert.Location = new System.Drawing.Point(20, 378);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(92, 40);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseEnter += new System.EventHandler(this.btnInsert_MouseEnter);
            this.btnInsert.MouseLeave += new System.EventHandler(this.btnInsert_MouseLeave);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(92, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(182, 23);
            this.txtId.TabIndex = 26;
            this.txtId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = ":";
            this.label8.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "ID";
            this.label1.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(637, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 40);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.btnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(755, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 40);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.revenuebtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnUserMng2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnRentalMng2);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.btnVehicleMng2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(77, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 588);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "💹";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // revenuebtn
            // 
            this.revenuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.revenuebtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.revenuebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.revenuebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.revenuebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.revenuebtn.Location = new System.Drawing.Point(12, 398);
            this.revenuebtn.Name = "revenuebtn";
            this.revenuebtn.Size = new System.Drawing.Size(284, 44);
            this.revenuebtn.TabIndex = 16;
            this.revenuebtn.Text = "Revenue";
            this.revenuebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.revenuebtn.UseVisualStyleBackColor = false;
            this.revenuebtn.Click += new System.EventHandler(this.revenuebtn_Click);
            this.revenuebtn.MouseEnter += new System.EventHandler(this.revenuebtn_MouseEnter);
            this.revenuebtn.MouseLeave += new System.EventHandler(this.revenuebtn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "👤";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Emoji", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(27, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 37);
            this.label16.TabIndex = 9;
            this.label16.Text = "⚙";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(28, 180);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 36);
            this.label17.TabIndex = 8;
            this.label17.Text = "🚗";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnUserMng2
            // 
            this.btnUserMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnUserMng2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUserMng2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserMng2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUserMng2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserMng2.Location = new System.Drawing.Point(12, 324);
            this.btnUserMng2.Name = "btnUserMng2";
            this.btnUserMng2.Size = new System.Drawing.Size(284, 44);
            this.btnUserMng2.TabIndex = 9;
            this.btnUserMng2.Text = "User Management";
            this.btnUserMng2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserMng2.UseVisualStyleBackColor = false;
            this.btnUserMng2.Click += new System.EventHandler(this.btnUserMng_Click);
            this.btnUserMng2.MouseEnter += new System.EventHandler(this.btnUserMng2_MouseEnter);
            this.btnUserMng2.MouseLeave += new System.EventHandler(this.btnUserMng2_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(43, 515);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 44);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.btnLogout_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.btnLogout_MouseLeave);
            // 
            // btnRentalMng2
            // 
            this.btnRentalMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRentalMng2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRentalMng2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRentalMng2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRentalMng2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRentalMng2.Location = new System.Drawing.Point(12, 249);
            this.btnRentalMng2.Name = "btnRentalMng2";
            this.btnRentalMng2.Size = new System.Drawing.Size(284, 44);
            this.btnRentalMng2.TabIndex = 8;
            this.btnRentalMng2.Text = "Rental Management";
            this.btnRentalMng2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRentalMng2.UseVisualStyleBackColor = false;
            this.btnRentalMng2.Click += new System.EventHandler(this.btnRentalMng_Click);
            this.btnRentalMng2.MouseEnter += new System.EventHandler(this.btnRentalMng2_MouseEnter);
            this.btnRentalMng2.MouseLeave += new System.EventHandler(this.btnRentalMng2_MouseLeave);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(108, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 30);
            this.label18.TabIndex = 0;
            this.label18.Text = "Car Rental System";
            // 
            // btnVehicleMng2
            // 
            this.btnVehicleMng2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnVehicleMng2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVehicleMng2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVehicleMng2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicleMng2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVehicleMng2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVehicleMng2.Location = new System.Drawing.Point(12, 178);
            this.btnVehicleMng2.Name = "btnVehicleMng2";
            this.btnVehicleMng2.Size = new System.Drawing.Size(284, 44);
            this.btnVehicleMng2.TabIndex = 7;
            this.btnVehicleMng2.Text = "Car Management";
            this.btnVehicleMng2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehicleMng2.UseVisualStyleBackColor = false;
            this.btnVehicleMng2.Click += new System.EventHandler(this.btnVehicleMng_Click);
            this.btnVehicleMng2.MouseEnter += new System.EventHandler(this.btnVehicleMng2_MouseEnter);
            this.btnVehicleMng2.MouseLeave += new System.EventHandler(this.btnVehicleMng2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::final.Properties.Resources.cardekho_new;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.lblBack);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(396, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(857, 101);
            this.panel2.TabIndex = 15;
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(31, 21);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(45, 47);
            this.lblBack.TabIndex = 14;
            this.lblBack.Text = "<";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // rentalManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1265, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "rentalManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rentalManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.TextBox txtRentPerDay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnUserMng2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRentalMng2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnVehicleMng2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblnorental;
        private System.Windows.Forms.Button revenuebtn;
        private System.Windows.Forms.Label label3;
    }
}