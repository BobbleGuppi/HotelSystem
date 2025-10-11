namespace HotelSystem
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingEnquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeGuestBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1365, 44);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.homeToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.BackgroundImage")));
            this.homeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(40, 40);
            this.homeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            this.manageGuestBookingsToolStripMenuItem.Size = new System.Drawing.Size(144, 40);
            this.manageGuestBookingsToolStripMenuItem.Text = "Manage Bookings";
            // 
            // changeGuestBookingToolStripMenuItem
            // 
            this.changeGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.changeGuestBookingToolStripMenuItem.Name = "changeGuestBookingToolStripMenuItem";
            this.changeGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.changeGuestBookingToolStripMenuItem.Text = "Change Guest Booking";
            this.changeGuestBookingToolStripMenuItem.Click += new System.EventHandler(this.changeGuestBookingToolStripMenuItem_Click);
            // 
            // cancelGuestBookingToolStripMenuItem
            // 
            this.cancelGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.cancelGuestBookingToolStripMenuItem.Name = "cancelGuestBookingToolStripMenuItem";
            this.cancelGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.cancelGuestBookingToolStripMenuItem.Text = "Cancel Guest Booking";
            this.cancelGuestBookingToolStripMenuItem.Click += new System.EventHandler(this.cancelGuestBookingToolStripMenuItem_Click);
            // 
            // makeBookingEnquiryToolStripMenuItem
            // 
            this.makeBookingEnquiryToolStripMenuItem.BackColor = System.Drawing.Color.CadetBlue;
            this.makeBookingEnquiryToolStripMenuItem.Name = "makeBookingEnquiryToolStripMenuItem";
            this.makeBookingEnquiryToolStripMenuItem.Size = new System.Drawing.Size(235, 24);
            this.makeBookingEnquiryToolStripMenuItem.Text = "Make Booking Enquiry";
            this.makeBookingEnquiryToolStripMenuItem.Click += new System.EventHandler(this.makeBookingEnquiryToolStripMenuItem_Click);
            // 
            // makeGuestBookingToolStripMenuItem
            // 
            this.makeGuestBookingToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.makeGuestBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeGuestBookingToolStripMenuItem.Name = "makeGuestBookingToolStripMenuItem";
            this.makeGuestBookingToolStripMenuItem.Size = new System.Drawing.Size(162, 40);
            this.makeGuestBookingToolStripMenuItem.Text = "Make Guest Booking";
            this.makeGuestBookingToolStripMenuItem.Click += new System.EventHandler(this.makeGuestBookingToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 40);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleLabel.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.CadetBlue;
            this.titleLabel.Location = new System.Drawing.Point(29, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(648, 144);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "@Phumla Kamnandi \r\n               Hotel\r\n";
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Location = new System.Drawing.Point(303, 256);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(713, 179);
            this.titlePanel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 63);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.PowderBlue;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 40);
            this.toolStripMenuItem1.Text = "Reports";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 24);
            this.toolStripMenuItem2.Text = "Occupancy Report";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.CadetBlue;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 24);
            this.toolStripMenuItem3.Text = "Guest Loyalty Report";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 749);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

