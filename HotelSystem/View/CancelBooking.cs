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

        private int screen = 0;
        // 0 = enter ID screen
        // 1 = show booking found confirmation
        // 2 = final delete confirmation

        public CancelBooking()
        {
            InitializeComponent();
            Rcontroller = new ReservationController();
            reservationDB = new ReservationDB();
            guestController = new GuestController();

            // Initial state
            ResetToScreen0();
        }

        private void CancelBooking_Load(object sender, EventArgs e)
        {
            ResetToScreen0();
        }

        

        public void reservationNumLabel_Click(object sender, EventArgs e)
        {

        }
        private void ConfirmButton_Click_1(object sender, EventArgs e)
        {
            if (screen == 0)
            {
                string reservationid = textBoxForReservationID.Text.Trim();

                if (string.IsNullOrWhiteSpace(reservationid))
                {
                    MessageBox.Show("Reservation ID field must not be empty.",
                        "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foundReservation = Rcontroller.find(reservationid);
                }catch
                {
                    MessageBox.Show("Reservation not found. Please try again.\n\n" +
                        "Note: ID is made from Guest initials, Month, Start Date and number of days reserved.",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                try
                {
                    foundGuest = guestController.find(foundReservation.GuestID);
                }catch
                {
                    MessageBox.Show("Guest could not be found for this reservation.",
                        "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                

                
                ShowScreen1(); // we move to screen 1
            }
            else if (screen == 1)
            {
                
                ShowScreen2(); // we move to screen 2
            }
            else if (screen == 2)
            {
               
                Rcontroller.DataMaintenance(foundReservation, DB.DBOperation.Delete);
                Rcontroller.FinalizeChanges(foundReservation);

                ShowScreen3();
            }
        }

        
        private void prevPageButton_Click(object sender, EventArgs e)
        {
            if (screen == 1)
            {
                
                ResetToScreen0();
            }
            else if (screen == 2)
            {
                
                ShowScreen1();
            }
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void goToHomeCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ResetToScreen0()
        {
            // Input screen visible
            reservationNumLabel.Visible = true;
            reservationIDinputLabel.Visible = true;
            textBoxForReservationID.Visible = true;
            ConfirmButton.Visible = true;

            // Others hidden
            richTextBox1.Visible = false;
            doneButton.Visible = false;
            prevPageButton.Visible = false;
            goToHomeCancelButton.Visible = false;

            screen = 0;
        }

        private void ShowScreen1()
        {
            reservationNumLabel.Visible = false;
            reservationIDinputLabel.Visible = false;
            textBoxForReservationID.Visible = false;
            goToHomeCancelButton.Visible = false;

            richTextBox1.Visible = true;
            richTextBox1.Text =
                $"Guest booking found!\n\nDo you wish to proceed to cancel the existing guest booking?\n\n" +
                $"Full name: {foundGuest.Name}\n" +
                $"Address: {foundGuest.Address}\n" +
                $"ID: {foundGuest.ID}\n\n" +
                $"{foundReservation.reservationDetails()}";

            prevPageButton.Visible = true;
            prevPageButton.Text = "Previous page";
            ConfirmButton.Visible = true;
            ConfirmButton.Text = "Confirm";

            doneButton.Visible = false;
            screen = 1;
        }

        private void ShowScreen2()
        {
            richTextBox1.Visible = true;
            richTextBox1.Text =
                $"\n\nGuest booking for ({foundReservation.ReservationID}) will be cancelled.\n" +
                $"This action cannot be undone.\n\nAre you sure you want to cancel this booking?";

            prevPageButton.Visible = true;
            ConfirmButton.Visible = true;
            ConfirmButton.Text = "Confirm";

            doneButton.Visible = false;
            screen = 2;
        }

        private void ShowScreen3()
        {
            richTextBox1.Text =
                $"\n\nGuest booking ({foundReservation.ReservationID}) has been successfully cancelled!\n\n" +
                $"Hotel occupancy levels have been adjusted accordingly.";

            ConfirmButton.Visible = false;
            prevPageButton.Visible = false;
            doneButton.Visible = true;
            doneButton.Text = "Done";

            screen = 3;
        }
    }
}
