using HotelSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class Home : Form
    {

        private ChangeBooking changeBookingForm; // store the single instance

        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void makeGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeBooking frm = new MakeBooking();
            frm.MdiParent = this;   
            frm.Show();


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region Change Guest Booking Functionality
        private void changeGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changeBookingForm == null || changeBookingForm.IsDisposed)
            {
                changeBookingForm = new ChangeBooking();
                changeBookingForm.WindowState = FormWindowState.Maximized;
                changeBookingForm.MdiParent = this;
                changeBookingForm.Show();
                changeBookingForm.BringToFront();
            }
            else
            {
                changeBookingForm.BringToFront(); // just focus the existing one
            }

        }
        #endregion

        private void cancelGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelBooking frm = new CancelBooking();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void makeBookingEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            BookingEnquiry frm = new BookingEnquiry();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

        }

        // Add this method to your Home class
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // You can handle the item click event here if needed
            // For now, leave it empty or add your logic
        }

    }
}
