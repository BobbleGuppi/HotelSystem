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

        public Receptionist(string id, string name, string phone, string receptionistId, string password):base(id, name, phone)
        {
            this.receptionistId = receptionistId;
            this.password = password;
        }
    }
}
