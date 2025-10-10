using HotelSystem.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelSystem.Logic
{
    internal class GuestAccountController
    {
        #region Data Members
        private GuestAccountDB guestAccountDB;
        private Collection<GuestAccount> guestAccounts;
        #endregion

        #region Properties
        public Collection<GuestAccount> AllGuestAccounts
        {
            get
            {
                return guestAccounts;
            }
        }
        #endregion

        #region Constructor
        public GuestAccountController()
        {
            //***instantiate the guestAccDB object to communicate with the database
            guestAccountDB = new GuestAccountDB();
            guestAccounts = guestAccountDB.AllGuestAccounts;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(GuestAccount aGuestAcc, DB.DBOperation operation)
        {
            int index = 0;

            guestAccountDB.DataSetChange(aGuestAcc, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    guestAccounts.Add(aGuestAcc);
                    break;

                case DB.DBOperation.Edit:
                    index = FindIndex(aGuestAcc);
                    if (index >= 0) // has to exist
                    {
                        guestAccounts[index] = aGuestAcc;

                    }
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aGuestAcc);
                    if (index >= 0) // has to exist
                    {
                        guestAccounts.RemoveAt(index);
                    }
                    break;
            }

        }

        //***Commit the changes to the database
        public bool FinalizeChanges(GuestAccount aGuestAcc)
        {
            //***call the guestAccDB method that will commit the changes to the database
            return guestAccountDB.UpdateDataSource(aGuestAcc);
        }
        #endregion

        #region Search Method

        public GuestAccount Find(string guestAccID)
        {
            int index = 0;
            bool found = (guestAccounts[index].GuestAccID == guestAccID); // checks if it is the first guestAcc. The found variable will be searching for an guestAcc
            int count = guestAccounts.Count;

            while (!(found) && (index < guestAccounts.Count - 1))  //if you have not found the guestAcc AND you have not reached the end of the collection – write
            {
                index++;
                found = (guestAccounts[index].GuestAccID == guestAccID); // this will be TRUE if found


            }
            return guestAccounts[index]; // guestAcc we found
        }

        public int FindIndex(GuestAccount aGuestAcc)
        {
            int counter = 0;
            bool found = false;
            found = (aGuestAcc.GuestAccID == guestAccounts[counter].GuestAccID);

            while (!(found) && (counter < guestAccounts.Count - 1))
            {
                counter++;
                found = (aGuestAcc.GuestAccID == guestAccounts[counter].GuestAccID);

            }

            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }

        #endregion
    }
}
