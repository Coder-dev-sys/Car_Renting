namespace WindowsFormsApp1
{
    partial class LoginForm
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
            buttonRegister = new Button();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPwd = new TextBox();
            txtUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            groupBox1 = new GroupBox();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = SystemColors.Control;
            buttonRegister.Dock = DockStyle.Bottom;
            buttonRegister.Font = new Font("Trebuchet MS", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.Orange;
            buttonRegister.Location = new Point(3, 866);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(1219, 83);
            buttonRegister.TabIndex = 7;
            buttonRegister.Text = "Don't Have An Account ? ";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(63, 81, 181);
            btnCancel.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Beige;
            btnCancel.Location = new Point(749, 633);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(326, 130);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(63, 81, 181);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Beige;
            btnLogin.Location = new Point(152, 633);
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
            txtPwd.Location = new Point(629, 404);
            txtPwd.Margin = new Padding(75, 115, 0, 4);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '●';
            txtPwd.Size = new Size(514, 50);
            txtPwd.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Trebuchet MS", 11.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(629, 166);
            txtUsername.Margin = new Padding(75, 115, 0, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(514, 50);
            txtUsername.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(514, 405);
            label4.Name = "label4";
            label4.Size = new Size(37, 49);
            label4.TabIndex = 3;
            label4.Text = ":";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(514, 166);
            label3.Name = "label3";
            label3.Size = new Size(37, 49);
            label3.TabIndex = 2;
            label3.Text = ":";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(132, 405);
            label2.Name = "label2";
            label2.Size = new Size(192, 49);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(132, 167);
            label1.Margin = new Padding(3, 4, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(208, 49);
            label1.TabIndex = 0;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 81, 181);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(450, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1225, 292);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(301, 96);
            label8.Name = "label8";
            label8.Size = new Size(628, 89);
            label8.TabIndex = 0;
            label8.Text = "Car Renting System";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(txtPwd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(buttonRegister);
            groupBox1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(450, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1225, 952);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2308, 1549);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals - Login";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private GroupBox groupBox1;
    }
}

