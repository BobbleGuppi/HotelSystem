using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Guest:Person
    {
        private string guestID;
        private GuestAccount guestAccount;

        public Guest(string ID, string name, string phone, string guestID, GuestAccount guestAccount) : base(ID, name, phone)
        {
            this.guestID = guestID;
            this.guestAccount = guestAccount;
        }
    }
}
