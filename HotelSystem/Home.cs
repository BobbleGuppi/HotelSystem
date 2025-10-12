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
        #region Fields
        private ChangeBooking changeBookingForm; // store the single instance
        private BookingEnquiry enquiryForm;
        private CancelBooking cancelBookingForm;
        private MakeBooking makeBookingForm;
        private OccupancyReport summaryReportWin;
        private LoyaltyReport exceptionReportWin;
        private HelpForm helpWindow;
        #endregion

        #region Constructor
        public Home()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Make sure this form is an MDI container
            this.IsMdiContainer = true;

            // Handle when a child form is opened or closed
            this.MdiChildActivate += Home_MdiChildActivate;

        }
        #endregion

        #region Utility Methods

        private void Home_MdiChildActivate(object sender, EventArgs e)
        {
            // When any MDI child form is open
            if (this.ActiveMdiChild != null)
            {
                // Hide the home panel/label
                titlePanel.Visible = false;
            }
            else
            {
                // No child forms — show it again
                titlePanel.Visible = true;
                titlePanel.BringToFront();

            }


        }
        #endregion

        #region Child Form Functionality

        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
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
                changeBookingForm.BringToFront(); 
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
                cancelBookingForm.BringToFront(); 
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
                enquiryForm.BringToFront(); 
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
                makeBookingForm.BringToFront(); 
            }



        }

        private void summaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (summaryReportWin == null || summaryReportWin.IsDisposed)
            {
                summaryReportWin = new OccupancyReport();
                summaryReportWin.WindowState = FormWindowState.Maximized;
                summaryReportWin.MdiParent = this;
                summaryReportWin.Show();
                summaryReportWin.BringToFront();
            }
            else
            {
                summaryReportWin.BringToFront(); 
            }
        }

        private void exceptionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllChildForms();
            if (exceptionReportWin == null || exceptionReportWin.IsDisposed)
            {
                exceptionReportWin = new LoyaltyReport();
                exceptionReportWin.WindowState = FormWindowState.Maximized;
                exceptionReportWin.MdiParent = this;
                exceptionReportWin.Show();
                exceptionReportWin.BringToFront();
            }
            else
            {
                exceptionReportWin.BringToFront(); 
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            if (helpWindow == null || helpWindow.IsDisposed)
            {
                helpWindow = new HelpForm();
                helpWindow.WindowState = FormWindowState.Maximized;
                helpWindow.MdiParent = this;
                helpWindow.Show();
                helpWindow.BringToFront();
            }
            else
            {
                exceptionReportWin.BringToFront();
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Open Occupancy Report
            CloseAllChildForms();
            if (summaryReportWin == null || summaryReportWin.IsDisposed)
            {
                summaryReportWin = new OccupancyReport();
                summaryReportWin.WindowState = FormWindowState.Maximized;
                summaryReportWin.MdiParent = this;
                summaryReportWin.Show();
                summaryReportWin.BringToFront();
            }
            else
            {
                summaryReportWin.BringToFront();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Open Loyalty Report
            CloseAllChildForms();
            if (exceptionReportWin == null || exceptionReportWin.IsDisposed)
            {
                exceptionReportWin = new LoyaltyReport();
                exceptionReportWin.WindowState = FormWindowState.Maximized;
                exceptionReportWin.MdiParent = this;
                exceptionReportWin.Show();
                exceptionReportWin.BringToFront();
            }
            else
            {
                exceptionReportWin.BringToFront();
            }
        }
        #endregion

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


        // Add this method to your Home class
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // You can handle the item click event here if needed
            // For now, leave it empty or add your logic
        }

    }


}
