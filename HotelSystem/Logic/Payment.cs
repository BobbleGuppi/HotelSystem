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
        private DateTime payDate;

        public Payment(string paymentId, double amount, string paymentType, DateTime payDate)
        {
            this.paymentId = paymentId;
            this.amount = amount;
            this.paymentType = paymentType;
            this.payDate = payDate;
        }

        public string getPaymentID()
        {
            return paymentId;
        }

        public double getAmount()
        {
            return amount;
        }

        public string getPaymentType()
        {
            return paymentType;
        }

        public DateTime getPayDate()
        {
            return payDate;
        }

        public override string ToString()
        {
            return $"PaymentID: {paymentId}, Amount: {amount}, Type: {paymentType}, Date: {payDate.ToShortDateString()}";
        }
    }


}
