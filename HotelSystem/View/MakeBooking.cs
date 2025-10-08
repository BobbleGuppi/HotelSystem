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

    
            MessageBox.Show($"Checking room availability from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()} ");

        }
    }
}
