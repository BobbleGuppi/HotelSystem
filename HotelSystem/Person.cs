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
        protected string address;

        public Person(string ID, string name, string phone, string address)
        {
            this.id = ID;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

        public virtual string displayInfo()
        {
            return "$Full name:{name}\tAddress:{addresss}\tID:{id}";
        }
    }
}
