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
            this.prepagebtn = new System.Windows.Forms.Button();
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
            this.Rersevationpnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rersevationpnl.Name = "Rersevationpnl";
            this.Rersevationpnl.Size = new System.Drawing.Size(1219, 636);
            this.Rersevationpnl.TabIndex = 0;
            this.Rersevationpnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Rersevationpnl_Paint);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.Location = new System.Drawing.Point(954, 508);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(191, 77);
            this.cancelbtn.TabIndex = 9;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // confirmRbtn
            // 
            this.confirmRbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirmRbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmRbtn.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmRbtn.Location = new System.Drawing.Point(533, 506);
            this.confirmRbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmRbtn.Name = "confirmRbtn";
            this.confirmRbtn.Size = new System.Drawing.Size(242, 79);
            this.confirmRbtn.TabIndex = 8;
            this.confirmRbtn.Text = "Confirm Rersevation";
            this.confirmRbtn.UseVisualStyleBackColor = false;
            this.confirmRbtn.Click += new System.EventHandler(this.confirmRbtn_Click);
            // 
            // availabilitybtn
            // 
            this.availabilitybtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.availabilitybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availabilitybtn.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilitybtn.Location = new System.Drawing.Point(68, 506);
            this.availabilitybtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availabilitybtn.Name = "availabilitybtn";
            this.availabilitybtn.Size = new System.Drawing.Size(252, 79);
            this.availabilitybtn.TabIndex = 7;
            this.availabilitybtn.Text = "Show Room Availability";
            this.availabilitybtn.UseVisualStyleBackColor = false;
            this.availabilitybtn.Click += new System.EventHandler(this.availabilitybtn_Click);
            // 
            // departureDateTP
            // 
            this.departureDateTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departureDateTP.Location = new System.Drawing.Point(564, 224);
            this.departureDateTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departureDateTP.Name = "departureDateTP";
            this.departureDateTP.Size = new System.Drawing.Size(330, 30);
            this.departureDateTP.TabIndex = 5;
            // 
            // arrivalDateTP
            // 
            this.arrivalDateTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDateTP.Location = new System.Drawing.Point(564, 119);
            this.arrivalDateTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.arrivalDateTP.Name = "arrivalDateTP";
            this.arrivalDateTP.Size = new System.Drawing.Size(330, 30);
            this.arrivalDateTP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.label1.Size = new System.Drawing.Size(1073, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capture Rersevation Details:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.guestpnl.Location = new System.Drawing.Point(47, 34);
            this.guestpnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guestpnl.Name = "guestpnl";
            this.guestpnl.Size = new System.Drawing.Size(1219, 661);
            this.guestpnl.TabIndex = 1;
            // 
            // prepagebtn
            // 
            this.prepagebtn.BackColor = System.Drawing.Color.White;
            this.prepagebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prepagebtn.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepagebtn.Location = new System.Drawing.Point(164, 566);
            this.prepagebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prepagebtn.Name = "prepagebtn";
            this.prepagebtn.Size = new System.Drawing.Size(192, 83);
            this.prepagebtn.TabIndex = 14;
            this.prepagebtn.Text = "Prevoius Page";
            this.prepagebtn.UseVisualStyleBackColor = false;
            this.prepagebtn.Click += new System.EventHandler(this.prepagebtn_Click);
            // 
            // confirmGbtn
            // 
            this.confirmGbtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.confirmGbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmGbtn.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmGbtn.Location = new System.Drawing.Point(866, 568);
            this.confirmGbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmGbtn.Name = "confirmGbtn";
            this.confirmGbtn.Size = new System.Drawing.Size(217, 81);
            this.confirmGbtn.TabIndex = 13;
            this.confirmGbtn.Text = "Confirm Guest";
            this.confirmGbtn.UseVisualStyleBackColor = false;
            this.confirmGbtn.Click += new System.EventHandler(this.confirmGbtn_Click);
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(477, 347);
            this.addresstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(455, 140);
            this.addresstxt.TabIndex = 12;
            this.addresstxt.TextChanged += new System.EventHandler(this.addresstxt_TextChanged);
            // 
            // lNametxt
            // 
            this.lNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNametxt.Location = new System.Drawing.Point(477, 168);
            this.lNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lNametxt.Name = "lNametxt";
            this.lNametxt.Size = new System.Drawing.Size(398, 34);
            this.lNametxt.TabIndex = 10;
            // 
            // idNotxt
            // 
            this.idNotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNotxt.Location = new System.Drawing.Point(477, 276);
            this.idNotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idNotxt.Name = "idNotxt";
            this.idNotxt.Size = new System.Drawing.Size(398, 34);
            this.idNotxt.TabIndex = 9;
            // 
            // phoneNotxt
            // 
            this.phoneNotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNotxt.Location = new System.Drawing.Point(477, 221);
            this.phoneNotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneNotxt.Name = "phoneNotxt";
            this.phoneNotxt.Size = new System.Drawing.Size(324, 34);
            this.phoneNotxt.TabIndex = 8;
            // 
            // fNametxt
            // 
            this.fNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNametxt.Location = new System.Drawing.Point(477, 100);
            this.fNametxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fNametxt.Name = "fNametxt";
            this.fNametxt.Size = new System.Drawing.Size(398, 34);
            this.fNametxt.TabIndex = 7;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(194, 347);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(129, 32);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Address:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(194, 287);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(162, 32);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "ID number:";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(194, 226);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(218, 32);
            this.lblphone.TabIndex = 3;
            this.lblphone.Text = "Phone number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(194, 170);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(160, 32);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "Last Name:";
            // 
            // lblfname
            // 
            this.lblfname.AutoSize = true;
            this.lblfname.Font = new System.Drawing.Font("Eras Demi ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfname.Location = new System.Drawing.Point(191, 102);
            this.lblfname.Name = "lblfname";
            this.lblfname.Size = new System.Drawing.Size(163, 32);
            this.lblfname.TabIndex = 1;
            this.lblfname.Text = "First Name:";
            this.lblfname.Click += new System.EventHandler(this.lblfname_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Eras Demi ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 10);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(300, 0, 300, 0);
            this.label5.Size = new System.Drawing.Size(978, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Capture Guest Details:";
            // 
            // MakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1352, 708);
            this.Controls.Add(this.guestpnl);
            this.Controls.Add(this.Rersevationpnl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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