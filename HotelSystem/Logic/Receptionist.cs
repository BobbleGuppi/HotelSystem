using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Receptionist:Person
    {
        private string receptionistId;
        private string password;

        public Receptionist(string id, string name, string phone, string address, string receptionistId, string password) : base(id, name, phone,address)
        {
            this.receptionistId = "Clerk00";
            this.password = "phumla@hote1";
        }

        public Boolean login(string receptionistId, string password)
        {
            if (this.receptionistId == receptionistId && this.password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
