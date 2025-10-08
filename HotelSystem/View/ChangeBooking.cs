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

        private DateTime checkInDate;
        private DateTime checkOutDate;
        private string reservationID;
        private string guestID;
        private int room;
        public enum DateChecker { invalidDate = 0, validDate = 1  }
        DateChecker pickedDate;


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
            Random rnd = new Random();// Generate 0 or 1 randomly
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
            DateTime checkInDate = CheckInPicker.Value.Date;
            DateChecking();

        }

        private void CheckOutPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkOutDate = CheckOutPicker.Value.Date;
        }

        private void reservationIDTextBox_TextChanged(object sender, EventArgs e)
        {
            string reservationID = reservationIDTextBox.Text;
        }

        #endregion

        #region Confirm Button
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (pickedDate == DateChecker.invalidDate)
            {
                MessageBox.Show("Invalid Reservation Date: Must book 14 days in advance.");

            }
            if (pickedDate == DateChecker.validDate)
            {
                MainPanel.Visible = false;
                RoomFoundPanel.Visible = true;
            }
        }

        #endregion

        // [1[1, 2, 3, 4, 5, 6, 7, 8], 2[], 3[], 4[], 5[]]
        // room, day
        // day, room
        // [1[1, 2, 3, 4, 5], 2[], 3[], 4[], 5[]]


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChangeBooking_Load(object sender, EventArgs e)
        {

        }

        
    }
}
