using HotelSystem.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class ReservationController
    {
        #region data members
        public ReservationDB reservationDB;
        protected Collection<Reservation> reservations;
        protected List<Room> rooms;
        protected string currentRoom;
        #endregion

        #region properties

        public Collection<Reservation> AllReservations
        {
            get { return reservations; }
        }
        public string RoomID { get { return currentRoom; } set{currentRoom = value;} }
        #endregion

        #region Constructors
        public ReservationController()
        {
            reservationDB = new ReservationDB();
            reservations = reservationDB.AllReservations;   
            rooms = new List<Room>
            {
                new Room("R001"),
                new Room("R002"),
                new Room("R003"),
                new Room("R004"),
                new Room("R005")
            };
        }

        #endregion

        #region database communication
        public void DataMaintenance(Reservation reservation, DB.DBOperation operation)
        {
            switch (operation)
            {
                case DB.DBOperation.Add:
                    reservationDB.DataSetChange(reservation, operation);
                    reservations.Add(reservation);
                    break;
                case DB.DBOperation.Edit:
                    int rowIndex = FindIndex(reservation);
                    reservations[rowIndex] = reservation;
                    break;
                case DB.DBOperation.Delete:
                    reservationDB.DataSetChange(reservation, operation);
                    int delIndex = FindIndex(reservation);
                    if (delIndex >= 0)
                        reservations.RemoveAt(delIndex);
                    break;
            }
        }

   
        public bool FinalizeChanges(Reservation reservation)
        {
            return reservationDB.UpdateDataSource(reservation);
        }
        #endregion

        #region Search Method
        public Reservation find(string reservationID)
        {
            int count = reservations.Count;
            for (int i = 0; i < count; i++)
            {
                if (reservations[i].ReservationID == reservationID)
                {
                    return reservations[i]; // found
                }
            }
            return null; // not found
        }

        #endregion

        public int FindIndex(Reservation reservation)
        {
            int counter = 0;
            Boolean found = false;
            found = (reservations[counter].ReservationID == reservation.ReservationID);

            while (!(found) && (counter < reservations.Count - 1))
            {
                counter++;
                found = (reservations[counter].ReservationID == reservation.ReservationID);
            }
            if (found)
                return counter;
            else
                return -1;
        }

        public bool RoomAvailable(DateTime checkIn, DateTime checkOut)
        {
            foreach (Room room in rooms)
            {
                if (room.IsAvailable(checkIn, checkOut))
                {
                    currentRoom = room.RoomID;
                    return true;
                }
            }
            return false;
        }


        #region Occupancy Report Methods
        public Dictionary<DateTime, double> CalculateDailyOccupancy(DateTime startDate, DateTime endDate)
        {
            int totalRooms = rooms.Count; // 5 rooms
            Dictionary<DateTime, double> dailyOccupancy = new Dictionary<DateTime, double>();

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                // Count how many reservations include this day
                int occupiedCount = reservations.Count(r =>
                    r.CheckInDate <= date && r.CheckOutDate > date);

                double percentage = (double)occupiedCount / totalRooms * 100; // calc the percentage
                dailyOccupancy[date] = percentage;
            }

            return dailyOccupancy;
        }

        public double CalculateAverageOccupancy(DateTime startDate, DateTime endDate)
        {
            var daily = CalculateDailyOccupancy(startDate, endDate);
            if (daily.Count == 0) return 0;
            return daily.Values.Average();
        }



        #endregion

        #region Loyalty Report Methods (Date Range)
        public Dictionary<string, int> GetLoyalGuestsByDateRange(DateTime startDate, DateTime endDate)
        {
            // Filter reservations within the selected date range
            var filteredReservations = reservations
                .Where(r =>
                    r.CheckInDate <= endDate &&  // check-in before range end
                    r.CheckOutDate >= startDate  // check-out after range start
                )
                .ToList();

            // Group by GuestID and count how many reservations each guest has in that range
            var loyaltyGroups = filteredReservations
                .GroupBy(r => r.GuestID)
                .Select(g => new { GuestID = g.Key, ReservationCount = g.Count() })
                .Where(x => x.ReservationCount > 1) // guests with more than one reservation in the range
                .ToDictionary(x => x.GuestID, x => x.ReservationCount);

            return loyaltyGroups;
        }
        #endregion




    }


}
  
