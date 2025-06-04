namespace WinFormsApp1
{
    partial class carRent
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            lblBill = new Label();
            lblDays = new Label();
            label18 = new Label();
            label17 = new Label();
            label15 = new Label();
            label14 = new Label();
            toCarDate = new DateTimePicker();
            fromCarDate = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnBack = new Button();
            btnBook = new Button();
            txtRent = new TextBox();
            txtModel = new TextBox();
            label10 = new Label();
            label9 = new Label();
            txtBrand = new TextBox();
            label13 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(245, 101);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1859, 292);
            panel1.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label7.ForeColor = Color.Beige;
            label7.Location = new Point(711, 89);
            label7.Name = "label7";
            label7.Size = new Size(410, 89);
            label7.TabIndex = 0;
            label7.Text = "Car Booking";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(lblBill);
            groupBox1.Controls.Add(lblDays);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(toCarDate);
            groupBox1.Controls.Add(fromCarDate);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnBook);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 530);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 1432);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // lblBill
            // 
            lblBill.AutoSize = true;
            lblBill.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblBill.Location = new Point(585, 998);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(0, 49);
            lblBill.TabIndex = 54;
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblDays.Location = new Point(585, 856);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(0, 49);
            lblDays.TabIndex = 53;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(470, 998);
            label18.Name = "label18";
            label18.Size = new Size(37, 49);
            label18.TabIndex = 52;
            label18.Text = ":";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(470, 856);
            label17.Name = "label17";
            label17.Size = new Size(37, 49);
            label17.TabIndex = 51;
            label17.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label15.Location = new Point(63, 998);
            label15.Name = "label15";
            label15.Size = new Size(82, 49);
            label15.TabIndex = 50;
            label15.Text = "Bill";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label14.Location = new Point(63, 856);
            label14.Name = "label14";
            label14.Size = new Size(222, 49);
            label14.TabIndex = 49;
            label14.Text = "Total Days ";
            // 
            // toCarDate
            // 
            toCarDate.Font = new Font("Trebuchet MS", 11.1F);
            toCarDate.Format = DateTimePickerFormat.Short;
            toCarDate.Location = new Point(585, 713);
            toCarDate.Name = "toCarDate";
            toCarDate.Size = new Size(484, 50);
            toCarDate.TabIndex = 48;
            toCarDate.ValueChanged += CalculateBookingDays;
            // 
            // fromCarDate
            // 
            fromCarDate.Font = new Font("Trebuchet MS", 11.1F);
            fromCarDate.Format = DateTimePickerFormat.Short;
            fromCarDate.Location = new Point(585, 596);
            fromCarDate.MinDate = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            fromCarDate.Name = "fromCarDate";
            fromCarDate.Size = new Size(484, 50);
            fromCarDate.TabIndex = 47;
            fromCarDate.Value = new DateTime(2025, 6, 3, 16, 46, 52, 0);
            fromCarDate.ValueChanged += CalculateBookingDays;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(470, 713);
            label12.Name = "label12";
            label12.Size = new Size(37, 49);
            label12.TabIndex = 46;
            label12.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(470, 596);
            label11.Name = "label11";
            label11.Size = new Size(37, 49);
            label11.TabIndex = 45;
            label11.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label8.Location = new Point(63, 596);
            label8.Name = "label8";
            label8.Size = new Size(217, 49);
            label8.TabIndex = 44;
            label8.Text = "From Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 713);
            label5.Name = "label5";
            label5.Size = new Size(193, 49);
            label5.TabIndex = 43;
            label5.Text = "Due Date";
            // 
            // txtId
            // 
            txtId.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(585, 80);
            txtId.Margin = new Padding(75, 115, 0, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(484, 50);
            txtId.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(470, 81);
            label6.Name = "label6";
            label6.Size = new Size(37, 49);
            label6.TabIndex = 41;
            label6.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 81);
            label1.Name = "label1";
            label1.Size = new Size(56, 49);
            label1.TabIndex = 40;
            label1.Text = "Id";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Trebuchet MS", 11.1F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(641, 1226);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(326, 130);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.FromArgb(63, 81, 181);
            btnBook.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBook.ForeColor = Color.Beige;
            btnBook.Location = new Point(114, 1226);
            btnBook.Margin = new Padding(3, 4, 3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(326, 130);
            btnBook.TabIndex = 36;
            btnBook.Text = "Book ";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // txtRent
            // 
            txtRent.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRent.Location = new Point(585, 467);
            txtRent.Margin = new Padding(75, 115, 0, 4);
            txtRent.Name = "txtRent";
            txtRent.ReadOnly = true;
            txtRent.Size = new Size(484, 50);
            txtRent.TabIndex = 32;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(585, 325);
            txtModel.Margin = new Padding(75, 115, 0, 4);
            txtModel.Name = "txtModel";
            txtModel.ReadOnly = true;
            txtModel.Size = new Size(484, 50);
            txtModel.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(470, 325);
            label10.Name = "label10";
            label10.Size = new Size(37, 49);
            label10.TabIndex = 27;
            label10.Text = ":";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(470, 197);
            label9.Name = "label9";
            label9.Size = new Size(37, 49);
            label9.TabIndex = 26;
            label9.Text = ":";
            // 
            // txtBrand
            // 
            txtBrand.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(585, 196);
            txtBrand.Margin = new Padding(75, 115, 0, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.ReadOnly = true;
            txtBrand.Size = new Size(484, 50);
            txtBrand.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(470, 467);
            label13.Name = "label13";
            label13.Size = new Size(37, 49);
            label13.TabIndex = 15;
            label13.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 197);
            label4.Name = "label4";
            label4.Size = new Size(142, 49);
            label4.TabIndex = 3;
            label4.Text = "Brand ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 467);
            label3.Name = "label3";
            label3.Size = new Size(274, 49);
            label3.TabIndex = 3;
            label3.Text = "Rent Per Day ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 325);
            label2.Name = "label2";
            label2.Size = new Size(145, 49);
            label2.TabIndex = 2;
            label2.Text = "Model ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(1173, 530);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1123, 1432);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // carRent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 2091);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "carRent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals - Booking";
            WindowState = FormWindowState.Maximized;
            Load += carRent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtId;
        private Label label6;
        private Label label1;
        private Button btnBack;
        private Button btnBook;
        private TextBox txtRent;
        private TextBox txtModel;
        private Label label10;
        private Label label9;
        private TextBox txtBrand;
        private Label label13;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker fromCarDate;
        private Label label12;
        private Label label11;
        private Label label8;
        private Label label5;
        private DateTimePicker toCarDate;
        private Label lblBill;
        private Label lblDays;
        private Label label18;
        private Label label17;
        private Label label15;
        private Label label14;
    }
}