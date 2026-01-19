using System.Windows.Forms;
namespace final
{
    partial class PaymentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncard = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnupi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbcard = new System.Windows.Forms.GroupBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.GBUPI = new System.Windows.Forms.GroupBox();
            this.lblsuss = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbcard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GBUPI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btncard);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnupi);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Location = new System.Drawing.Point(63, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 657);
            this.panel1.TabIndex = 5;
            // 
            // btncard
            // 
            this.btncard.BackgroundImage = global::final.Properties.Resources.ATM;
            this.btncard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncard.Location = new System.Drawing.Point(21, 306);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(59, 48);
            this.btncard.TabIndex = 12;
            this.btncard.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::final.Properties.Resources.gpay;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(21, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 48);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::final.Properties.Resources.cardekho_new;
            this.pictureBox1.Location = new System.Drawing.Point(95, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(8, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 63);
            this.button2.TabIndex = 9;
            this.button2.Text = "Debit/Credit Card";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnupi
            // 
            this.btnupi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnupi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnupi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnupi.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnupi.ForeColor = System.Drawing.Color.White;
            this.btnupi.Location = new System.Drawing.Point(8, 203);
            this.btnupi.Name = "btnupi";
            this.btnupi.Size = new System.Drawing.Size(267, 69);
            this.btnupi.TabIndex = 8;
            this.btnupi.Text = "UPI / QR";
            this.btnupi.UseVisualStyleBackColor = false;
            this.btnupi.Click += new System.EventHandler(this.btnupi_click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(3, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payment For Booking : ";
            // 
            // gbcard
            // 
            this.gbcard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbcard.Controls.Add(this.txtCardName);
            this.gbcard.Controls.Add(this.txtExpiry);
            this.gbcard.Controls.Add(this.txtCvv);
            this.gbcard.Controls.Add(this.txtCardNumber);
            this.gbcard.Controls.Add(this.label9);
            this.gbcard.Controls.Add(this.panel2);
            this.gbcard.Controls.Add(this.button1);
            this.gbcard.Controls.Add(this.label7);
            this.gbcard.Controls.Add(this.label6);
            this.gbcard.Controls.Add(this.label5);
            this.gbcard.Controls.Add(this.label4);
            this.gbcard.Controls.Add(this.label3);
            this.gbcard.Controls.Add(this.label2);
            this.gbcard.Controls.Add(this.label1);
            this.gbcard.Controls.Add(this.btnPay);
            this.gbcard.Controls.Add(this.lbl1);
            this.gbcard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbcard.Location = new System.Drawing.Point(360, 36);
            this.gbcard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbcard.Name = "gbcard";
            this.gbcard.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbcard.Size = new System.Drawing.Size(929, 657);
            this.gbcard.TabIndex = 4;
            this.gbcard.TabStop = false;
            // 
            // txtCardName
            // 
            this.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(510, 299);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(340, 35);
            this.txtCardName.TabIndex = 19;
            // 
            // txtExpiry
            // 
            this.txtExpiry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExpiry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(510, 362);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(151, 35);
            this.txtExpiry.TabIndex = 18;
            // 
            // txtCvv
            // 
            this.txtCvv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCvv.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCvv.Location = new System.Drawing.Point(510, 427);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(151, 35);
            this.txtCvv.TabIndex = 17;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardNumber.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(510, 237);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(340, 35);
            this.txtCardNumber.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label9.Location = new System.Drawing.Point(152, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(680, 47);
            this.label9.TabIndex = 15;
            this.label9.Text = "PAY THROGH ANY DEBIT/CREDIT CARD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(6, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 38);
            this.panel2.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Location = new System.Drawing.Point(159, 7);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 27);
            this.lblStatus.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(533, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Card Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card Expiry";
            // 
            // btnPay
            // 
            this.btnPay.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnPay.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPay.Location = new System.Drawing.Point(271, 526);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(107, 44);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(159, 233);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 30);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Card Number ";
            // 
            // GBUPI
            // 
            this.GBUPI.BackColor = System.Drawing.Color.Gainsboro;
            this.GBUPI.Controls.Add(this.lblsuss);
            this.GBUPI.Controls.Add(this.label12);
            this.GBUPI.Controls.Add(this.button3);
            this.GBUPI.Controls.Add(this.txtref);
            this.GBUPI.Controls.Add(this.label8);
            this.GBUPI.Controls.Add(this.pictureBox2);
            this.GBUPI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GBUPI.Location = new System.Drawing.Point(360, 36);
            this.GBUPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBUPI.Name = "GBUPI";
            this.GBUPI.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GBUPI.Size = new System.Drawing.Size(929, 650);
            this.GBUPI.TabIndex = 20;
            this.GBUPI.TabStop = false;
            // 
            // lblsuss
            // 
            this.lblsuss.AutoSize = true;
            this.lblsuss.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblsuss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblsuss.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsuss.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblsuss.Location = new System.Drawing.Point(234, 573);
            this.lblsuss.Name = "lblsuss";
            this.lblsuss.Size = new System.Drawing.Size(554, 40);
            this.lblsuss.TabIndex = 13;
            this.lblsuss.Text = "THANK YOU , YOUR PAYMENT IS DONE";
            this.lblsuss.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label12.Location = new System.Drawing.Point(180, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(660, 47);
            this.label12.TabIndex = 20;
            this.label12.Text = "PAY THROUGH ANY UPI APPLICATION";
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(392, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 44);
            this.button3.TabIndex = 17;
            this.button3.Text = "Pay";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtref
            // 
            this.txtref.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtref.Location = new System.Drawing.Point(313, 439);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(378, 35);
            this.txtref.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(617, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Please Complete The Payment And Enter The UTR Refrence Number ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::final.Properties.Resources.qr;
            this.pictureBox2.Location = new System.Drawing.Point(359, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(267, 265);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 749);
            this.Controls.Add(this.GBUPI);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbcard);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paymentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbcard.ResumeLayout(false);
            this.gbcard.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GBUPI.ResumeLayout(false);
            this.GBUPI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbcard;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.TextBox txtCardNumber;
        private Button button2;
        private Button btnupi;
        private PictureBox pictureBox1;
        private Button button4;
        private Button btncard;
        private GroupBox GBUPI;
        private PictureBox pictureBox2;
        private Label label9;
        private Label label8;
        private Button button3;
        private TextBox txtref;
        private Label label12;
        private Label lblsuss;
    }
}