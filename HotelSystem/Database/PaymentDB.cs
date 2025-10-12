using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HotelSystem.Database.DB;

namespace HotelSystem.Database
{
    internal class PaymentDB: DB
    {
        #region Fields
        private string table1 = "Payment";
        private string sqlLocal1 = "SELECT * FROM Payment";

        private Collection<Payment> payments;
        #endregion

        #region Property Methods
        public Collection<Payment> AllPayments { get { return payments; } }
        #endregion

        #region Constructors
        public PaymentDB() : base()
        {
            payments = new Collection<Payment>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region Utility Methods

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Payment aPayment;

            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string paymentID = Convert.ToString(myRow["PaymentID"]).TrimEnd();
                    string guestAccID = Convert.ToString(myRow["GuestAccID"]).TrimEnd();
                    Double amount = Convert.ToDouble(myRow["Amount"]);
                    string paymentType = Convert.ToString(myRow["PaymentType"]).TrimEnd();
                    DateTime datePaid = Convert.ToDateTime(myRow["DatePaid"]);
                    aPayment = new Payment(paymentID, guestAccID, amount, paymentType, datePaid);
                    payments.Add(aPayment);
                }
            }
        }

        private int FindRow(Payment payment, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string paymentId = Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["PaymentID"]).TrimEnd();
                    if (paymentId == payment.PaymentID)
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRow(DataRow myRow, Payment payment, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                myRow["PaymentID"] = payment.PaymentID;
                myRow["GuestAccID"] = payment.GuestAccID;
                myRow["Amount"] = payment.Amount;
                myRow["DatePaid"] = payment.DatePaid;
                myRow["PaymentType"] = payment.PaymentType;
            }
        }


        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Payment aPayment, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string table = table1;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aPayment, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aPayment, table)];
                    FillRow(aRow, aPayment, operation);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aPayment, table)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Payment aPayment)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentID", SqlDbType.NChar, 10, "PaymentID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestAccID", SqlDbType.NChar, 10, "GuestAccID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Amount", SqlDbType.Decimal);
            param.Precision = 18;      
            param.Scale = 2;           
            param.SourceColumn = "Amount";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DatePaid", SqlDbType.DateTime, 0, "DatePaid");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@PaymentType", SqlDbType.NChar, 10, "PaymentType");
            daMain.InsertCommand.Parameters.Add(param);

        }

        private void Create_INSERT_Command(Payment aPayment)
        {
            
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (PaymentID, GuestAccID, Amount, DatePaid, PaymentType) VALUES (@PaymentID, @GuestAccID, @Amount, @DatePaid, @PaymentType)", cnMain);
            Build_INSERT_Parameters(aPayment);
        }

        public bool UpdateDataSource(Payment aPayment)
        {
            bool success = true;
            Create_INSERT_Command(aPayment);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion
    }
}
