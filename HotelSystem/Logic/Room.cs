using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Room
    {
        private string roomID;
        private bool isAvailable;


        public Room(string roomID, bool isAvailable)
        {
            this.roomID = roomID;
            this.isAvailable = isAvailable;
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
    }
}
