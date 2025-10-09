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
        private BookingEnquiry enquiryForm;
        private CancelBooking cancelBookingForm;
        private MakeBooking makeBookingForm;
        private SummaryReport summaryReportWin;

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        #region Child Form Functionality

        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void changeGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
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

        private void cancelGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (cancelBookingForm == null || cancelBookingForm.IsDisposed)
            {
                cancelBookingForm = new CancelBooking();
                cancelBookingForm.WindowState = FormWindowState.Maximized;
                cancelBookingForm.MdiParent = this;
                cancelBookingForm.Show();
                cancelBookingForm.BringToFront();
            }
            else
            {
                cancelBookingForm.BringToFront(); // just focus the existing one
            }
        }

        private void makeBookingEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (enquiryForm == null || enquiryForm.IsDisposed)
            {
                enquiryForm = new BookingEnquiry();
                enquiryForm.WindowState = FormWindowState.Maximized;
                enquiryForm.MdiParent = this;
                enquiryForm.Show();
                enquiryForm.BringToFront();
            }
            else
            {
                enquiryForm.BringToFront(); // just focus the existing one
            }

        }

        private void makeGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (makeBookingForm == null || makeBookingForm.IsDisposed)
            {
                makeBookingForm = new MakeBooking();
                makeBookingForm.WindowState = FormWindowState.Maximized;
                makeBookingForm.MdiParent = this;
                makeBookingForm.Show();
                makeBookingForm.BringToFront();
            }
            else
            {
                makeBookingForm.BringToFront(); // just focus the existing one
            }



        }

        private void summaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (summaryReportWin == null || summaryReportWin.IsDisposed)
            {
                summaryReportWin = new SummaryReport();
                summaryReportWin.WindowState = FormWindowState.Maximized;
                summaryReportWin.MdiParent = this;
                summaryReportWin.Show();
                summaryReportWin.BringToFront();
            }
            else
            {
                summaryReportWin.BringToFront(); // just focus the existing one
            }
        }


        #endregion
        // Add this method to your Home class
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // You can handle the item click event here if needed
            // For now, leave it empty or add your logic
        }

        
    }
}
