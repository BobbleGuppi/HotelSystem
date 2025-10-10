namespace HotelSystem.View
{
    partial class MakeBooking
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
            this.Rersevationpnl = new System.Windows.Forms.Panel();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.confirmRbtn = new System.Windows.Forms.Button();
            this.availabilitybtn = new System.Windows.Forms.Button();
            this.departureDateTP = new System.Windows.Forms.DateTimePicker();
            this.arrivalDateTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guestpnl = new System.Windows.Forms.Panel();
            this.confirmGbtn = new System.Windows.Forms.Button();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.lNametxt = new System.Windows.Forms.TextBox();
            this.idNotxt = new System.Windows.Forms.TextBox();
            this.phoneNotxt = new System.Windows.Forms.TextBox();
            this.fNametxt = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblfname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prepagebtn = new System.Windows.Forms.Button();
            this.Rersevationpnl.SuspendLayout();
            this.guestpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rersevationpnl
            // 
            this.Rersevationpnl.Controls.Add(this.cancelbtn);
            this.Rersevationpnl.Controls.Add(this.confirmRbtn);
            this.Rersevationpnl.Controls.Add(this.availabilitybtn);
            this.Rersevationpnl.Controls.Add(this.departureDateTP);
            this.Rersevationpnl.Controls.Add(this.arrivalDateTP);
            this.Rersevationpnl.Controls.Add(this.label3);
            this.Rersevationpnl.Controls.Add(this.label2);
            this.Rersevationpnl.Controls.Add(this.label1);
            this.Rersevationpnl.Location = new System.Drawing.Point(44, 34);
            this.Rersevationpnl.Name = "Rersevationpnl";
            this.Rersevationpnl.Size = new System.Drawing.Size(520, 383);
            this.Rersevationpnl.TabIndex = 0;
            this.Rersevationpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Rersevationpnl_Paint);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(414, 329);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(103, 33);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // confirmRbtn
            // 
            this.confirmRbtn.BackColor = System.Drawing.Color.LightBlue;
            this.confirmRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmRbtn.Location = new System.Drawing.Point(218, 329);
            this.confirmRbtn.Name = "confirmRbtn";
            this.confirmRbtn.Size = new System.Drawing.Size(172, 33);
            this.confirmRbtn.TabIndex = 8;
            this.confirmRbtn.Text = "Confirm Rersevation";
            this.confirmRbtn.UseVisualStyleBackColor = false;
            this.confirmRbtn.Click += new System.EventHandler(this.confirmRbtn_Click);
            // 
            // availabilitybtn
            // 
            this.availabilitybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilitybtn.Location = new System.Drawing.Point(15, 329);
            this.availabilitybtn.Name = "availabilitybtn";
            this.availabilitybtn.Size = new System.Drawing.Size(182, 33);
            this.availabilitybtn.TabIndex = 7;
            this.availabilitybtn.Text = "Show Room Availability";
            this.availabilitybtn.UseVisualStyleBackColor = true;
            this.availabilitybtn.Click += new System.EventHandler(this.availabilitybtn_Click);
            // 
            // departureDateTP
            // 
            this.departureDateTP.Location = new System.Drawing.Point(239, 115);
            this.departureDateTP.Name = "departureDateTP";
            this.departureDateTP.Size = new System.Drawing.Size(200, 22);
            this.departureDateTP.TabIndex = 5;
            // 
            // arrivalDateTP
            // 
            this.arrivalDateTP.Location = new System.Drawing.Point(239, 71);
            this.arrivalDateTP.Name = "arrivalDateTP";
            this.arrivalDateTP.Size = new System.Drawing.Size(200, 22);
            this.arrivalDateTP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture Rersevation Details:";
            // 
            // guestpnl
            // 
            this.guestpnl.Controls.Add(this.prepagebtn);
            this.guestpnl.Controls.Add(this.confirmGbtn);
            this.guestpnl.Controls.Add(this.addresstxt);
            this.guestpnl.Controls.Add(this.lNametxt);
            this.guestpnl.Controls.Add(this.idNotxt);
            this.guestpnl.Controls.Add(this.phoneNotxt);
            this.guestpnl.Controls.Add(this.fNametxt);
            this.guestpnl.Controls.Add(this.lbladdress);
            this.guestpnl.Controls.Add(this.lblid);
            this.guestpnl.Controls.Add(this.lblphone);
            this.guestpnl.Controls.Add(this.lblname);
            this.guestpnl.Controls.Add(this.lblfname);
            this.guestpnl.Controls.Add(this.label5);
            this.guestpnl.Location = new System.Drawing.Point(641, 34);
            this.guestpnl.Name = "guestpnl";
            this.guestpnl.Size = new System.Drawing.Size(526, 383);
            this.guestpnl.TabIndex = 1;
            // 
            // confirmGbtn
            // 
            this.confirmGbtn.BackColor = System.Drawing.Color.LightBlue;
            this.confirmGbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGbtn.Location = new System.Drawing.Point(298, 329);
            this.confirmGbtn.Name = "confirmGbtn";
            this.confirmGbtn.Size = new System.Drawing.Size(143, 33);
            this.confirmGbtn.TabIndex = 13;
            this.confirmGbtn.Text = "Confirm Guest";
            this.confirmGbtn.UseVisualStyleBackColor = false;
            this.confirmGbtn.Click += new System.EventHandler(this.confirmGbtn_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Location = new System.Drawing.Point(206, 246);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(216, 48);
            this.addresstxt.TabIndex = 12;
            // 
            // lNametxt
            // 
            this.lNametxt.Location = new System.Drawing.Point(206, 113);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(216, 22);
            this.lNametxt.TabIndex = 10;
            // 
            // idNotxt
            // 
            this.idNotxt.Location = new System.Drawing.Point(206, 191);
            this.idNotxt.Name = "idNotxt";
            this.idNotxt.Size = new System.Drawing.Size(216, 22);
            this.idNotxt.TabIndex = 9;
            // 
            // phoneNotxt
            // 
            this.phoneNotxt.Location = new System.Drawing.Point(206, 153);
            this.phoneNotxt.Name = "phoneNotxt";
            this.phoneNotxt.Size = new System.Drawing.Size(149, 22);
            this.phoneNotxt.TabIndex = 8;
            // 
            // fNametxt
            // 
            this.fNametxt.Location = new System.Drawing.Point(206, 75);
            this.fNametxt.Name = "fNametxt";
            this.fNametxt.Size = new System.Drawing.Size(216, 22);
            this.fNametxt.TabIndex = 7;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(42, 246);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(84, 20);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Address:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(42, 191);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(102, 20);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "ID number:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(42, 153);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(135, 20);
            this.lblphone.TabIndex = 3;
            this.lblphone.Text = "Phone number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(42, 115);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(106, 20);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(40, 75);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(108, 20);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Capture Guest Details:";
            // 
            // prepagebtn
            // 
            this.prepagebtn.BackColor = System.Drawing.Color.LightBlue;
            this.prepagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepagebtn.Location = new System.Drawing.Point(66, 329);
            this.prepagebtn.Name = "prepagebtn";
            this.prepagebtn.Size = new System.Drawing.Size(143, 33);
            this.prepagebtn.TabIndex = 14;
            this.prepagebtn.Text = "Prevoius Page";
            this.prepagebtn.UseVisualStyleBackColor = false;
            this.prepagebtn.Click += new System.EventHandler(this.prepagebtn_Click);
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1267, 552);
            this.Controls.Add(this.guestpnl);
            this.Controls.Add(this.Rersevationpnl);
            this.Name = "MakeBooking";
            this.Text = "MakeBooking";
            this.Load += new System.EventHandler(this.MakeBooking_Load);
            this.Rersevationpnl.ResumeLayout(false);
            this.Rersevationpnl.PerformLayout();
            this.guestpnl.ResumeLayout(false);
            this.guestpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Rersevationpnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker departureDateTP;
        private System.Windows.Forms.DateTimePicker arrivalDateTP;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button confirmRbtn;
        private System.Windows.Forms.Button availabilitybtn;
        private System.Windows.Forms.Panel guestpnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblfname;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.TextBox lNametxt;
        private System.Windows.Forms.TextBox idNotxt;
        private System.Windows.Forms.TextBox phoneNotxt;
        private System.Windows.Forms.TextBox fNametxt;
        private System.Windows.Forms.Button confirmGbtn;
        private System.Windows.Forms.Button prepagebtn;
    }
}