using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Person
    {
        protected string id;
        protected string name;
        protected string phone;

        public Person(string ID, string name, string phone)
        {
            this.id = ID;
            this.name = name;
            this.phone = phone;
        }

    }
}
