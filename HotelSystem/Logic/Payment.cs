using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
    public class Payment
    {

        #region Fields
        private string paymentId;
        private string guestAccId;
        private double amount;
        private string paymentType; 
        private DateTime payDate;
        #endregion


        #region Constructors
        public Payment(string paymentId, string guestAccId, double amount, string paymentType, DateTime payDate)
        {
            this.paymentId = paymentId;
            this.guestAccId = guestAccId;
            this.amount = amount;
            this.paymentType = paymentType;
            this.payDate = payDate;
        }
        #endregion

        #region Property Methods
        public string PaymentID { get{ return paymentId; } set{ paymentId = value; } }
        public string GuestAccID { get { return guestAccId; } set { guestAccId = value; } }
        public double Amount { get { return amount; } set { amount = value; } }
        public string PaymentType { get { return paymentId; } set { paymentId = value; } }
        public DateTime DatePaid { get { return payDate; } set { payDate = value; } }
        #endregion

        #region Utility Methods
        public override string ToString()
        {
            return $"PaymentID: {paymentId}, Amount: {amount}, Type: {paymentType}, Date: {payDate.ToShortDateString()}";
        }
        #endregion

    }


}
