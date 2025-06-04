namespace WinFormsApp1
{
    partial class RentalManagenent
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
            panel1 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            toCarDate = new DateTimePicker();
            fromCarDate = new DateTimePicker();
            label3 = new Label();
            label6 = new Label();
            label14 = new Label();
            btnDelete = new Button();
            btnBack = new Button();
            btnInsert = new Button();
            txtRent = new TextBox();
            txtModel = new TextBox();
            txtId = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtCustname = new TextBox();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            panel1.Location = new Point(245, 66);
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
            label7.Location = new Point(576, 94);
            label7.Name = "label7";
            label7.Size = new Size(653, 89);
            label7.TabIndex = 0;
            label7.Text = "Rental Management";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(toCarDate);
            groupBox1.Controls.Add(fromCarDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCustname);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 1149);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // toCarDate
            // 
            toCarDate.Font = new Font("Trebuchet MS", 11.1F);
            toCarDate.Format = DateTimePickerFormat.Short;
            toCarDate.Location = new Point(585, 604);
            toCarDate.Name = "toCarDate";
            toCarDate.Size = new Size(484, 50);
            toCarDate.TabIndex = 54;
            // 
            // fromCarDate
            // 
            fromCarDate.Font = new Font("Trebuchet MS", 11.1F);
            fromCarDate.Format = DateTimePickerFormat.Short;
            fromCarDate.Location = new Point(585, 467);
            fromCarDate.MinDate = new DateTime(2025, 6, 3, 0, 0, 0, 0);
            fromCarDate.Name = "fromCarDate";
            fromCarDate.Size = new Size(484, 50);
            fromCarDate.TabIndex = 53;
            fromCarDate.Value = new DateTime(2025, 6, 3, 16, 46, 52, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(470, 604);
            label3.Name = "label3";
            label3.Size = new Size(37, 49);
            label3.TabIndex = 51;
            label3.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label6.Location = new Point(63, 467);
            label6.Name = "label6";
            label6.Size = new Size(246, 49);
            label6.TabIndex = 50;
            label6.Text = "From Date *";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label14.Location = new Point(63, 604);
            label14.Name = "label14";
            label14.Size = new Size(222, 49);
            label14.TabIndex = 49;
            label14.Text = "Due Date *";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(63, 81, 181);
            btnDelete.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Beige;
            btnDelete.Location = new Point(779, 981);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(326, 130);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Trebuchet MS", 11.1F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(392, 1018);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(345, 93);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(63, 81, 181);
            btnInsert.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.Beige;
            btnInsert.Location = new Point(15, 981);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(326, 130);
            btnInsert.TabIndex = 36;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtRent
            // 
            txtRent.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRent.Location = new Point(585, 753);
            txtRent.Margin = new Padding(75, 115, 0, 4);
            txtRent.Name = "txtRent";
            txtRent.Size = new Size(484, 50);
            txtRent.TabIndex = 32;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(585, 325);
            txtModel.Margin = new Padding(75, 115, 0, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(484, 50);
            txtModel.TabIndex = 31;
            // 
            // txtId
            // 
            txtId.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(585, 65);
            txtId.Margin = new Padding(75, 115, 0, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(484, 50);
            txtId.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(470, 753);
            label11.Name = "label11";
            label11.Size = new Size(37, 49);
            label11.TabIndex = 28;
            label11.Text = ":";
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(470, 66);
            label8.Name = "label8";
            label8.Size = new Size(37, 49);
            label8.TabIndex = 25;
            label8.Text = ":";
            // 
            // txtCustname
            // 
            txtCustname.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustname.Location = new Point(585, 196);
            txtCustname.Margin = new Padding(75, 115, 0, 4);
            txtCustname.Name = "txtCustname";
            txtCustname.Size = new Size(484, 50);
            txtCustname.TabIndex = 24;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 753);
            label5.Name = "label5";
            label5.Size = new Size(210, 49);
            label5.TabIndex = 4;
            label5.Text = "Rent Bill *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 197);
            label4.Name = "label4";
            label4.Size = new Size(346, 49);
            label4.TabIndex = 3;
            label4.Text = "Customer Name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 325);
            label2.Name = "label2";
            label2.Size = new Size(162, 49);
            label2.TabIndex = 2;
            label2.Text = "Model *";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 66);
            label1.Name = "label1";
            label1.Size = new Size(59, 49);
            label1.TabIndex = 1;
            label1.Text = "ID";
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
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(1164, 404);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1123, 1149);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // RentalManagenent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 1776);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "RentalManagenent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
            Load += RentalManagenent_Load;
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
        private Button btnDelete;
        private Button btnBack;
        private Button btnInsert;
        private TextBox txtRent;
        private TextBox txtModel;
        private TextBox txtId;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtCustname;
        private Label label13;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker toCarDate;
        private DateTimePicker fromCarDate;
        private Label label3;
        private Label label6;
        private Label label14;
        private DataGridView dataGridView1;
    }
}