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
using static HotelSystem.Database.DB;

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
        private Reservation myReservation;
        private bool roomAvail;
        private Random rnd = new Random(); // declare at class level

        #endregion

        #region Constructor
        public ChangeBooking()
        {
            InitializeComponent();
            MainPanel.Visible = true;
            RoomFoundPanel.Visible = false;
            res_cntrllr = new ReservationController();
        }
        #endregion

        #region Utility Methods
        public void DateChecking() 
        {
            int randomValue = rnd.Next(0, 2);  // 0 (inclusive) to 2 (exclusive)
            pickedDate = (DateChecker)randomValue; // Convert to enum

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
            reservationID = reservationIDTextBox.Text.Trim();
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
                        
                        roomAvail = res_cntrllr.RoomAvailable(checkInDate, checkOutDate); // returns room

                        if (!roomAvail)
                        {
                            MessageBox.Show("No Rooms Available on these Dates.");
                            return;
                        }
                        else 
                        {
                            DataTable previewTable = new DataTable();

                            // Define columns
                            previewTable.Columns.Add("ReservationID", typeof(string));
                            previewTable.Columns.Add("CheckInDate", typeof(DateTime));
                            previewTable.Columns.Add("CheckOutDate", typeof(DateTime));

                            // Add a demo row
                            previewTable.Rows.Add(reservationID, checkInDate, checkOutDate);

                            dataGridView1.DataSource = previewTable;


                            // Switch panels to show preview
                            MainPanel.Visible = false;
                            RoomFoundPanel.Visible = true;
                        }

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
            //Warning!! Original reservation will be updated. This is irreversible. Confirm new update?

            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                "Warning!! Original reservation will be updated.\n" +
                "This is irreversible.\n" +
                "Confirm reservation to be updated?\r\n", // Message
                "Confirm Change",                      // Title
                MessageBoxButtons.YesNo,               // Yes/No buttons
                MessageBoxIcon.Question                // Optional icon
            );

            if (result == DialogResult.Yes)
            {
                // Update in-memory object
                myReservation.changeReservationDates(checkInDate, checkOutDate);

                // Update the DataSet
                res_cntrllr.reservationDB.DataSetChange(myReservation, DB.DBOperation.Edit);

                // Push the changes to the database via DataAdapter
                bool success = res_cntrllr.FinalizeChanges(myReservation);

                if (success)
                {
                    MessageBox.Show("Reservation successfully updated!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update reservation.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Change Booking Cancelled.");
                this.Close();
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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
