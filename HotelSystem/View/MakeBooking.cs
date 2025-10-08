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
    public partial class MakeBooking : Form
    {
        DateTime arrivalDate;
        DateTime departureDate;
        private ReservationController reservationController;
        GuestController guestController;
        GuestAccountController guestAccountController;

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

            bool Availability = reservationController.RoomAvailable(arrivalDate, departureDate);
            MessageBox.Show($"Checking room availability from {arrivalDate.ToShortDateString()} to {departureDate.ToShortDateString()} ");

            if (Availability)
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
            // Calculate position so panel is centered within the form
            int x = (this.ClientSize.Width - panel.Width) / 2;
            int y = (this.ClientSize.Height - panel.Height) / 2;

            panel.Location = new Point(x, y);
        }

        private void confirmGbtn_Click(object sender, EventArgs e)
        {
            string firstname = fNametxt.Text;
            string lastname = lNametxt.Text;
            string phone = phoneNotxt.Text;
            string id = idNotxt.Text;
            string address = addresstxt.Text;
            string fullname = firstname + " " + lastname;   
            Guest existingGuest = null;
            try
            {
                existingGuest = guestController.find(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            

           if (existingGuest == null)
            {
                string guestID = GenerateGuestID();
                string guestAccount = GenerateGuestAcc();
                Guest newGuest = new Guest(id,fullname,phone,address,guestID,guestAccount);

                guestController.DataMaintenance(newGuest, DB.DBOperation.Add);
                guestController.FinalizeChnages(newGuest);

                MessageBox.Show("New guest added successfully!");
                CreateReservation(newGuest);
            }
            else
            {
                MessageBox.Show("Guest already exists. Proceeding to reservation...");
                CreateReservation(existingGuest);
            }

            //remember to add the method hidetextbox and showtextbox
        }

        private string GenerateGuestID()
        {
            Random rand = new Random();
            return "GT" + rand.Next(100, 1000);
        }

        private string GenerateGuestAcc()
        {
            Random rand = new Random();
            return "GA" + rand.Next(100, 1000);
        }
        private void CreateReservation(Guest guest)
        {
            // Example values, replace with actual logic
            string reservationId = "R" + new Random().Next(1000, 9999);
            int roomId = 1; // You should select an available room
            string guestId = guest.GuestID;
            DateTime checkIn = arrivalDate;
            DateTime checkOut = departureDate;
            double totalPrice = 100.0; // Calculate based on your logic
            bool depositPaid = false;

            Reservation reservation = new Reservation(reservationId, roomId, guestId, checkIn, checkOut, totalPrice, depositPaid);
            reservationController.DataMaintenance(reservation, DB.DBOperation.Add);
            reservationController.FinalizeChnages(reservation);

            MessageBox.Show("Reservation successfully created!");
        }


    }

}
