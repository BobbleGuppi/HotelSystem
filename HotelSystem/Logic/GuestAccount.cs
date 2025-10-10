using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Logic
{
 
    public class GuestAccount
    {
        #region Fields
        private string guestAccID;
        private string guestID;
        private DateTime dateCreated;
        private string status;          // paid, unpaid, depositPaid
        private double totalAmount;
        private double balance;

        private Payment depositPay;
        private Payment fullPay;
        #endregion

        #region Property
        public string GuestAccID
        {
            get { return guestAccID; }
        }

        public string GuestID
        {
            get { return guestID; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
        }

        public string Status
        {
            get { return status; }
        }

        public double TotalAmount
        {
            get { return totalAmount; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Payment DepositPay
        {
            get { return depositPay; }
        }

        public Payment FullPay
        {
            get { return fullPay; }
        }
        #endregion

        #region Constructor
        public GuestAccount(string guestAccID, string guestID, DateTime dateCreated, double totalAmount, string status = "Unpaid")
        {
            this.guestAccID = guestAccID;
            this.guestID = guestID;
            this.dateCreated = dateCreated;
            this.totalAmount = totalAmount;
            this.balance = totalAmount;
            this.status = status; // initially unpaid
        }
        #endregion

        #region Methods
        public void makeDeposit(string paymentId)
        {
            if (depositPay != null) {
                throw new Exception("Deposit has already been made.");

            }

            double depositAmount = totalAmount * 0.10; // chat said this is how i make it 10%
            balance -= depositAmount;
            status = "DepositPaid";

            depositPay = new Payment(paymentId, GuestAccID, depositAmount, "Deposit", DateTime.Now);
        }

        public void makePayment(string paymentId, double amount)
        {
            if (fullPay != null)
            {
                throw new Exception("Payment has already been made.");
            }

            if (amount >= balance) // the payment is sufficient
            {
                balance = 0;
                status = "Paid";
            }


            else
            {
                balance -= amount;
                status = "DepositPaid";

            }

            fullPay = new Payment(paymentId, GuestAccID, amount, "TotalPayment", DateTime.Now);
        }

        public double getBalance()
        {
            return balance;
        }

        public string getStatus()
        {
            return status;
        }
        #endregion
    }


}
