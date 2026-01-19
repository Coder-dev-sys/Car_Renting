using System.Windows.Forms;
namespace final
{
    partial class booking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mybooking = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.luxury = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.pickdrop = new System.Windows.Forms.Button();
            this.suv = new System.Windows.Forms.Button();
            this.seden = new System.Windows.Forms.Button();
            this.Available1 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_date_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totaldayslbl = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fromdate = new System.Windows.Forms.DateTimePicker();
            this.carpanel = new System.Windows.Forms.Panel();
            this.panelinvoice = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mybooking);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.luxury);
            this.groupBox1.Controls.Add(this.events);
            this.groupBox1.Controls.Add(this.pickdrop);
            this.groupBox1.Controls.Add(this.suv);
            this.groupBox1.Controls.Add(this.seden);
            this.groupBox1.Controls.Add(this.Available1);
            this.groupBox1.Controls.Add(this.lblusername);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1335, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(45, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "SELECT CAR TYPE";
            // 
            // mybooking
            // 
            this.mybooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.mybooking.Cursor = System.Windows.Forms.Cursors.Default;
            this.mybooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mybooking.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.mybooking.ForeColor = System.Drawing.Color.White;
            this.mybooking.Location = new System.Drawing.Point(1019, 47);
            this.mybooking.Name = "mybooking";
            this.mybooking.Size = new System.Drawing.Size(152, 40);
            this.mybooking.TabIndex = 41;
            this.mybooking.Text = "MY BOOKINGS";
            this.mybooking.UseVisualStyleBackColor = false;
            this.mybooking.Click += new System.EventHandler(this.mybooking_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Default;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1177, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(152, 40);
            this.button7.TabIndex = 40;
            this.button7.Text = "LOG OUT";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // luxury
            // 
            this.luxury.BackColor = System.Drawing.Color.White;
            this.luxury.Cursor = System.Windows.Forms.Cursors.Default;
            this.luxury.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luxury.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.luxury.ForeColor = System.Drawing.Color.Black;
            this.luxury.Location = new System.Drawing.Point(371, 47);
            this.luxury.Name = "luxury";
            this.luxury.Size = new System.Drawing.Size(152, 40);
            this.luxury.TabIndex = 39;
            this.luxury.Text = "LUXURY";
            this.luxury.UseVisualStyleBackColor = false;
            this.luxury.Click += new System.EventHandler(this.luxury_Click);
            // 
            // events
            // 
            this.events.BackColor = System.Drawing.Color.White;
            this.events.Cursor = System.Windows.Forms.Cursors.Default;
            this.events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.events.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.events.ForeColor = System.Drawing.Color.Black;
            this.events.Location = new System.Drawing.Point(529, 47);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(152, 40);
            this.events.TabIndex = 38;
            this.events.Text = "EVENT";
            this.events.UseVisualStyleBackColor = false;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // pickdrop
            // 
            this.pickdrop.BackColor = System.Drawing.Color.White;
            this.pickdrop.Cursor = System.Windows.Forms.Cursors.Default;
            this.pickdrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickdrop.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.pickdrop.ForeColor = System.Drawing.Color.Black;
            this.pickdrop.Location = new System.Drawing.Point(687, 47);
            this.pickdrop.Name = "pickdrop";
            this.pickdrop.Size = new System.Drawing.Size(152, 40);
            this.pickdrop.TabIndex = 37;
            this.pickdrop.Text = "PICK-DROP";
            this.pickdrop.UseVisualStyleBackColor = false;
            this.pickdrop.Click += new System.EventHandler(this.pickdrop_Click);
            // 
            // suv
            // 
            this.suv.BackColor = System.Drawing.Color.White;
            this.suv.Cursor = System.Windows.Forms.Cursors.Default;
            this.suv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suv.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.suv.ForeColor = System.Drawing.Color.Black;
            this.suv.Location = new System.Drawing.Point(213, 47);
            this.suv.Name = "suv";
            this.suv.Size = new System.Drawing.Size(152, 40);
            this.suv.TabIndex = 36;
            this.suv.Text = "SUV";
            this.suv.UseVisualStyleBackColor = false;
            this.suv.Click += new System.EventHandler(this.suv_Click);
            // 
            // seden
            // 
            this.seden.BackColor = System.Drawing.Color.White;
            this.seden.Cursor = System.Windows.Forms.Cursors.Default;
            this.seden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seden.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.seden.ForeColor = System.Drawing.Color.Black;
            this.seden.Location = new System.Drawing.Point(50, 47);
            this.seden.Name = "seden";
            this.seden.Size = new System.Drawing.Size(152, 40);
            this.seden.TabIndex = 35;
            this.seden.Text = "SEDEN";
            this.seden.UseVisualStyleBackColor = false;
            this.seden.Click += new System.EventHandler(this.seden_Click);
            // 
            // Available1
            // 
            this.Available1.AutoSize = true;
            this.Available1.Location = new System.Drawing.Point(103, 77);
            this.Available1.Name = "Available1";
            this.Available1.Size = new System.Drawing.Size(80, 21);
            this.Available1.TabIndex = 9;
            this.Available1.Text = "Available";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.Black;
            this.lblusername.Location = new System.Drawing.Point(1021, 90);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 21);
            this.lblusername.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_date_submit);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.totaldayslbl);
            this.groupBox2.Controls.Add(this.todate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.fromdate);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1335, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // btn_date_submit
            // 
            this.btn_date_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_date_submit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_date_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_date_submit.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.btn_date_submit.ForeColor = System.Drawing.Color.White;
            this.btn_date_submit.Location = new System.Drawing.Point(885, 37);
            this.btn_date_submit.Name = "btn_date_submit";
            this.btn_date_submit.Size = new System.Drawing.Size(136, 36);
            this.btn_date_submit.TabIndex = 42;
            this.btn_date_submit.Text = "Submit";
            this.btn_date_submit.UseVisualStyleBackColor = false;
            this.btn_date_submit.Click += new System.EventHandler(this.btn_date_submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "SELECT DATE";
            // 
            // totaldayslbl
            // 
            this.totaldayslbl.AutoSize = true;
            this.totaldayslbl.Location = new System.Drawing.Point(207, 132);
            this.totaldayslbl.Name = "totaldayslbl";
            this.totaldayslbl.Size = new System.Drawing.Size(0, 26);
            this.totaldayslbl.TabIndex = 10;
            // 
            // todate
            // 
            this.todate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.todate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.todate.Location = new System.Drawing.Point(566, 41);
            this.todate.MinDate = new System.DateTime(2013, 7, 2, 0, 0, 0, 0);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(215, 27);
            this.todate.TabIndex = 4;
            this.todate.Value = new System.DateTime(2024, 1, 2, 5, 57, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(490, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(103, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From :";
            // 
            // fromdate
            // 
            this.fromdate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.fromdate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.fromdate.Location = new System.Drawing.Point(179, 41);
            this.fromdate.MinDate = new System.DateTime(2013, 7, 2, 0, 0, 0, 0);
            this.fromdate.Name = "fromdate";
            this.fromdate.Size = new System.Drawing.Size(215, 27);
            this.fromdate.TabIndex = 0;
            this.fromdate.Value = new System.DateTime(2024, 1, 1, 5, 57, 0, 0);
            // 
            // carpanel
            // 
            this.carpanel.AutoScroll = true;
            this.carpanel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.carpanel.Location = new System.Drawing.Point(7, 215);
            this.carpanel.Name = "carpanel";
            this.carpanel.Size = new System.Drawing.Size(781, 479);
            this.carpanel.TabIndex = 1;
            this.carpanel.Visible = false;
            // 
            // panelinvoice
            // 
            this.panelinvoice.AutoScroll = true;
            this.panelinvoice.BackColor = System.Drawing.Color.White;
            this.panelinvoice.Location = new System.Drawing.Point(787, 218);
            this.panelinvoice.Name = "panelinvoice";
            this.panelinvoice.Size = new System.Drawing.Size(555, 476);
            this.panelinvoice.TabIndex = 0;
            this.panelinvoice.Visible = false;
            // 
            // booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1364, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.carpanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelinvoice);
            this.Name = "booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker todate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fromdate;
        private System.Windows.Forms.Label totaldayslbl;
        private System.Windows.Forms.Panel carpanel;
        private Panel panelinvoice;
        private Label lblusername;
        private Label Available1;
        private Button seden;
        private Button suv;
        private Button mybooking;
        private Button button7;
        private Button luxury;
        private Button events;
        private Button pickdrop;
        private Label label1;
        private Button btn_date_submit;
        private Label label4;
    }
}