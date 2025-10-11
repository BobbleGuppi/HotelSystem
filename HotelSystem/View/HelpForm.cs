using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.View
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            // --- Header ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 14, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.SteelBlue;
            richTextBox1.AppendText("🛈 Welcome to the Hotel Booking System Guide!!\n\n");

            // --- Intro paragraph ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("Use this screen as a help reference. Here’s what each button does:\n\n");

            // --- Manage Bookings Header ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.SteelBlue;
            richTextBox1.AppendText("Manage Bookings:\n\n");

            // --- Make Booking ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("   ✦ Make Booking – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Create a new reservation for a guest.\n\n");

            // --- Change Booking ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("   ✦ Change Booking – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Allows you to search for an existing booking and modify its check-in & check-out dates.\n\n");

            // --- Cancel Booking ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("   ✦ Cancel Booking – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Lets you cancel an existing booking. You’ll be asked to confirm before the booking is removed.\n\n");

            // --- Reports Header ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.SteelBlue;
            richTextBox1.AppendText("Reports:\n\n");

            // --- Guest Loyalty Report ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.AppendText("    ✦ Guest Loyalty Report – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Generates a summary showing how often guests have stayed at the hotel.\n\n");

            // --- Occupancy Report ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("    ✦ Occupancy Report – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Displays room occupancy statistics for a selected date range.\n\n");

            // --- Booking Enquiry ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("Booking Enquiry – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Displays details of a booking based on a Reservation ID.\n\n");

            // --- Home ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("Home – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Returns you to the home screen.\n\n");

            // --- Exit ---
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richTextBox1.AppendText("Exit – ");
            richTextBox1.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            richTextBox1.AppendText("Closes the system safely.\n");
        }
    }
}
