using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Logic;

namespace HotelSystem.View
{
    public partial class MakeBooking : Form
    {
        private ReservationController reservationController;
        public MakeBooking()
        {
            InitializeComponent();
            reservationController = new ReservationController();
        }

        private void MakeBooking_Load(object sender, EventArgs e)
        {
            Rersevationpnl.Visible = true;
            guestpnl.Visible = false;
        }

        private void availabilitybtn_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = arrivalDateTP.Value;
            DateTime departureDate = departureDateTP.Value;

            bool Availability= reservationController.RoomAvailable(arrivalDate,departureDate);
            MessageBox.Show($"Checking room availability from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()} ");

            if (Availability)
            {
                MessageBox.Show("A room is available for the selected dates!", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry, no rooms are available for those dates.", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
