using HotelSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Database
{
    public class DB
    {
        // Connection string fixed: removed unsupported 'Application Intent=ReadWrite;'
        private static string strConn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelSystemDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        protected SqlConnection cnMain = new SqlConnection(strConn);
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        public enum DBOperation
        {
            Add = 0,
            Edit = 1,
            Delete = 2
        }

        #region Constructor
        public DB()
        {
            try
            {
                // Only re-initialize if not already set
                if (cnMain == null)
                    cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                if (cnMain.State != ConnectionState.Open)
                    cnMain.Open();
                //dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }
        }

        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                if (cnMain.State != ConnectionState.Open)
                    cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }
            return success;
        }
    }
}
