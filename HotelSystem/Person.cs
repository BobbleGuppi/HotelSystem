using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Person
    {
        #region Fields
        protected string id;
        protected string name;
        protected string phone;
        protected string address;
        #endregion


        #region Property Methods
        public string ID { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Address { get { return address; } set { address = value; } }
        #endregion


        #region Constructor
        public Person(string ID, string name, string phone, string address)
        {
            this.id = ID;
            this.name = name;
            this.phone = phone;
            this.address = address;
        }
        #endregion


        #region Methods
        public virtual string displayInfo()
        {
            return "$Full name:{name}\tAddress:{addresss}\tID:{id}";
        }
        #endregion


    }
}
