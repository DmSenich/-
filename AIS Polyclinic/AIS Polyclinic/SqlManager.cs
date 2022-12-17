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
        public void iExeecuteAddDoctor(string ln, string fn, string patr, int workEx, byte[] blob)
        {
            fbConnection.Open();
            string sSql = $"EXECUTE PROCEDURE add_doctor(@ln, @fn, @p, @WorkEx, @blob)";

            FbCommand fbCommand = new FbCommand(sSql, fbConnection);

            fbCommand.Parameters.AddWithValue("ln", ln);
            fbCommand.Parameters.AddWithValue("fn", fn);
            fbCommand.Parameters.AddWithValue("p", patr);
            fbCommand.Parameters.AddWithValue("workEx", workEx);

            FbParameter pBlob = new FbParameter("blob", FbDbType.Binary, blob.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, blob);
            fbCommand.Parameters.Add(pBlob);
            //FbTransaction fbt = fbConnection.BeginTransaction(IsolationLevel.Serializable);
            //fbCommand.Transaction = fbt;
            try
            {
                fbCommand.ExecuteNonQuery();
                //fbt.Commit();
                fbCommand.Dispose();
                fbConnection.Close();

            }
            catch (Exception ex)
            {

                fbCommand.Dispose();
                fbConnection.Close();
            }
        }
        public void iExeecuteUpDoctor(int id,string ln, string fn, string patr, int workEx, byte[] blob)
        {
            fbConnection.Open();
            string sSql = $"update \"DOCTOR_TABLE\" set last_name = @ln, first_name = @fn, PATRONYMIC = @p, WORK_EXPERIENCE = @workEx, photo = @blob where id_doctor = @id";

            FbCommand fbCommand = new FbCommand(sSql, fbConnection);

            fbCommand.Parameters.AddWithValue("ln", ln);
            fbCommand.Parameters.AddWithValue("fn", fn);
            fbCommand.Parameters.AddWithValue("p", patr);
            fbCommand.Parameters.AddWithValue("workEx", workEx);
            fbCommand.Parameters.AddWithValue("id", id);

            FbParameter pBlob = new FbParameter("blob", FbDbType.Binary, blob.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, blob);
            fbCommand.Parameters.Add(pBlob);
            //FbTransaction fbt = fbConnection.BeginTransaction(IsolationLevel.Serializable);
            //fbCommand.Transaction = fbt;
            try
            {
                fbCommand.ExecuteNonQuery();
                //fbt.Commit();
                fbCommand.Dispose();
                fbConnection.Close();

            }
            catch (Exception ex)
            {

                fbCommand.Dispose();
                fbConnection.Close();
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
