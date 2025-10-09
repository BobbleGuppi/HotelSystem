using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Guest : Person
    {
        #region Fields
        private string guestID;
        private string guestAccountID; // changed GuestAccount to a string for database purposes
        #endregion

        #region Property Methods
        public string GuestID { get { return guestID; } set { guestID = value; } }
        public string GuestAccount { get { return guestAccountID; } set { guestAccountID= value; } }
        #endregion

        #region Constructor
        public Guest(string ID, string name, string phone, string address, string guestID, string guestAccount) : base(ID, name, phone, address)
        {
            this.guestID = guestID;
            this.guestAccountID = guestAccount;
        }
        #endregion

        #region Methods
        public void generateID()
        {
            Random random = new Random();
            int guestId = random.Next(100, 1000);
            guestID = "G" + guestId.ToString();
        }
        #endregion
    }
}
