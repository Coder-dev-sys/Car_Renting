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
            panel1 = new Panel();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnInsert = new Button();
            chkAvailability = new ComboBox();
            txtRent = new TextBox();
            txtModel = new TextBox();
            txtRegNo = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtBrand = new TextBox();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
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
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(chkAvailability);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtRegNo);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 404);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 1388);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(63, 81, 181);
            btnRefresh.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Beige;
            btnRefresh.Location = new Point(403, 943);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(326, 130);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(63, 81, 181);
            btnDelete.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Beige;
            btnDelete.Location = new Point(772, 943);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(326, 130);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Trebuchet MS", 11.1F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(397, 1129);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(345, 93);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(63, 81, 181);
            btnInsert.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.ForeColor = Color.Beige;
            btnInsert.Location = new Point(15, 943);
            btnInsert.Margin = new Padding(3, 4, 3, 4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(326, 130);
            btnInsert.TabIndex = 36;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // chkAvailability
            // 
            chkAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
            chkAvailability.Font = new Font("Trebuchet MS", 11.1F);
            chkAvailability.FormattingEnabled = true;
            chkAvailability.Items.AddRange(new object[] { "Available", "Not-Available" });
            chkAvailability.Location = new Point(585, 606);
            chkAvailability.Name = "chkAvailability";
            chkAvailability.Size = new Size(484, 54);
            chkAvailability.TabIndex = 33;
            // 
            // txtRent
            // 
            txtRent.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRent.Location = new Point(585, 467);
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
            // txtRegNo
            // 
            txtRegNo.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegNo.Location = new Point(585, 65);
            txtRegNo.Margin = new Padding(75, 115, 0, 4);
            txtRegNo.Name = "txtRegNo";
            txtRegNo.Size = new Size(484, 50);
            txtRegNo.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(470, 611);
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
            // txtBrand
            // 
            txtBrand.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(585, 196);
            txtBrand.Margin = new Padding(75, 115, 0, 4);
            txtBrand.Name = "txtBrand";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label5.Location = new Point(63, 611);
            label5.Name = "label5";
            label5.Size = new Size(229, 49);
            label5.TabIndex = 4;
            label5.Text = "Availability";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 197);
            label4.Name = "label4";
            label4.Size = new Size(317, 49);
            label4.TabIndex = 3;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 467);
            label3.Name = "label3";
            label3.Size = new Size(262, 49);
            label3.TabIndex = 3;
            label3.Text = "Rent Per Day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(63, 325);
            label2.Name = "label2";
            label2.Size = new Size(133, 49);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(63, 66);
            label1.Name = "label1";
            label1.Size = new Size(133, 49);
            label1.TabIndex = 1;
            label1.Text = "Car ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1173, 404);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1123, 1388);
            dataGridView1.TabIndex = 16;
            // 
            // RentalManagenent
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 1776);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "RentalManagenent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
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
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnBack;
        private Button btnInsert;
        private ComboBox chkAvailability;
        private TextBox txtRent;
        private TextBox txtModel;
        private TextBox txtRegNo;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtBrand;
        private Label label13;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}