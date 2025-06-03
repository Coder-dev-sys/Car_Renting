namespace WinFormsApp1
{
    partial class CarManagement
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
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtId = new TextBox();
            label6 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            chkAvailability = new ComboBox();
            txtRent = new TextBox();
            txtModel = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtBrand = new TextBox();
            label13 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Trebuchet MS", 11.1F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(402, 1267);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(345, 93);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
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
            dataGridView1.Location = new Point(1173, 523);
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
            dataGridView1.Size = new Size(1123, 1388);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(chkAvailability);
            groupBox1.Controls.Add(txtRent);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtBrand);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 1388);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // txtId
            // 
            txtId.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(585, 80);
            txtId.Margin = new Padding(75, 115, 0, 4);
            txtId.Name = "txtId";
            txtId.PlaceholderText = "1";
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
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(63, 81, 181);
            btnClear.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Beige;
            btnClear.Location = new Point(409, 1105);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(326, 130);
            btnClear.TabIndex = 39;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(63, 81, 181);
            btnDelete.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Beige;
            btnDelete.Location = new Point(777, 943);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(326, 130);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(63, 81, 181);
            btnUpdate.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Beige;
            btnUpdate.Location = new Point(409, 943);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(326, 130);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
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
            btnInsert.Click += btnInsert_Click;
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
            txtRent.PlaceholderText = "950";
            txtRent.Size = new Size(484, 50);
            txtRent.TabIndex = 32;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(585, 325);
            txtModel.Margin = new Padding(75, 115, 0, 4);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "City";
            txtModel.Size = new Size(484, 50);
            txtModel.TabIndex = 31;
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
            // txtBrand
            // 
            txtBrand.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.Location = new Point(585, 196);
            txtBrand.Margin = new Padding(75, 115, 0, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "Honda";
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
            label5.Size = new Size(258, 49);
            label5.TabIndex = 4;
            label5.Text = "Availability *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(63, 197);
            label4.Name = "label4";
            label4.Size = new Size(159, 49);
            label4.TabIndex = 3;
            label4.Text = "Brand *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(63, 467);
            label3.Name = "label3";
            label3.Size = new Size(291, 49);
            label3.TabIndex = 3;
            label3.Text = "Rent Per Day *";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(245, 94);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1859, 292);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label7.ForeColor = Color.Beige;
            label7.Location = new Point(647, 89);
            label7.Name = "label7";
            label7.Size = new Size(563, 89);
            label7.TabIndex = 0;
            label7.Text = "Car Management";
            // 
            // CarManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 2019);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "CarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
            Load += CarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBack;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label7;
        private Label label13;
        private TextBox txtBrand;
        private Label label11;
        private Label label10;
        private Label label9;
        private ComboBox chkAvailability;
        private TextBox txtRent;
        private TextBox txtModel;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnClear;
        private TextBox txtId;
        private Label label6;
        private Label label1;
    }
}