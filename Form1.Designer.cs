namespace WindowsFormsApp1
{
    partial class Form1
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
            btnCancel = new Button();
            buttonRegister = new Button();
            btnLogin = new Button();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(buttonRegister);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.YellowGreen;
            groupBox1.Location = new Point(930, 398);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1225, 1036);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaptionText;
            btnCancel.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Beige;
            btnCancel.Location = new Point(725, 673);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(326, 130);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.Control;
            buttonRegister.Font = new Font("Trebuchet MS", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.YellowGreen;
            buttonRegister.Location = new Point(289, 899);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(645, 86);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Don't Have An Account ? ";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Beige;
            btnLogin.Location = new Point(135, 673);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(326, 130);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPwd
            // 
            txtPwd.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPwd.Location = new Point(647, 471);
            txtPwd.Margin = new Padding(3, 4, 3, 4);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(514, 50);
            txtPwd.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(647, 230);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(514, 50);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(514, 472);
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
            label3.Location = new Point(514, 231);
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
            label2.Location = new Point(135, 472);
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
            label1.Location = new Point(135, 231);
            label1.Name = "label1";
            label1.Size = new Size(208, 49);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(2, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 1555);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Beige;
            label6.Location = new Point(200, 833);
            label6.Name = "label6";
            label6.Size = new Size(269, 92);
            label6.TabIndex = 1;
            label6.Text = "Hello Friend !\r\nWelcome Back\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Beige;
            label5.Location = new Point(208, 425);
            label5.Name = "label5";
            label5.Size = new Size(244, 102);
            label5.TabIndex = 0;
            label5.Text = "Login";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(715, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1580, 292);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(489, 91);
            label8.Name = "label8";
            label8.Size = new Size(645, 84);
            label8.TabIndex = 0;
            label8.Text = "Car Renting System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(2308, 1549);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}

