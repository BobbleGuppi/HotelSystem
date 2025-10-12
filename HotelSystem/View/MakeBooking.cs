using HotelSystem.Database;
using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.View
{
    public partial class MakeBooking : Form
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        private static readonly Random rand = new Random();
        private DateTime arrivalDate;
        private DateTime departureDate;
        private ReservationController reservationController;
        private GuestController guestController;
        private GuestAccountController guestAccountController;
        private PaymentController paymentController;
        private string displayGuest;


        public enum DepositChecker
        {
            Unpaid = 0,
            Paid = 1
        }
        DepositChecker depositChecker;

        public MakeBooking()
        {
            InitializeComponent();
            idNotxt.KeyPress += idNotxt_KeyPress;
            phoneNotxt.KeyPress += phoneNotxt_KeyPress;
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
                return;
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
                MessageBox.Show("Sorry, no rooms are available for those dates.\nPlease try other dates.", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void confirmRbtn_Click(object sender, EventArgs e)
        { 
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
                guestpnl.Visible = true;
                CenterPanel(guestpnl);
                Rersevationpnl.Visible = false;
            }
            else
            {
   
                confirmRbtn.Visible = false;
              
                MessageBox.Show("No problem! Please adjust your dates and check availability again.",
                    "Change Dates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MakeBooking_Resize(object sender, EventArgs e)
        {
            Rersevationpnl.Left = (this.ClientSize.Width - Rersevationpnl.Width) / 2;
            Rersevationpnl.Top = (this.ClientSize.Height - Rersevationpnl.Height) / 2;

            if (originalFormSize.Width == 0 || originalFormSize.Height == 0)
                return;

            float xRatio = (float)this.ClientSize.Width / originalFormSize.Width;
            float yRatio = (float)this.ClientSize.Height / originalFormSize.Height;

            foreach (Control ctrl in Rersevationpnl.Controls)
            {
                Rectangle orig = controlBounds[ctrl];
                ctrl.Width = (int)(orig.Width * xRatio);
                ctrl.Height = (int)(orig.Height * yRatio);
                ctrl.Left = (int)(orig.Left * xRatio);
                ctrl.Top = (int)(orig.Top * yRatio);
            }

 
            Rersevationpnl.Width = this.ClientSize.Width;
            Rersevationpnl.Height = this.ClientSize.Height;

        }

        private void confirmGbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fNametxt.Text))
            {
                MessageBox.Show("Please enter the guest’s first name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fNametxt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(lNametxt.Text))
            {
                MessageBox.Show("Please enter the guest’s last name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lNametxt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(phoneNotxt.Text))
            {
                MessageBox.Show("Please enter the guest’s phone number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNotxt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(idNotxt.Text))
            {
                MessageBox.Show("Please enter the guest’s ID number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idNotxt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(addresstxt.Text))
            {
                MessageBox.Show("Please enter the guest’s address.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addresstxt.Focus();
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNotxt.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Please enter a valid South African phone number (e.g. 0821234567).",
                                "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phoneNotxt.Focus();
                return;
            }

   
            if (!System.Text.RegularExpressions.Regex.IsMatch(idNotxt.Text, @"^\d{13}$"))
            {
                MessageBox.Show("Please enter a valid South African ID number (13 digits).",
                                "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idNotxt.Focus();
                return;
            }
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
                string guestAccID = GenerateGuestAccountID();
                DateTime dateCreated = DateTime.Now;
                double totalAmount = 0.0;
                string status = "Unpaid";
                GuestAccount newGuestAccount = new GuestAccount(guestAccID, guestID, dateCreated, totalAmount, status);
                Guest newGuest = new Guest(id, fullname, phone, address, guestID, guestAccID);

                // Save new guest and guest account first
                try
                {
                    guestAccountController.DataMaintenance(newGuestAccount, DB.DBOperation.Add);
                    bool savedaccount = guestAccountController.FinalizeChanges(newGuestAccount);
                    if (!savedaccount)
                    {
                        return;
                    }
                    guestController.DataMaintenance(newGuest, DB.DBOperation.Add);
                    bool saved = guestController.FinalizeChanges(newGuest);
                    if (!saved)
                    {
                        MessageBox.Show("Failed to save new guest.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add new guest or account: " + ex.Message);
                    return;
                }

                MessageBox.Show(
                    "Guest details added successfully. Proceed with reservation.", "New guest created!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Now update the GuestAccount's total after reservation price is known
                CreateReservation(newGuest, newGuestAccount);
            }
            else
            {
               
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

                MessageBox.Show(
                    " The guest already exists. Proceed with reservation.", "Guest details found!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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

       public void DepositChecking()
        {
            int randomValue = rand.Next(0, 2);
            depositChecker = (DepositChecker)randomValue;
        }


        private void CreateReservation(Guest guest, GuestAccount guestAccount)
        {
            int diff = departureDate.Day - arrivalDate.Day;
            string reservationId = ""+fNametxt.Text[0]+ ""+lNametxt.Text[0]+"12"+ arrivalDate.Day+ "-"+ diff;

            string guestId = guest.GuestID;
            string guestAccId = guest.GuestAccount;
            double totalPrice = 0.0;
            bool depositPaid = (depositChecker == DepositChecker.Paid);

            Reservation reservation = new Reservation(reservationId, guestId, arrivalDate, departureDate, totalPrice, depositPaid);
            reservation.calculateTotalPrice(arrivalDate, departureDate);
            guestAccount.UpdateTotalAmount(reservation.totalPrice);
            double depositAmount = reservation.totalPrice * 0.10;

            // --- Always update GuestAccount in DB with correct totalAmount ---
            guestAccountController.DataMaintenance(guestAccount, DB.DBOperation.Edit);
            guestAccountController.FinalizeChanges(guestAccount);

            if (depositChecker == DepositChecker.Paid)
            {
                string paymentID = GeneratePaymentID();
                string paymentType = "Deposit";
                Payment payment = new Payment(paymentID, guestAccId, totalPrice, paymentType, DateTime.Now);
                guestAccount.makeDeposit(paymentID);
                guestAccountController.DataMaintenance(guestAccount, DB.DBOperation.Edit);
                guestAccountController.FinalizeChanges(guestAccount);
            }
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
                    MessageBox.Show(
                        "✅ Reservation Successful!\n\n" +
                        "Guest Details\n" +
                        "-----------------------------\n" +
                        guest.displayInfo() + "\n\n" +
                        "Reservation Details\n" +
                        "-----------------------------\n" +
                        reservation.reservationDetails() + "\n\n" +
                        "💰 Total Amount to be Paid: R" + reservation.totalPrice.ToString("F2") + "\n" +
                        "💵 Deposit (10%): R" + depositAmount.ToString("F2") + "\n\n" +
                        "Thank you for booking with Phumla Kamnandi Hotels! 🌿",
                        "Reservation Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    reservationController.AddReservation(reservation);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create reservation: " + ex.Message);
            }
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

        private void idNotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void phoneNotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion
        private void Rersevationpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
                    DialogResult result = MessageBox.Show(
            "Are you sure you want to cancel?",  
            "Confirm Cancel",                    
            MessageBoxButtons.YesNo,              
            MessageBoxIcon.Question              
                   );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void prepagebtn_Click(object sender, EventArgs e)
        {
           Rersevationpnl.Visible = true;
           guestpnl.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblfname_Click(object sender, EventArgs e)
        {

        }

        private void addresstxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
