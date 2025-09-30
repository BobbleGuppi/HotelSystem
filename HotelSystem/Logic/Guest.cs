using System;
using System.CodeDom.Compiler;
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

        public Guest(string ID, string name, string phone,string address, string guestID, GuestAccount guestAccount) : base(ID, name, phone,address)
        {
            this.guestID = guestID;
            this.guestAccount = guestAccount;
        }
     
        public void generateID()
        {
            Random random = new Random();
            int guestId = random.Next(100, 1000);
            guestID = "G" + guestId.ToString();
        }

    }
}
