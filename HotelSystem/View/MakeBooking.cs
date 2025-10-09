using HotelSystem.Database;
using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.View
{
    public partial class MakeBooking : Form
    {
        private static readonly Random rand = new Random();
        private DateTime arrivalDate;
        private DateTime departureDate;
        private ReservationController reservationController;
        private GuestController guestController;
        private GuestAccountController guestAccountController;

        public MakeBooking()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            guestController = new GuestController();
            guestAccountController = new GuestAccountController();
            confirmRbtn.Visible = false;
        }

        private void MakeBooking_Load(object sender, EventArgs e)
        {
            Rersevationpnl.Visible = true;
            CenterPanel(Rersevationpnl);
            guestpnl.Visible = false;
        }

        private void availabilitybtn_Click(object sender, EventArgs e)
        {
            arrivalDate = arrivalDateTP.Value;
            departureDate = departureDateTP.Value;
            if (!ValidateDates(arrivalDate, departureDate))
            {
                return; // Stop if invalid
            }

            bool availability = reservationController.RoomAvailable(arrivalDate, departureDate);
            MessageBox.Show($"Checking room availability from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()} ");

            if (availability)
            {
                MessageBox.Show("A room is available for the selected dates!", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                confirmRbtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Sorry, no rooms are available for those dates,change date", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void confirmRbtn_Click(object sender, EventArgs e)
        {
            // Show a friendly confirmation dialog before proceeding
            string message = $"You selected:\n\n" +
                             $"🗓 Arrival Date: {arrivalDate.ToLongDateString()}\n" +
                             $"🏁 Departure Date: {departureDate.ToLongDateString()}\n\n" +
                             $"Are you sure you want to continue with these dates?";

            DialogResult result = MessageBox.Show(
                message,
                "Confirm Booking Dates",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Proceed to the next panel (guest details)
                guestpnl.Visible = true;
                CenterPanel(guestpnl);
                Rersevationpnl.Visible = false;

                MessageBox.Show("Great! Let's continue with your guest details.",
                    "Proceeding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hide the confirm button and stay on the current panel
                confirmRbtn.Visible = false;
              
                MessageBox.Show("No problem! Please adjust your dates and check availability again.",
                    "Change Dates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void confirmGbtn_Click(object sender, EventArgs e)
        {
            string firstname = fNametxt.Text.Trim();
            string lastname = lNametxt.Text.Trim();
            string phone = phoneNotxt.Text.Trim();
            string id = idNotxt.Text.Trim();
            string address = addresstxt.Text.Trim();
            string fullname = firstname + " " + lastname;
            Guest existingGuest = null;

            try
            {
                existingGuest = guestController.find(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }

            if (existingGuest == null)
            {
                string guestID = GenerateGuestID();
                // Create GuestAccount for the new guest
                string guestAccID = GenerateGuestAccountID();
                DateTime dateCreated = DateTime.Now;
                double totalAmount = 0.0;
                string status = "Unpaid";
                GuestAccount newGuestAccount = new GuestAccount(guestAccID, guestID, dateCreated, totalAmount, status);

                try
                {
                    guestAccountController.DataMaintenance(newGuestAccount, DB.DBOperation.Add);
                   bool savedaccount= guestAccountController.FinalizeChanges(newGuestAccount);
                if (!savedaccount)
                    {
                        MessageBox.Show("Failed to save new guest account.");
                        return;
                    }
                    else {  MessageBox.Show("New guest account added successfully!"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add new guest account: " + ex.Message);
                    return;
                }

     
                Guest newGuest = new Guest(id, fullname, phone, address, guestID, guestAccID);

                try
                {
                    guestController.DataMaintenance(newGuest, DB.DBOperation.Add);
                    bool saved=guestController.FinalizeChanges(newGuest);
                    if (!saved)
                    {
                        MessageBox.Show("Failed to save new guest.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("New guest and guest account added successfully!");
                        CreateReservation(newGuest, newGuestAccount);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add new guest: " + ex.Message);
                }
            }
            else
            {
                // Find or create GuestAccount for existing guest
               
                    string guestAccID = GenerateGuestAccountID();
                    DateTime dateCreated = DateTime.Now;
                    double totalAmount = 0.0;
                    string status = "Unpaid";
                    GuestAccount guestAccount = new GuestAccount(guestAccID, existingGuest.GuestID, dateCreated, totalAmount, status);
                try
                    {
                        guestAccountController.DataMaintenance(guestAccount, DB.DBOperation.Add);
                        guestAccountController.FinalizeChanges(guestAccount);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to add guest account for existing guest: " + ex.Message);
                        return;
                    }
               

                MessageBox.Show("Guest already exists. Proceeding to reservation...");
                CreateReservation(existingGuest, guestAccount);
            }
        }

        #region utility methods 

        private void CenterPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
        }

        private string GenerateGuestID()
        {
            int randomPart = rand.Next(10, 100); // 3-digit random number
            int timePart = DateTime.Now.Millisecond; // changes every millisecond
            int sum = randomPart + timePart; // simple math sum

            return "GT" + sum; // combine
        }

        private string GenerateGuestAccountID()
        {
            int randomPart = rand.Next(100, 999); // 4-digit random
            int timePart = (int)(DateTime.Now.Ticks % 10000); // last 4 digits of time
            int sum = randomPart + timePart; // add them together

            return "GA" + sum;
        }

        private bool ValidateDates(DateTime arrival, DateTime departure)
        {
            // Check if arrival is in the past
            if (arrival.Date < DateTime.Today)
            {
                MessageBox.Show("Arrival date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if departure is before or the same as arrival
            if (departure <= arrival)
            {
                MessageBox.Show("Departure date must be after the arrival date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if booking is made at least 2 days in advance
            if ((arrival - DateTime.Today).TotalDays < 2)
            {
                MessageBox.Show("Bookings must be made at least 2 days in advance.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check if both arrival and departure are in December
            if (arrival.Month != 12 || departure.Month != 12)
            {
                MessageBox.Show("Bookings can only be made for December.", "Invalid Month", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // All checks passed
            return true;
        }


        #endregion

        private void CreateReservation(Guest guest, GuestAccount guestAccount)
        {

            string reservationId = "R" + new Random().Next(1000, 9999);

            string guestId = guest.GuestID;
            double totalPrice = 0.0;
            bool depositPaid = false;

            Reservation reservation = new Reservation(reservationId, guestId, arrivalDate, departureDate, totalPrice, depositPaid);
            reservation.calculateTotalPrice(arrivalDate, departureDate);

            MessageBox.Show($"Total price for stay: R{reservation.totalPrice}", "Total Price");
            try
            {
                reservationController.DataMaintenance(reservation, DB.DBOperation.Add);
                bool savedReser = reservationController.FinalizeChanges(reservation);
                if (!savedReser)
                {
                    MessageBox.Show("Failed to save reservation.");
                    return;
                }
                else
                {
                    MessageBox.Show("Reservation successfully created!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create reservation: " + ex.Message);
            }
        }

        private void Rersevationpnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
