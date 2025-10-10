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

        public void AddReservation(Reservation reservation)
        {
            foreach(Room room in rooms)
            {
                room.AddReservation(reservation);
            }
        }


    }


}
  
