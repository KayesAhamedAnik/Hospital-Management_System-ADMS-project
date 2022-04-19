using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace ProjectDemo.Data
{
    public class DataAccess
    {
        private static OracleConnection sqlCon;


        public static OracleConnection SqlCon
        {
            get
            {
                try
                {
                    if (sqlCon == null)
                    {
                        sqlCon = new OracleConnection(@"TNS_ADMIN = C:\oraclexe\app\oracle\product\10.2.0\server\NETWORK\ADMIN; USER ID = PROJECTDB;Password=pass; DATA SOURCE = localhost:1521 / XE; PERSIST SECURITY INFO = True");
                    }
                    else if (sqlCon.State != ConnectionState.Open)
                    {
                        sqlCon.Open();
                    }
                    return sqlCon;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        } 
        //public static bool ExecuteStoredProcedure(String query, bool result, params string[] parameter)// this will return boolean
        //{
        //    OracleCommand Cmd = new OracleCommand();
        //    Cmd.Connection = SqlCon;
        //    Cmd.CommandText = query;
        //    Cmd.CommandType = CommandType.StoredProcedure;
        //    try
        //    {
        //        Cmd.ExecuteNonQuery();
        //        OracleDataReader odr = Cmd.ExecuteReader();

        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //    return false;
        //}
        public static  DataSet GetDataSet(string query)
        {
            OracleCommand sqcom = new OracleCommand(query, SqlCon);
            OracleDataAdapter sda = new OracleDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;

        }
        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }
        public static int ExecuteUpdateQuery(string query)
        {
            OracleCommand sqcom = new OracleCommand(query, SqlCon);
            return sqcom.ExecuteNonQuery();
        }
    }
}

