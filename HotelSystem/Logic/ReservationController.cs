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
        #region Data Members
        public ReservationDB reservationDB;
        protected Collection<Reservation> reservations;
        protected List<Room> rooms = new List<Room>
        {
            new Room("R001"),
            new Room("R002"),
            new Room("R003"),
            new Room("R004"),
            new Room("R005")
        };
        protected string currentRoom;
        #endregion

        #region Properties
        public Collection<Reservation> AllReservations => reservations;
        public string RoomID { get => currentRoom; set => currentRoom = value; }
        #endregion

        #region Constructors
        public ReservationController()
        {
            reservationDB = new ReservationDB();
            reservations = reservationDB.AllReservations;
            assignDBReservationsToRoom();        }
        #endregion

        #region Database Communication
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

        private void assignDBReservationsToRoom()
        {
            foreach (var reservation in reservations)
            {
                foreach (var room in rooms)
                {
                    if (reservation.RoomID == room.RoomID)
                    {
                        room.AddReservation(reservation);
                    }
                }
            }
        }
        #endregion

        #region Search Methods
        public Reservation find(string reservationID)
        {
            foreach (Reservation r in reservations)
            {
                if (r.ReservationID == reservationID)
                    return r;
            }
            return null;
        }

        public int FindIndex(Reservation reservation)
        {
            for (int i = 0; i < reservations.Count; i++)
            {
                if (reservations[i].ReservationID == reservation.ReservationID)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Room Availability Logic
        //Checks if there’s any available room between given dates
        public bool RoomAvailable(DateTime checkIn, DateTime checkOut)
        {
            foreach (Room room in rooms)
            {
                if (room.IsAvailable(checkIn, checkOut))
                {
                    currentRoom = room.RoomID; // Save the first available room ID
                    return true;
                }
            }
            return false; // All rooms full for the given period
        }

        //  Adds a reservation only to ONE available room
        public void AddReservation(Reservation reservation)
        {
            foreach (Room room in rooms)
            {
                if (room.IsAvailable(reservation.CheckInDate, reservation.CheckOutDate))
                {
                    room.AddReservation(reservation);
                    reservations.Add(reservation);         // ✅ Add to the controller's list
                    currentRoom = room.RoomID;             // Track the assigned room
                    reservation.RoomID = currentRoom;
                   
                    return; // stop after assigning
                }
            }

            // Optional: if you want to handle no available rooms case here
            Console.WriteLine("No available rooms found for this reservation period.");
        }
        #endregion

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
        // Returns a summary: key = times booked (2..5 where 5 = 5 or more), value = number of guests
        public Dictionary<int, int> GetLoyalCountsByDateRange(DateTime startDate, DateTime endDate)
        {
            // Filter reservations that overlap the date range
            var filtered = reservations
                .Where(r => r.CheckInDate <= endDate && r.CheckOutDate >= startDate);

            // Count reservations per guest inside the filtered set
            var countsByGuest = filtered
                .GroupBy(r => r.GuestID)
                .Select(g => new { GuestID = g.Key, Count = g.Count() })
                .Where(x => x.Count >= 2) // only interested in guests with multiple reservations
                .ToList();

            // Prepare buckets 2,3,4,5 (5 means 5 or more)
            var buckets = new Dictionary<int, int> { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

            foreach (var g in countsByGuest)
            {
                int bucket = (g.Count >= 5) ? 5 : g.Count; // clamp to 5
                buckets[bucket] = buckets[bucket] + 1;
            }

            return buckets;
        }
        #endregion
    }
}


