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
        #region Data members
        private string guestAccID;
        private DateTime dateCreated;
        private string status;          // paid, unpaid, depositPaid
        private decimal totalAmount;
        private decimal balance;

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

        #region Methods
        public void makeDeposit(string paymentID, string guestAccID)
        {
            if (status != "Unpaid") {
                throw new Exception("Deposit must only be made once when the account is unpaid!");

            }

            decimal deposit = totalAmount * 0.10m; // chat said this is how i make it 10%
            balance -= deposit;
            status = "DepositPaid";

            depositPay = new Payment(paymentID, guestAccID, depositAmount, "Deposit", DateTime.Now);




        }

        public void makePayment(string paymentID, double amount, string guestAccID)
        {
            if (amount <= 0 || amount > balance)
            {
                throw new Exception("Payment must be valid and not be higher than the balance");
            }

            balance -= amount;

            if (balance == 0)
            {
                status = "Paid";
            }

            else
            {
                status = "DepositPaid";

            }

            fullPay = new Payment(paymentID, guestAccID, amount, "TotalPayment", DateTime.Now);
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
