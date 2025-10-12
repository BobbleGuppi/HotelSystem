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
                    if (index >= 0)
                    {
                        guestAccounts[index] = aGuestAcc;

                    }
                    break;

                case DB.DBOperation.Delete:
                    index = FindIndex(aGuestAcc);
                    if (index >= 0) 
                    {
                        guestAccounts.RemoveAt(index);
                    }
                    break;
            }

        }

        public bool FinalizeChanges(GuestAccount aGuestAcc)
        {
 
            return guestAccountDB.UpdateDataSource(aGuestAcc);
        }
        #endregion

        #region Search Method

        public GuestAccount Find(string guestAccID)
        {
            int index = 0;
            bool found = (guestAccounts[index].GuestAccID == guestAccID); 
            int count = guestAccounts.Count;

            while (!(found) && (index < guestAccounts.Count - 1))  
            {
                index++;
                found = (guestAccounts[index].GuestAccID == guestAccID); 


            }
            return guestAccounts[index]; 
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
