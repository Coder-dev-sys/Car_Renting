namespace WinFormsApp1
{
    partial class AdminDashboard
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            btnLogout = new Button();
            btnTotalInccome = new Button();
            label4 = new Label();
            btnCustomerMng = new Button();
            label3 = new Label();
            btnUserMng = new Button();
            label2 = new Label();
            btnRentalMng = new Button();
            label1 = new Label();
            btnCarMng = new Button();
            panel1 = new Panel();
            label6 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnLogout);
            groupBox1.Controls.Add(btnTotalInccome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnCustomerMng);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnUserMng);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnRentalMng);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCarMng);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(150, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(2035, 768);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label5.Location = new Point(1288, 360);
            label5.Name = "label5";
            label5.Size = new Size(260, 49);
            label5.TabIndex = 9;
            label5.Text = "Total Income";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Crimson;
            btnLogout.Font = new Font("Trebuchet MS", 11.1F);
            btnLogout.ForeColor = SystemColors.Control;
            btnLogout.Location = new Point(1735, 654);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(279, 93);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnTotalInccome
            // 
            btnTotalInccome.BackColor = Color.DarkViolet;
            btnTotalInccome.Font = new Font("Trebuchet MS", 11.1F);
            btnTotalInccome.ForeColor = SystemColors.Control;
            btnTotalInccome.Location = new Point(1235, 431);
            btnTotalInccome.Name = "btnTotalInccome";
            btnTotalInccome.Size = new Size(373, 141);
            btnTotalInccome.TabIndex = 8;
            btnTotalInccome.Text = "0";
            btnTotalInccome.UseVisualStyleBackColor = false;
            btnTotalInccome.Click += btnTotalInccome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(432, 360);
            label4.Name = "label4";
            label4.Size = new Size(436, 49);
            label4.TabIndex = 7;
            label4.Text = "Customer Registration";
            // 
            // btnCustomerMng
            // 
            btnCustomerMng.BackColor = Color.Blue;
            btnCustomerMng.Font = new Font("Trebuchet MS", 11.1F);
            btnCustomerMng.ForeColor = SystemColors.Control;
            btnCustomerMng.Location = new Point(459, 431);
            btnCustomerMng.Name = "btnCustomerMng";
            btnCustomerMng.Size = new Size(373, 141);
            btnCustomerMng.TabIndex = 6;
            btnCustomerMng.Text = "0";
            btnCustomerMng.UseVisualStyleBackColor = false;
            btnCustomerMng.Click += btnCustomerMng_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(1590, 56);
            label3.Name = "label3";
            label3.Size = new Size(354, 49);
            label3.TabIndex = 5;
            label3.Text = "User Management";
            // 
            // btnUserMng
            // 
            btnUserMng.BackColor = Color.MediumTurquoise;
            btnUserMng.Font = new Font("Trebuchet MS", 11.1F);
            btnUserMng.Location = new Point(1581, 127);
            btnUserMng.Name = "btnUserMng";
            btnUserMng.Size = new Size(373, 141);
            btnUserMng.TabIndex = 4;
            btnUserMng.Text = "0";
            btnUserMng.UseVisualStyleBackColor = false;
            btnUserMng.Click += btnUserMng_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(841, 56);
            label2.Name = "label2";
            label2.Size = new Size(390, 49);
            label2.TabIndex = 3;
            label2.Text = "Rental Management";
            // 
            // btnRentalMng
            // 
            btnRentalMng.BackColor = Color.YellowGreen;
            btnRentalMng.Font = new Font("Trebuchet MS", 11.1F);
            btnRentalMng.Location = new Point(841, 127);
            btnRentalMng.Name = "btnRentalMng";
            btnRentalMng.Size = new Size(373, 141);
            btnRentalMng.TabIndex = 2;
            btnRentalMng.Text = "0";
            btnRentalMng.UseVisualStyleBackColor = false;
            btnRentalMng.Click += btnRentalMng_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(95, 56);
            label1.Name = "label1";
            label1.Size = new Size(332, 49);
            label1.TabIndex = 1;
            label1.Text = "Car Management";
            // 
            // btnCarMng
            // 
            btnCarMng.BackColor = Color.DarkOrange;
            btnCarMng.Font = new Font("Trebuchet MS", 11.1F);
            btnCarMng.Location = new Point(75, 127);
            btnCarMng.Name = "btnCarMng";
            btnCarMng.Size = new Size(373, 141);
            btnCarMng.TabIndex = 0;
            btnCarMng.Text = "0";
            btnCarMng.UseVisualStyleBackColor = false;
            btnCarMng.Click += btnCarMng_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 81, 181);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(150, 34);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(2035, 292);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label6.ForeColor = Color.Beige;
            label6.Location = new Point(816, 87);
            label6.Name = "label6";
            label6.Size = new Size(367, 89);
            label6.TabIndex = 0;
            label6.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 1386);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Button btnCarMng;
        private Label label3;
        private Button btnUserMng;
        private Label label2;
        private Button btnRentalMng;
        private Label label5;
        private Button btnTotalInccome;
        private Label label4;
        private Button btnCustomerMng;
        private Button btnLogout;
        private Panel panel1;
        private Label label6;
    }
}