using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Database
{
    public class ReservationDB:DB
    {
        #region Data members
        private string table1 = "Reservation";
        private string sqlLocal1 = "SELECT * FROM Reservation";

        private Collection<Reservation> reservations;
        #endregion

        #region properties
        public Collection<Reservation> AllReservations
        {
            get { return reservations; }
        }
        #endregion

        #region Constructors
        public ReservationDB():base()
        {
            reservations = new Collection<Reservation>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region utility methods

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Reservation aReservation;
            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string reservationId = Convert.ToString(myRow["ReservationID"]).TrimEnd();
                    string guestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    DateTime checkInDate = Convert.ToDateTime(myRow["CheckInDate"]);
                    DateTime checkOutDate = Convert.ToDateTime(myRow["CheckOutDate"]);
                    double totalPrice = Convert.ToDouble(myRow["TotalPrice"]);
                    bool deposit = Convert.ToBoolean(myRow["Deposit"]);
                    aReservation = new Reservation(reservationId, guestID, checkInDate, checkOutDate, totalPrice, deposit);
                    reservations.Add(aReservation);
                }
            }
        }

        private int FindRow(Reservation reservation, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (myRow.RowState == DataRowState.Deleted)
                {
                    rowIndex++;
                    continue;
                }

                // Trim DB-side value (nchar may be padded)
                string reservationId = Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["ReservationID"]).TrimEnd();
                if (reservationId == reservation.ReservationID)
                {
                    returnValue = rowIndex;
                    break;
                }
                rowIndex++;
            }
            return returnValue;
        }



        private void FillRow(DataRow myRow, Reservation reservation, DB.DBOperation operation)
        {
            // Always set the columns for both Add and Edit
            myRow["ReservationID"] = reservation.ReservationID;
            myRow["GuestID"] = reservation.GuestID;
            myRow["CheckInDate"] = reservation.CheckInDate;
            myRow["CheckOutDate"] = reservation.CheckOutDate;
            myRow["TotalPrice"] = reservation.totalPrice;
            myRow["Deposit"] = reservation.DepositPaid;

            // No AcceptChanges() here — we want the DataRow state to remain Modified for Update()
        }


        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Reservation reservation, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string table = table1;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, reservation, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;

                case DBOperation.Edit:
                    int editIndex = FindRow(reservation, table);
                    if (editIndex < 0)
                    {
                        // Optionally throw or log; for now show message
                        MessageBox.Show("Edit failed: reservation row not found in DataSet.");
                        return;
                    }
                    aRow = dsMain.Tables[table].Rows[editIndex];
                    FillRow(aRow, reservation, operation);
                    break;

                case DBOperation.Delete:
                    int delIndex = FindRow(reservation, table);
                    if (delIndex < 0)
                    {
                        MessageBox.Show("Delete failed: reservation row not found in DataSet.");
                        return;
                    }
                    aRow = dsMain.Tables[table].Rows[delIndex];
                    aRow.Delete();
                    break;
            }
        }

        #endregion

        #region Build Parameter, Create commands and Update Database

        private void Build_Insert_Parameter(Reservation reservation)
        {
            SqlParameter param = new SqlParameter("@ReservationID", SqlDbType.NChar, 10, "ReservationID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Deposit", SqlDbType.Bit, 1, "Deposit"); // <-- FIXED HERE
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Decimal);
            param.Precision = 18;
            param.Scale = 2;
            param.SourceColumn = "TotalPrice";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 1, "Deposit");
            param = new SqlParameter("@Deposit", SqlDbType.Bit, 1, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_Insert_Command(Reservation reservation)
        {
           daMain.InsertCommand = new SqlCommand("INSERT INTO Reservation"+
                " (ReservationID, GuestID, CheckInDate, CheckOutDate, TotalPrice, Deposit) " +
                " VALUES (@ReservationID, @GuestID, @CheckInDate, @CheckOutDate, @TotalPrice, @DepositPaid)", cnMain);
            Build_Insert_Parameter(reservation);
        }

        private void Build_Update_Parameter(Reservation reservation)
        {
            SqlParameter param = new SqlParameter("@ReservationID", SqlDbType.NChar, 10, "ReservationID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Decimal);
            param.Precision = 18;
            param.Scale = 2;
            param.SourceColumn = "TotalPrice";
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 1, "Deposit");
            param.SourceVersion = DataRowVersion.Current; 
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@OriginalReservationID", SqlDbType.NChar, 10, "ReservationID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_Update_Parameter(Reservation reservation)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Decimal);
            param.Precision = 18;
            param.Scale = 2;
            param.SourceColumn = "TotalPrice";
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Deposit", SqlDbType.Bit, 1, "Deposit"); // matches DB column
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@OriginalReservationID", SqlDbType.NChar, 10, "ReservationID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_Update_Command(Reservation reservation)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Reservation " +
                "SET GuestID = @GuestID, " +
                "CheckInDate = @CheckInDate, " +
                "CheckOutDate = @CheckOutDate, " +
                "TotalPrice = @TotalPrice, " +
                "Deposit = @Deposit " +
                "WHERE ReservationID = @OriginalReservationID", cnMain);

            Create_Update_Parameter(reservation);
        }



        private void Build_Delete_Command(Reservation reservation)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@OriginalReservationID", SqlDbType.NChar, 10, "ReservationID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_Delete_Command(Reservation reservation)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @OriginalReservationID", cnMain);
            Build_Delete_Command(reservation);
        }

        public bool UpdateDataSource(Reservation reservation)
        {
            bool success = true;
            Create_Insert_Command(reservation);
            Create_Update_Command(reservation);
            Create_Delete_Command(reservation);

            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }
        #endregion
    }
}
