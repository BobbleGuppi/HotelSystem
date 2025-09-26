using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
     public class GuestAccount
     {
        private string guestAccID;
        private DateTime dateCreated;
        private string status;//what is the status referring to?

        public GuestAccount(string guestAccID, DateTime dateCreated, string status)
        {
            this.guestAccID = guestAccID;
            this.dateCreated = dateCreated;
            this.status = status;
        }
     }
}
