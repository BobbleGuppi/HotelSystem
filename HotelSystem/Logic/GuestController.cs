using HotelSystem.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    internal class GuestController
    {
        #region Data Members
        GuestDB guestDB;
        Collection<Guest> guests;
        #endregion

        #region Property Methods

        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        #endregion

        #region Constructors
        public GuestController()
        {

            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        #endregion

        #region Database Comms
        public void DataMaintenance(Guest aGuest, DB.DBOperation operation)
        {
            switch (operation)
            {
                case DB.DBOperation.Add:
                    guestDB.DataSetChange(aGuest, operation);
                    guests.Add(aGuest);
                    break;
                case DB.DBOperation.Edit:
                    int rowIndex = FindIndex(aGuest);
                    guests[rowIndex] = aGuest;
                    break;
                case DB.DBOperation.Delete:
                    guestDB.DataSetChange(aGuest, operation);
                    int delIndex = FindIndex(aGuest);
                    if (delIndex >= 0)
                        guests.RemoveAt(delIndex);
                    break;
            }

        }

        public bool FinalizeChnages(Guest aGuest)
        {
            return guestDB.UpdateDataSource(aGuest);
        }
        #endregion

        #region Search Method
        public Guest find(string guestID)
        {
            int index = 0;
            Boolean found = (guests[index].GuestID == guestID);
            int count = guests.Count;
            while (!(found) && (index < count - 1))
            {
                index++;
                found = (guests[index].GuestID == guestID);
            }
            return guests[index];
        }
        #endregion

        public int FindIndex(Guest aGuest)
        {
            int counter = 0;
            Boolean found = false;
            found = (guests[counter].GuestID == aGuest.GuestID);

            while (!(found) && (counter < guests.Count - 1))
            {
                counter++;
                found = (guests[counter].GuestID == aGuest.GuestID);
            }
            if (found)
                return counter;
            else
                return -1;
        }

    }
}
