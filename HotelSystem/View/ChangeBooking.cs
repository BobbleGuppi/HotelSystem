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
        private Random rnd = new Random();
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
            string reservationID = reservationIDTextBox.Text;
        }

        #endregion

        #region FirstConfirm Button
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            DateChecking();

            if (checkInDate.Month != 12 || checkOutDate.Month != 12)
            {
                MessageBox.Show("You can only select December!");
                return;
            }

            else
            {
                if (pickedDate == DateChecker.invalidDate)
                {
                    MessageBox.Show("Invalid Reservation Date: Must book 14 days in advance.");
                    return;

                }
                if (pickedDate == DateChecker.validDate)
                {
                    res_cntrllr = new ReservationController();
                    roomAvail = res_cntrllr.RoomAvailable(checkInDate, checkOutDate);

                    if (roomAvail)
                    {

                        List<Reservation> reservations = new List<Reservation>()
                    {
                        new Reservation(reservationID,1,"G000", DateTime.Today,DateTime.Today.AddDays(1),0.0,false)

                    };

                        // Bind the list to the DataGridView
                        dataGridView1.DataSource = reservations;
                        MainPanel.Visible = false;
                        RoomFoundPanel.Visible = true;
                        myRoom = res_cntrllr.CurrentRoom;
                    }
                    else
                    {
                        MessageBox.Show("No Rooms Available on these Dates.");
                        return;
                    }

                }
            }

            
        }

        #endregion

        #region CancelChange Button
        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region ConfirmChange Button
        private void confirmChangeButton_Click(object sender, EventArgs e)
        {

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
