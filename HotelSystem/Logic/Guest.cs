using System;

namespace HotelSystem.Logic
{
    public class Guest : Person
    {
        #region Fields
        private string guestID;
        private string guestAccountID;
        #endregion

        #region Property Methods
        public string GuestID { get { return guestID; } set { guestID = value; } }
        public string GuestAccount { get { return guestAccountID; } set { guestAccountID = value; } }
        #endregion

        #region Constructor
        public Guest(string ID, string name, string phone, string address, string guestID, string guestAccount)
            : base(ID, name, phone, address)
        {
            this.guestID = guestID;
            this.guestAccountID = guestAccount;
        }
        #endregion

        #region Methods
        public string displayInfo()
        {
            return $"Full Name: {Name}\nPhone: {Phone}\nAddress: {Address}\nID: {ID}\nGuest Account: {GuestAccount}";
        }
        #endregion
    }
}

