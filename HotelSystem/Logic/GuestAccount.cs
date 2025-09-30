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
        private string guestAccID;
        private DateTime dateCreated;
        private string status;          // paid, unpaid, depositPaid
        private decimal totalAmount;  
        private decimal balance;

        private Payment depositPay;
        private Payment fullPay;

        public string GuestAccID
        {
            get {  return guestAccID; }
        }


        public GuestAccount(string guestAccID, DateTime dateCreated, decimal totalAmount )
        {
            this.guestAccID = guestAccID;
            this.dateCreated = dateCreated;
            this.totalAmount = totalAmount;
            this.balance = totalAmount;
            this.status = "Unpaid";
        }


        public void makeDeposit(string payment)
        {
            if (depositPay !=null) {
                throw new Exception("Deposit has already been made.");

            }

            decimal depositAmount = totalAmount * 0.10m; // chat said this is how i make it 10%
            balance -= depositAmount;
            status = "DepositPaid";

            depositPay = new Payment(payment, depositAmount, "Deposit", DateTime.Now);




        }

        public void makePayment(string payment, decimal amount)
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

            fullPay = new Payment(payment, amount, "TotalPayment", DateTime.Now);
        }

        public decimal getBalance()
            {
                return balance;
            }

            public string getStatus()
            {
            return status;
            }
        }




     
}
