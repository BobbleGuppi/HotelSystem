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
        public Home()
        {
            InitializeComponent();
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
            // Attach new child
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;  // no border/title
            frm.Dock = DockStyle.Fill;                   // fill the MDI area
            frm.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void changeGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeBooking frm = new ChangeBooking();
            frm.MdiParent = this;
            frm.Show();//can't use ShowDialog as it will block the parent form.
        }

        private void cancelGuestBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelBooking frm = new CancelBooking();
            frm.MdiParent = this;
            frm.Show();
        }

        private void makeBookingEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingEnquiry frm = new BookingEnquiry();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
