using HotelSystem.Database;
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
    public partial class ChangeBooking : Form
    {

        #region Fields

        // dates
        private DateTime checkInDate;
        private DateTime checkOutDate;

        // ids
        private string reservationID;

        // dateChecker enum & variable
        public enum DateChecker { invalidDate = 0, validDate = 1  }
        DateChecker pickedDate;

        // controller
        private ReservationController res_cntrllr;

        // needed helper variables
        Reservation myReservation;
        bool roomAvail;
        private Random rnd = new Random(); // declare at class level

        #endregion

        #region Constructor
        public ChangeBooking()
        {
            InitializeComponent();
            MainPanel.Visible = true;
            RoomFoundPanel.Visible = false;
        }
        #endregion

        #region Utility Methods
        public void DateChecking() 
        {
            int randomValue = rnd.Next(0, 2);  // 0 (inclusive) to 2 (exclusive)
            pickedDate = (DateChecker)randomValue; // Convert to enum

        }
        public void findGuestID() 
        {
        
        }
        #endregion

        #region Get User Input
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            checkInDate = CheckInPicker.Value.Date; // assign to the field
        }

        private void CheckOutPicker_ValueChanged(object sender, EventArgs e)
        {
            checkOutDate = CheckOutPicker.Value.Date; // assign to the field

        }

        private void reservationIDTextBox_TextChanged(object sender, EventArgs e)
        {
            reservationID = reservationIDTextBox.Text;
        }

        #endregion

        #region FirstConfirm Button
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DateChecking(); // generate random 14-days deadline

            // Error handling for guest that picks a non-December month
            if (checkInDate.Month != 12 || checkOutDate.Month != 12)
            {
                MessageBox.Show("You can only select December!", "Invalid Date Selected");
                return;
            }

            // Check if the reservation is in the database
            myReservation = res_cntrllr.find(reservationID);
            if (myReservation == null)
            {
                MessageBox.Show("Reservation ID not found", "Invalid Reservation ID");
                return;
            }

            // if reservation found
            else
            {
                // First check if 14 days in advance or not
                if (pickedDate == DateChecker.invalidDate)
                {
                    MessageBox.Show("Invalid Reservation Date: Must book 14 days in advance.", "Invalid Date Selected");
                    return;

                }

                else
                {
                    if (pickedDate == DateChecker.validDate)
                    {
                        res_cntrllr = new ReservationController();
                        roomAvail = res_cntrllr.RoomAvailable(checkInDate, checkOutDate); // returns room

                        if (!roomAvail)
                        {
                            MessageBox.Show("No Rooms Available on these Dates.");
                            return;
                        }

                        // 4. Create a **demo reservation** (preview) without touching DB
                        Reservation demoRes = Reservation(
                            myReservation.ReservationID,
                            myReservation.RoomID,
                            myReservation.Guest,
                            checkInDate,
                            checkOutDate,
                            myReservation.DepositPaid
                        );

                        // 5. Add to a local list for the DataGridView
                        List<Reservation> previewList = new List<Reservation> { demoRes };
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = previewList;

                        // Switch panels to show preview
                        MainPanel.Visible = false;
                        RoomFoundPanel.Visible = true;

                    }

                }
            }
        }

        #endregion

        #region CancelChange Button
        private void button1_Click(object sender, EventArgs e)
        {
            reservationIDTextBox.Text = "";
            this.Close();
        }
        #endregion

        #region ConfirmChange Button
        private void confirmChangeButton_Click(object sender, EventArgs e)
        {
            if (myReservation == null)
            {
                MessageBox.Show("No reservation selected.");
                return;
            }

            // 1. Call controller to update reservation (DB + in-memory collection)
            bool success = res_cntrllr.EditReservationDates(reservationID, checkInDate, checkOutDate);

            if (success)
            {
                MessageBox.Show("Reservation updated successfully!", "Success");

                // 2. Refresh DataGridView with updated reservation (optional)
                Reservation updated = res_cntrllr.find(reservationID);
                List<Reservation> updatedList = new List<Reservation> { updated };
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = updatedList;

                // 3. Switch panels back
                RoomFoundPanel.Visible = false;
                MainPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed to update reservation. Check Reservation ID.", "Error");
            }
        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangeBooking_Load(object sender, EventArgs e)
        {

        }

        
    }
}
