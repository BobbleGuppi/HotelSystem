namespace HotelSystem
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.manageGuestBookingsToolStripMenuItem,
            this.makeGuestBookingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1379, 44);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.homeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(40, 40);
            // 
            // manageGuestBookingsToolStripMenuItem
            // 
            this.manageGuestBookingsToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.manageGuestBookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGuestBookingToolStripMenuItem,
            this.cancelGuestBookingToolStripMenuItem,
            this.makeBookingEnquiryToolStripMenuItem});
            this.manageGuestBookingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageGuestBookingsToolStripMenuItem.Name = "manageGuestBookingsToolStripMenuItem";
            this.manageGuestBookingsToolStripMenuItem.Size = new System.Drawing.Size(179, 40);
            this.manageGuestBookingsToolStripMenuItem.Text = "Manage Bookings";
            // 
            // changeGuestBookingToolStripMenuItem
            // 
            this.changeGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.changeGuestBookingToolStripMenuItem.Name = "changeGuestBookingToolStripMenuItem";
            this.changeGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.changeGuestBookingToolStripMenuItem.Text = "Change Guest Booking";
            // 
            // cancelGuestBookingToolStripMenuItem
            // 
            this.cancelGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.cancelGuestBookingToolStripMenuItem.Name = "cancelGuestBookingToolStripMenuItem";
            this.cancelGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.cancelGuestBookingToolStripMenuItem.Text = "Cancel Guest Booking";
            // 
            // makeBookingEnquiryToolStripMenuItem
            // 
            this.makeBookingEnquiryToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.makeBookingEnquiryToolStripMenuItem.Name = "makeBookingEnquiryToolStripMenuItem";
            this.makeBookingEnquiryToolStripMenuItem.Size = new System.Drawing.Size(292, 30);
            this.makeBookingEnquiryToolStripMenuItem.Text = "Make Booking Enquiry";
            // 
            // makeGuestBookingToolStripMenuItem
            // 
            this.makeGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.makeGuestBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeGuestBookingToolStripMenuItem.Name = "makeGuestBookingToolStripMenuItem";
            this.makeGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.makeGuestBookingToolStripMenuItem.Text = "Make Guest Booking";
            this.makeGuestBookingToolStripMenuItem.Click += new System.EventHandler(this.makeGuestBookingToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.reportsToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(92, 40);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(157, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 272);
            this.label1.TabIndex = 8;
            this.label1.Text = "@Phumula Kamndandi ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(484, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 272);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hotel";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(783, 438);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(104, 87);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 692);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageGuestBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGuestBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelGuestBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookingEnquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeGuestBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

