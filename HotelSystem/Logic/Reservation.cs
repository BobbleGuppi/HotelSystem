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
        private double totalPrice;
        private bool depositPaid;

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

      

    }
}
