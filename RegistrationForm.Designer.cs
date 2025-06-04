namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            btnBack = new Button();
            txtFullName = new TextBox();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            txtAddress = new TextBox();
            txtMobileNo = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            btnReset = new Button();
            btnRegister = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtMobileNo);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(450, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1225, 1269);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(63, 81, 181);
            btnBack.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Beige;
            btnBack.Location = new Point(845, 1056);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(326, 130);
            btnBack.TabIndex = 24;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(696, 101);
            txtFullName.Margin = new Padding(75, 115, 0, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(484, 50);
            txtFullName.TabIndex = 23;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(696, 828);
            txtPwd.Margin = new Padding(3, 4, 3, 4);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '●';
            txtPwd.Size = new Size(484, 50);
            txtPwd.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(696, 676);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(484, 50);
            txtUsername.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(696, 419);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(484, 175);
            txtAddress.TabIndex = 17;
            // 
            // txtMobileNo
            // 
            txtMobileNo.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNo.Location = new Point(696, 249);
            txtMobileNo.Margin = new Padding(3, 4, 3, 4);
            txtMobileNo.Name = "txtMobileNo";
            txtMobileNo.Size = new Size(484, 50);
            txtMobileNo.TabIndex = 16;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlText;
            label13.Location = new Point(542, 102);
            label13.Name = "label13";
            label13.Size = new Size(37, 49);
            label13.TabIndex = 14;
            label13.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ControlText;
            label12.Location = new Point(542, 249);
            label12.Name = "label12";
            label12.Size = new Size(37, 49);
            label12.TabIndex = 13;
            label12.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(542, 419);
            label11.Name = "label11";
            label11.Size = new Size(37, 49);
            label11.TabIndex = 12;
            label11.Text = ":";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(101, 419);
            label10.Name = "label10";
            label10.Size = new Size(167, 49);
            label10.TabIndex = 11;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(101, 102);
            label9.Name = "label9";
            label9.Size = new Size(208, 49);
            label9.TabIndex = 10;
            label9.Text = "Full Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(101, 249);
            label7.Name = "label7";
            label7.Size = new Size(222, 49);
            label7.TabIndex = 9;
            label7.Text = "Mobile No.";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(63, 81, 181);
            btnReset.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.Beige;
            btnReset.Location = new Point(453, 1056);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(326, 130);
            btnReset.TabIndex = 8;
            btnReset.Text = "Clear";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(63, 81, 181);
            btnRegister.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Beige;
            btnRegister.Location = new Point(55, 1056);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(326, 130);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(542, 828);
            label4.Name = "label4";
            label4.Size = new Size(37, 49);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(542, 676);
            label3.Name = "label3";
            label3.Size = new Size(37, 49);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(101, 828);
            label2.Name = "label2";
            label2.Size = new Size(192, 49);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(101, 676);
            label1.Name = "label1";
            label1.Size = new Size(208, 49);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 81, 181);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(450, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 292);
            panel2.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(308, 90);
            label8.Name = "label8";
            label8.Size = new Size(628, 89);
            label8.TabIndex = 0;
            label8.Text = "Car Renting System";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 1803);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals - Registration";
            WindowState = FormWindowState.Maximized;
            Load += RegistrationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Panel panel2;
        private Label label8;
        private TextBox txtFullName;
        private Button btnBack;
    }
}