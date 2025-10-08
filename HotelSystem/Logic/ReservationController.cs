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
        ReservationDB reservationDB;
        Collection<Reservation> reservations;
        private List<Room> rooms;
        #endregion

        #region properties

        public Collection<Reservation> AllReservations
        {
            get { return reservations; }
        }
        #endregion

        #region constructors
        public ReservationController()
        {
            reservationDB = new ReservationDB();
            reservations = reservationDB.AllReservations;
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

        public bool FinalizeChnages(Reservation reservation)
        {
            return reservationDB.UpdateDataSource(reservation);
        }
        #endregion

        #region Search Method
        public Reservation find(string reservationID)
        {
            int index = 0;
            Boolean found = (reservations[index].ReservationID == reservationID);
            int count = reservations.Count;
            while (!(found) && (index < count - 1))
            {
                index++;
                found = (reservations[index].ReservationID == reservationID);
            }
            return reservations[index];
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

        public bool RoomAvailable( DateTime checkIn, DateTime checkOut)
        {
            foreach (Room room in rooms)
            {
                if (room.IsAvailable(checkIn, checkOut))
                {
                    return true;
                }
            }
            return false;
        }
    }


}
  
