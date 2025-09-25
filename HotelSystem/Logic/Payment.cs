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
        private string paymentType;
        private string status;
        private DateTime payDate;

        public Payment(string paymentId, double amount, string paymentType, string status, DateTime payDate)
        {
            this.paymentId = paymentId;
            this.amount = amount;
            this.paymentType = paymentType;
            this.status = status;
            this.payDate = payDate;
        }

    }
}
