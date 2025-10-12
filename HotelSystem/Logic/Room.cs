using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Room
    {
        private string roomID;
        private List<Reservation> roomReservations = new List<Reservation>();

        public Room(string roomID)
        {
            this.roomID = roomID;
        }

        public string RoomID
        {
            get { return roomID; }
        }

        // this add a reservation to this room
        public void AddReservation(Reservation reservation)
        {
            roomReservations.Add(reservation);
        }

        // this check if room is available for a given date range
        public bool IsAvailable(DateTime checkIn, DateTime checkOut)
        {
            foreach (Reservation r in roomReservations)
            {
                // correct overlap check
                if (checkIn < r.CheckOutDate && r.CheckInDate < checkOut)
                {
                    return false; // not available
                }
            }
            return true; // available if no overlap
        }
    }


}

