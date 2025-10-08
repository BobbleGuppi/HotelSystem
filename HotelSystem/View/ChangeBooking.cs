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

        private DateTime checkInDate;
        private DateTime checkOutDate;
        private string reservationID;
        private string guestID;
        private int room;
        public enum DateChecker { invalidDate = 0, validDate = 1  }
        DateChecker pickedDate;
        private ReservationController res_cntrllr;
        bool roomAvail;
        private string myRoom;


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
            if (checkInDate.Month != 12)
            {
                MessageBox.Show("You can only select December!");
                return;
            }
            DateChecking();

        }

        private void CheckOutPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime checkOutDate = CheckOutPicker.Value.Date;
            if (checkOutDate.Month != 12)
            {
                MessageBox.Show("You can only select December!");
                return;
            }
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
                res_cntrllr = new ReservationController();
                roomAvail = res_cntrllr.RoomAvailable(checkInDate, checkOutDate);

                if (roomAvail)
                {
                    myRoom = res_cntrllr.CurrentRoom;
                    MainPanel.Visible = false;
                    RoomFoundPanel.Visible = true;
                }
                else 
                {
                    MessageBox.Show("No Rooms Available on these Dates.");
                    return;
                }

            }
        }

        #endregion

     

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
