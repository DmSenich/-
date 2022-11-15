using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace AIS_Polyclinic
{
    public class SqlManager
    {
        static string pathDB = "materials\\DATABASE.FDB";
        FbConnection fbConnection = new FbConnection();

        public SqlManager()
        {
            FbConnectionStringBuilder cs = new FbConnectionStringBuilder();
            
            cs.DataSource = "localhost";
            cs.UserID = "SYSDBA";
            cs.Password = "masterkey";
            cs.Database = Path.GetFullPath(pathDB);
            cs.Charset = "win1251";
            string ConnString = cs.ToString();
            fbConnection.ConnectionString = ConnString;
            //fbConnection.Open();
        }

        public DataTable iExecuteReader(string sSql)
        {
            fbConnection.Open();
            FbCommand fbCommand = new FbCommand(sSql, fbConnection);
            fbCommand.CommandType = CommandType.Text;
            //FbTransaction fbt = fbConnection.BeginTransaction(IsolationLevel.Serializable);
            //fbCommand.Transaction = fbt;
            DataTable dt = new DataTable();
            try
            {
                FbDataReader fbDataReader = fbCommand.ExecuteReader();
                dt.Load(fbDataReader);
                //fbt.Commit();
                fbCommand.Dispose();
                fbConnection.Close();
                return dt;
            }
            catch (Exception ex)
            {
                fbCommand.Dispose();
                fbConnection.Close();
                return null;
            }
        }
        public void iExeecuteNonQuery(string sSql)
        {
            fbConnection.Open();
            FbCommand fbCommand = new FbCommand(sSql, fbConnection);
            //FbTransaction fbt = fbConnection.BeginTransaction(IsolationLevel.Serializable);
            //fbCommand.Transaction = fbt;
            try
            {
                fbCommand.ExecuteNonQuery();
                //fbt.Commit();
                fbCommand.Dispose();
                fbConnection.Close();

            }
            catch(Exception ex)
            {

                fbCommand.Dispose();
                fbConnection.Close();
            }
        }
        public int iExecuteScalar(string sSql)
        {
            fbConnection.Open();
            FbCommand fbCommand = new FbCommand(sSql, fbConnection);
            //FbTransaction fbt = fbConnection.BeginTransaction(IsolationLevel.Serializable);
            //fbCommand.Transaction = fbt;
            try
            {
                
                fbCommand.CommandType=CommandType.Text;
                int i = Convert.ToInt32(fbCommand.ExecuteScalar());
                //fbt.Commit();
                fbCommand.Dispose();
                fbConnection.Close();
                return i;
            }
            catch (Exception ex)
            {
                fbCommand.Dispose();
                fbConnection.Close();
                return -1;
            }
        }

        //public void Open()
        //{
        //    fbConnection.Open();
        //}
        public void Close()
        {
            //fbConnection.Close();
        }
    }
}
