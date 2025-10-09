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

            bool availability = reservationController.RoomAvailable(arrivalDate, departureDate);
            MessageBox.Show($"Checking room availability from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()} ");

            if (availability)
            {
                MessageBox.Show("A room is available for the selected dates!", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sorry, no rooms are available for those dates.", "Availability Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void confirmRbtn_Click(object sender, EventArgs e)
        {
            guestpnl.Visible = true;
            CenterPanel(guestpnl);
            Rersevationpnl.Visible = false;
        }

        private void CenterPanel(Panel panel)
        {
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;
            panel.Location = new Point(x, y);
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
                    bool saved=guestController.FinalizeChnages(newGuest);
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

        private string GenerateGuestID()
        {
            Random rand = new Random();
            return "GT" + rand.Next(100, 1000);
        }

        private string GenerateGuestAccountID()
        {
            Random rand = new Random();
            return "GA" + rand.Next(1000, 9999);
        }

        private void CreateReservation(Guest guest, GuestAccount guestAccount)
        {

            string reservationId = "R" + new Random().Next(1000, 9999);
            //string roomId = "R001";

            string guestId = guest.GuestID;
            double totalPrice = 0.0;
            bool depositPaid = false;

            Reservation reservation = new Reservation(reservationId, guestId, arrivalDate, departureDate, totalPrice, depositPaid);

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


    }
}
