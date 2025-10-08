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
    public partial class CancelBooking : Form
    {
        public CancelBooking()
        {
            InitializeComponent();
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            textBoxForReservationID.Visible = false;

            //now read the reservationId text
            string reservationid = textBoxForReservationID.Text;

            //ReservationController.find(reservationid);




        }

        private void textBoxForReservationID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
