using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static HotelSystem.Database.DB;

namespace HotelSystem.Database
{
    internal class GuestDB: DB
    {

        #region Fields
        private string table1 = "Guest";
        private string sqlLocal1 = "SELECT * FROM Guest";

        private Collection<Guest> guests;
        #endregion

        #region properties
        public Collection<Guest> AllGuests { get { return guests; } }
        #endregion

        #region Constructors
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
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
            Guest aGuest;

            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string ID = Convert.ToString(myRow["ID"]).TrimEnd();
                    string name = Convert.ToString(myRow["Name"]).TrimEnd();
                    string phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    string address = Convert.ToString(myRow["Address"]).TrimEnd();
                    string guestID = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    string guestAccount = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    aGuest = new Guest(ID, name, phone, address, guestID, guestAccount);
                    guests.Add(aGuest);
                }
            }
        }

        private int FindRow(Guest guest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRowVar in dsMain.Tables[table].Rows)
            {
                myRow = myRowVar;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string guestId = Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]).TrimEnd();
                    if (guestId == guest.GuestID)
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        private void FillRow(DataRow myRow, Guest guest, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                myRow["GuestID"] = guest.GuestID;
                myRow["ID"] = guest.ID;
                myRow["Name"] = guest.Name;
                myRow["Address"] = guest.Address;
                myRow["Phone"] = guest.Phone;
                myRow["GuestAccID"] = guest.GuestAccount;
            }
        }


        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Guest guest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string table = table1;

            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, guest, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(guest, table)];
                    FillRow(aRow, guest, operation);
                    break;
                case DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(guest, table)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ID", SqlDbType.NVarChar, 25, "ID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NChar, 10, "Phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NChar, 50, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestAccID", SqlDbType.NChar, 10, "GuestAccID");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (GuestID, ID, Name, Address, Phone, GuestAccID) VALUES (@GuestID, @ID, @Name, @Address, @Phone, @GuestAccID)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }

        #endregion
    }
}
