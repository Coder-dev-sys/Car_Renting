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
            panel2 = new Panel();
            label8 = new Label();
            btnBack = new Button();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(label8);
            panel2.Location = new Point(12, 13);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(2284, 203);
            panel2.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Beige;
            label8.Location = new Point(909, 53);
            label8.Name = "label8";
            label8.Size = new Size(560, 84);
            label8.TabIndex = 0;
            label8.Text = "Car Management";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Crimson;
            btnBack.Font = new Font("Trebuchet MS", 11.1F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(1948, 223);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(348, 93);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back To Dashboard";
            btnBack.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1162, 523);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(1134, 722);
            dataGridView1.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Trebuchet MS", 20.1F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1123, 834);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(125, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 49);
            label1.TabIndex = 1;
            label1.Text = "Reg. No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(147, 382);
            label2.Name = "label2";
            label2.Size = new Size(133, 49);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label3.Location = new Point(99, 504);
            label3.Name = "label3";
            label3.Size = new Size(262, 49);
            label3.TabIndex = 3;
            label3.Text = "Rent Per Day";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label4.Location = new Point(125, 260);
            label4.Name = "label4";
            label4.Size = new Size(130, 49);
            label4.TabIndex = 3;
            label4.Text = "Brand";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label5.Location = new Point(147, 635);
            label5.Name = "label5";
            label5.Size = new Size(229, 49);
            label5.TabIndex = 4;
            label5.Text = "Availability";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label6.Location = new Point(195, 736);
            label6.Name = "label6";
            label6.Size = new Size(166, 49);
            label6.TabIndex = 5;
            label6.Text = "Reg. No";
            // 
            // CarManagement
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2308, 1549);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Name = "CarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rentals";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label8;
        private Button btnBack;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}