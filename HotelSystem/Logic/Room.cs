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
        private List<Reservation> reservations = new List<Reservation>();

        public Room(string roomID)
        {
            this.roomID = roomID;
        }

        public string RoomID
        {
            get { return roomID; }
        }

        // Add a reservation to this room
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        // Check if room is available for a given date range
        public bool IsAvailable(DateTime checkIn, DateTime checkOut)
        {
            foreach (Reservation r in reservations)
            {
                // Correct overlap check
                if (checkIn < r.CheckOutDate && r.CheckInDate < checkOut)
                {
                    return false; // Not available
                }
            }
            return true; // Available if no overlap
        }
    }


}

