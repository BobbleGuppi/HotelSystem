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
using HotelSystem.Database;

namespace HotelSystem.View
{
    public partial class CancelBooking : Form
    {
        private ReservationController Rcontroller;
        private Reservation foundReservation;
        private ReservationDB reservationDB;
        private GuestController guestController;
        private Guest foundGuest;

        private int screen = 0; // from home screen we have the first 'screen = 0, the 2nd screeen = 1, the last screen = 2

        public CancelBooking()
        {
            InitializeComponent();
            Rcontroller = new ReservationController();
            reservationDB = new ReservationDB();
            guestController = new GuestController();
            // make the controls invisible for later
            richTextBox1.Visible = false;
            doneButton.Visible = false;
            
        }

        

        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            if (screen == 0)
            {
                //now read the reservationId text
                string reservationid = textBoxForReservationID.Text.Trim();

                foundReservation = Rcontroller.find(reservationid); // will return the reservation object that matches the reservationid


                if (foundReservation != null)
                {
                    foundGuest = guestController.find(foundReservation.Guest); // will return a Guest object that matches the guestid

                    reservationNumLabel.Visible = false;
                    reservationIDinputLabel.Visible = false;
                    textBoxForReservationID.Visible = false;

                    richTextBox1.Visible = true;
                    richTextBox1.Text = $"Guest Booking found!\nDo you wish to proceed to cancel the existing guest booking?:\n\t" + foundGuest.displayInfo();

                    screen = 1; // go to the next screen

                }
                else
                {
                    MessageBox.Show("Reservation not found.\nNote:ID is made from Guest initials, Month, Start Date and number of days reserved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (screen == 1)
            {
                richTextBox1.Text = $"Warning! Guest booking for ({foundReservation.ReservationID}) will be cancelled. This action cannot be undone.\nAre you sure you want to cancel this guest booking?";
                screen = 2; // next
            }
            else if (screen == 2)
            {
                Rcontroller.DataMaintenance(foundReservation, DB.DBOperation.Delete); // we delete the reservation 

                richTextBox1.Text = $"Guest booking ({foundReservation.ReservationID}) has been successfully cancelled! Hotel occupancy levels have been adjusted accordingly.";

                ConfirmButton.Visible = false;
                prevPageButton.Visible = false;
                doneButton.Visible = true;
            }





        }
        

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close(); // go back to home
        }

        private void prevPageButton_Click(object sender, EventArgs e)
        {
            if (screen ==1)
            {
                richTextBox1.Visible = false;
                textBoxForReservationID.Visible = true;
                reservationIDinputLabel.Visible = true;
                ConfirmButton.Visible = true;
                prevPageButton.Visible = true;
                doneButton.Visible= false;

                screen = 0;

            }
            if (screen == 2)
            {
                richTextBox1.Text = $"Guest Booking found!\nDo you wish to proceed to cancel the existing guest booking?:\n\t" + foundGuest.displayInfo();

                screen = 1;
            }
            
        }
    }
}
