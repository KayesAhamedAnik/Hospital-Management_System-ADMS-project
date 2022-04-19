using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using ProjectDemo.Entity;
using ProjectDemo.Data;

namespace ProjectDemo.Repo
{
    class UserRepo  
    {
     
        public string Login(String id, string password)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();  
                try 
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " user_package.LoginAuthentication";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("uid", OracleDbType.Varchar2).Value = id;
                    Cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = password;
                    Cmd.Parameters.Add("result", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    var result = Cmd.Parameters["result"].Value;
                    return result.ToString();
                    
                }
                catch (Exception ex)
                {
                    // throw ex;
                    return ex.ToString();
                }
                finally 
                {
                    oCon.Close();
                }
                
            }
        }
        public bool User_CRUD(string id,string password,string role, int status,string queryType)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " user_package.User_Insert_Update_Delete";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("uid", OracleDbType.Varchar2).Value = id;
                    Cmd.Parameters.Add("pass", OracleDbType.Varchar2).Value = password;
                    Cmd.Parameters.Add("rl", OracleDbType.Varchar2).Value = role;
                    Cmd.Parameters.Add("st", OracleDbType.Varchar2).Value = status;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
        
                    oCon.Open();
                    int result = Cmd.ExecuteNonQuery();
                    if (result!=0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    oCon.Close();
                }

            }
        }

        public String UserName(String id)
        {
            var dt = DataAccess.GetDataTable("select ename from employees where empid='" + id + "'");
            string value = dt.Rows[dt.Rows.Count - 1]["name"].ToString();

            return value;
        }

        public List<User> GetAllUser()
        {
            var UserList = new List<User>();
            var sql = "select *from users order by userId";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                User U = ConvertToEntity(dt.Rows[index]);
                UserList.Add(U);
            }
            return UserList;
        }
        public List<User> Search(String text)
        {
            var UserList = new List<User>();
            var sql = "select * from employees where ename like '" + text + "%'";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                User U = SearchUser(dt.Rows[index]);
                UserList.Add(U);
            }
            return UserList;
        }
        private User SearchUser(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var U = new User();

            U.userid = row["id"].ToString();
            U.designation = row["designation"].ToString();


            return U;
        }


        private User ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
           else if (row["status"].ToString()=="1")
            {
                var U = new User();
                U.userid = row["userid"].ToString();
                U.role = row["role"].ToString();
                U.password = row["password"].ToString();
                U.status = "Enabled";
                return U;
            }
            else if (row["status"].ToString() == "0")
            {
                var U = new User();
                U.userid = row["userid"].ToString();
                U.role = row["role"].ToString();
                U.password = row["password"].ToString();
                U.status = "Disabled";
                return U;
            }
            return null;

           
        }
        public string ReturnPassword(string id)
        {
            try
            {
                String query = "select *from users where userId='" + id + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt.Rows.Count == 0 || dt == null)
                {
                    return null;
                }
                else
                {
                    String sql = "select password  from users where userId='" + id + "'";
                    var dT = DataAccess.GetDataTable(sql);
                    string pass = dt.Rows[dt.Rows.Count - 1]["password"].ToString();
                    return pass;
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public bool Save(String uid, String pass, string role)
        {
            try
            {
                string query = "select * from users where userId = '" + uid + "'";
                var dt = DataAccess.GetDataTable(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    query = "Insert into users values ('" + uid + "','" + pass + "','" + role + "')";
                }
                else
                {
                    query = "Update users set password= '" + pass + "' where userId = '" + uid + "'";
                }

                int count = DataAccess.ExecuteUpdateQuery(query);

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }
        public bool Delete(string id)
        {
            string query = "select * from users where userId= '" + id + "'";
            var dt = DataAccess.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from users where userId = '" + id + "'";
            int count = DataAccess.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }

    }
}

