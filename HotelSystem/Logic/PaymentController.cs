using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Database;

namespace HotelSystem.Logic
{
    internal class PaymentController
    {
        #region Data Members
        PaymentDB paymentDB;
        Collection<Payment> payments;

        #endregion
        #region Properties

        public Collection<Payment> AllPayments
        {
            get
            {
                return payments;
            }
        }
        #endregion

        #region Constructor 
        public PaymentController()
        {
            paymentDB = new PaymentDB();
            payments = paymentDB.AllPayments;
        }

        #endregion

        #region Database Communication.
        public void DataMaintenance(Payment aPayment, DB.DBOperation operation)
        {
            int index = 0;
            paymentDB.DataSetChange(aPayment, operation);
            switch (operation)
            {
                case DB.DBOperation.Add:
                    payments.Add(aPayment);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aPayment);
                    if (index >= 0) 
                    {
                        payments[index] = aPayment;
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aPayment);
                    if (index >= 0)
                    {
                        payments.RemoveAt(index);
                    }
                    break;
            }
        }

        public bool finalizeChanges(Payment aPayment)
        {
            return paymentDB.UpdateDataSource(aPayment);
        }
        #endregion
        #region Utility Methods

        public Payment Find(string paymentID)
        {
            int index = 0;
            bool found = (payments[index].PaymentID == paymentID);
            int count = payments.Count;
            while (!(found) && (index < payments.Count - 1))
            {
                index++;
                found = (payments[index].PaymentID == paymentID); 
            }
            return payments[index];

        }
        private int FindIndex(Payment aPayment)
        {
            int index = 0;
            bool found = false;
            found = (payments[index].PaymentID == aPayment.PaymentID);
            while (!(found) && (index < payments.Count - 1))
            {
                index++;
                found = (payments[index].PaymentID == aPayment.PaymentID);
            }
         if (found)
                return index;
            else
                return -1; 
        }
        #endregion


    }
}
