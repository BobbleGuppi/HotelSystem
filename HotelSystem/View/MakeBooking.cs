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
        private PaymentController paymentController;
        private string displayGuest;


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
            //if (!ValidateDates(arrivalDate, departureDate))
            //{
            //    return; // Stop if invalid
            //}

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
                        return;
                    }
                }
                catch (Exception ex)
                {
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
                        MessageBox.Show("New guest added successfully!");
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

        private string GeneratePaymentID()
        {
            int randomPart = rand.Next(10, 100); // 3-digit random number
            int timePart = DateTime.Now.Millisecond; // changes every millisecond
            int sum = randomPart + timePart; // simple math sum

            return "PY" + sum;
        }


        private void CreateReservation(Guest guest, GuestAccount guestAccount)
        {
            int diff = departureDate.Day - arrivalDate.Day;
            string reservationId = ""+fNametxt.Text[0]+ ""+lNametxt.Text[0]+"12"+ arrivalDate.Day+ "-"+ diff;

            string guestId = guest.GuestID;
            string guestAccId = guest.GuestAccount;
            double totalPrice = 0.0;
            bool depositPaid = false;

            Reservation reservation = new Reservation(reservationId, guestId, arrivalDate, departureDate, totalPrice, depositPaid);
            reservation.calculateTotalPrice(arrivalDate, departureDate);

            if (reservation.DepositPaid == true)
            {
                string paymentType = "Deposit";
                string paymentID = GeneratePaymentID();
                Payment payment = new Payment(paymentID, guestId, totalPrice,paymentType, DateTime.Now);
                guestAccount.makeDeposit(paymentID);
            }

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
                    MessageBox.Show("Reservation successfully created!"+reservation.reservationDetails());
                    reservationController.AddReservation(reservation);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create reservation: " + ex.Message);
            }
        }
        #endregion
        private void Rersevationpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
                    DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel?",   // Message
            "Confirm Cancel",                     // Title
            MessageBoxButtons.YesNo,              // Buttons
            MessageBoxIcon.Question               // Icon
                   );

            if (result == DialogResult.Yes)
            {
                this.Close(); // Close the form only if user clicks Yes
            }
        }

        private void prepagebtn_Click(object sender, EventArgs e)
        {
           Rersevationpnl.Visible = true;
           guestpnl.Visible = false;
        }
    }
}
