using HotelSystem.Logic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HotelSystem.Database
{
    internal class GuestAccountDB : DB
    {
        #region  Data members        
        private string table1 = "GuestAccount";
        private string sqlLocal1 = "SELECT * FROM GuestAccount";
        
        private Collection<GuestAccount> guestAccounts;

        #endregion

        #region Property Method: Collection
        public Collection<GuestAccount> AllGuestAccounts
        {
            get
            {
                return guestAccounts;
            }
        }
        #endregion

        #region Constructor
        public GuestAccountDB() : base()
        {
            guestAccounts = new Collection<GuestAccount>();
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
            //Declare references to a myRow object and an GuestAcc object
            DataRow myRow = null;
            GuestAccount aGuestAcc;
            
            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                   
                    //Obtain each attribute from the specific field in the row in the table
                    
                    string guestAccID = Convert.ToString(myRow["GuestAccID"]).TrimEnd();
                    string guestID  = Convert.ToString(myRow["GuestID"]).TrimEnd();
                    DateTime dateCreated = Convert.ToDateTime(myRow["DateCreated"]);
                    double totAmount = Convert.ToDouble(myRow["TotalAmount"]);
                    string status = Convert.ToString(myRow["Status"]).TrimEnd();

                    aGuestAcc = new GuestAccount(guestAccID, guestID, dateCreated, totAmount, status);
                    
                    
                    guestAccounts.Add(aGuestAcc);
                }
            }
        }

        private void FillRow(DataRow aRow, GuestAccount aGuestAcc, DB.DBOperation operation)
        {


            if (operation == DB.DBOperation.Add)
            {
                aRow["GuestAccID"] = aGuestAcc.GuestAccID;
                aRow["GuestID"] = aGuestAcc.GuestID;
                aRow["DateCreated"] = aGuestAcc.DateCreated;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["TotalAmount"] = aGuestAcc.TotalAmount;
                aRow["Status"] = aGuestAcc.Status;
                
            }else if (operation == DB.DBOperation.Edit)
            {
                aRow["GuestID"] = aGuestAcc.GuestID;
                aRow["DateCreated"] = aGuestAcc.DateCreated;  //NOTE square brackets to indicate index of collections of fields in row.
                aRow["TotalAmount"] = aGuestAcc.TotalAmount;
                aRow["Status"] = aGuestAcc.Status;
            }

        }

        public int FindRow(GuestAccount aGuestAcc, string table)
        {
            int rowIndex = 0;
            DataRow myRow;

            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aGuestAcc.GuestAccID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestAccID"]).TrimEnd())
                    {
                        returnValue = rowIndex;
                        break;
                    }
                }
                rowIndex++;

            }
            return returnValue;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(GuestAccount aGuestAcc, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table1;
            

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, aGuestAcc, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuestAcc, dataTable)];
                    FillRow(aRow, aGuestAcc, operation);
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(aGuestAcc, dataTable)];
                    aRow.Delete();
                    break;
            }


        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(GuestAccount aGuestAcc)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestAccID", SqlDbType.NChar, 10, "GuestAccID");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            
            param = new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalAmount", SqlDbType.Decimal);
            param.Precision = 18;      // total digits
            param.Scale = 2;           // digits after decimal
            param.SourceColumn = "TotalAmount";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NChar, 10, "Status");
            daMain.InsertCommand.Parameters.Add(param);
            
        }

        private void Create_INSERT_Command(GuestAccount aGuestAcc)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO GuestAccount" +
                 " (GuestAccID, GuestID, DateCreated, TotalAmount, Status) " +
                 " VALUES (@GuestAccID, @GuestID, @DateCreated, @TotalAmount, @Status)", cnMain);
            Build_INSERT_Parameters(aGuestAcc);
        }

        public bool UpdateDataSource(GuestAccount aGuestAcc)
        {
            bool success = true;
            //Create_INSERT_Command(aGuestAcc);//repeated this line by mistake .
            
            Create_INSERT_Command(aGuestAcc);
            Create_UPDATE_Command(aGuestAcc);
           // Create_DELETE_Command(aGuestAcc);

            success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }

        public void Build_UPDATE_Parameters(GuestAccount aGuestAcc)
        {
            SqlParameter param;

            param = new SqlParameter("@GuestAccID", SqlDbType.NChar, 10, "GuestAccID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NChar, 10, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DateCreated", SqlDbType.DateTime, 8, "DateCreated");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalAmount", SqlDbType.Decimal);
            param.Precision = 18;      // total digits
            param.Scale = 2;           // digits after decimal
            param.SourceColumn = "TotalAmount";
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NChar, 10, "Status");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_GuestAccID", SqlDbType.NChar, 10, "GuestAccID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);


        }

        public void Create_UPDATE_Command(GuestAccount aGuestAcc)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE GuestAccount SET GuestID = @GuestID,  DateCreated = @DateCreated, TotalAmount = @TotalAmount, " +
                " Status = @Status  WHERE GuestAccID = @Original_GuestAccID", cnMain);

            Build_UPDATE_Parameters(aGuestAcc);
        }

        private void Create_DELETE_Command(GuestAccount aGuestAcc)
        {
            SqlParameter param = new SqlParameter("@Original_GuestAccID", SqlDbType.NVarChar, 10, "GuestAccID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }


        #endregion

    }
}
