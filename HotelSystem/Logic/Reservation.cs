using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Reservation
    {
        private string reservationID;
        private int roomID; //thinking we should make it an enum
        private Guest guest;
        private DateTime checkInDate; //we will have to set a standard time
        private DateTime checkOutDate;
        public double totalPrice;
        private bool depositPaid = false;

        public Reservation(string reservationID, int roomID, Guest guest, DateTime checkInDate, DateTime checkOutDate, double totalPrice, bool depositPaid)
        {
            this.reservationID = reservationID;
            this.roomID = roomID;
            this.guest = guest;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.totalPrice = totalPrice;
            this.depositPaid = depositPaid;
        }
        #region  Properties
        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        #endregion

        public void calculateTotalPrice(DateTime checkIn, DateTime checkOut)
        {
            while (checkIn < checkOut)
            {
                totalPrice += checkSeasonalPricing(checkIn);
                checkIn = checkIn.AddDays(1);
            }

        }

        public double checkSeasonalPricing(DateTime date)
        {
            DateTime startLowSeason = new DateTime(2025, 12, 1);
            DateTime endLowSeason = new DateTime(2025, 12, 7);
            DateTime endMidSeason = new DateTime(2025, 12, 15);
            DateTime endHighSeason = new DateTime(2025, 12, 31);

            if (date >= startLowSeason && date <= endLowSeason)
            {
                return 550;
            }
            else if (date > endLowSeason && date <= endMidSeason)
            {
                return 750;
            }
            else if (date > endMidSeason && date <= endHighSeason)
            {
                return 995;
            }
            else
            {
                return 0;
            }

        }

        public void makeDepositPayment()
        {
            depositPaid = true;
        }

        public void changeReservationDates(DateTime newCheckIn, DateTime newCheckOut)
        {
            checkInDate = newCheckIn;
            checkOutDate = newCheckOut;
            totalPrice = 0; // Reset total price before recalculating
            calculateTotalPrice(checkInDate, checkOutDate); // Assuming pricePerNight is handled in checkSeasonalPricing
        }

        public string reservationDetails()
        {
            guest.displayInfo();
            return "Current booking reserved for" + checkInDate.ToString("yyyy-MM-dd") + " to " + checkOutDate.ToString("yyyy-MM-dd");

        }


        
        
     

    }
}
