using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Payment
    {
        private string paymentId;
        private double amount;
        private string paymentType; //what does this mean?
        private string status; //what does status refer to ? // if its pending or something 
        private DateTime payDate;

        public Payment(string paymentId, double amount, string paymentType, string status, DateTime payDate)
        {
            this.paymentId = paymentId;
            this.amount = amount;
            this.paymentType = paymentType;
            this.status = status; //rachel asked about this
            this.payDate = payDate;
        }

    }
}
