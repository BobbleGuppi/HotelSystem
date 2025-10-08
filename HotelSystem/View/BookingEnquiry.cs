using HotelSystem.Logic;
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
   
    public partial class BookingEnquiry : Form
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        private ReservationController reservationController;
        private Reservation reservation;
        public BookingEnquiry()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            this.Load += BookingEnquiry_Load;
            this.Resize += BookingEnquiry_Resize;
            reservationInfo.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;

        }

        private void BookingEnquiry_ResizeEvent(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void reservLabel_Click(object sender, EventArgs e)
        {

        }

        private void RIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string reservationId = richTextBox1.Text;
            panel1.Visible = false;
            panel2.Visible = true;

            reservation = reservationController.find(reservationId);
            reservationInfo.Size = new Size(900, 450);
            reservationInfo.Font = new Font("Segoe UI", 24, FontStyle.Regular);
            CenterPanel();

            if (reservation != null) {
                reservationInfo.AppendText("=== Reservation Details ===\n");
                reservationInfo.AppendText($"Reservation ID: {reservation.ReservationID}\n");
                reservationInfo.AppendText($"Guest ID:       {reservation.GuestID}\n");
                reservationInfo.AppendText($"Check-In Date:  {reservation.CheckInDate:d}\n");
                reservationInfo.AppendText($"Check-Out Date: {reservation.CheckOutDate:d}\n");
                reservationInfo.AppendText($"Total Price:    R{reservation.totalPrice:F2}\n");
                reservationInfo.AppendText($"Deposit Paid:   {(reservation.DepositPaid ? "Yes" : "No")}\n");
                reservationInfo.AppendText("===========================\n");
                reservationInfo.Visible = true;
            }
            else {                 
                reservationInfo.AppendText("No reservation found with the provided ID.\n");
                reservationInfo.Visible = true;
            }

        }

        private void CenterPanel()
        {
            panel2.Location = new Point(
                (this.ClientSize.Width - panel2.Width) / 2,
                (this.ClientSize.Height - panel2.Height) / 2
            );
        }

        private void BookingEnquiry_Load(object sender, EventArgs e)
        {
            originalFormSize = this.ClientSize;

            foreach (Control c in panel1.Controls)
            {
                controlBounds[c] = c.Bounds;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingEnquiry_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
            
            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float yRatio = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (Control ctrl in panel1.Controls)
            {
                Rectangle orig = controlBounds[ctrl];
                ctrl.Width = (int)(orig.Width * xRatio);
                ctrl.Height = (int)(orig.Height * yRatio);
                ctrl.Left = (int)(orig.Left * xRatio);
                ctrl.Top = (int)(orig.Top * yRatio);
            }

            // Resize the panel to fill the form
            panel1.Width = this.ClientSize.Width;
            panel1.Height = this.ClientSize.Height;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void prevButton_Click(object sender, EventArgs e)
        {

        }
    }
}
