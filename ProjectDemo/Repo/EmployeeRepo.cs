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
    class EmployeeRepo
    {
        public bool employee_Crud(string queryType,string eid,string name,string bg,int wt,int ag,int pno,int eCon,string adrs,string medh,int sal,string des,string jDate)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " employee_package.employee_CRUD";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
                    Cmd.Parameters.Add("eid", OracleDbType.Varchar2).Value = eid;
                    Cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
                    Cmd.Parameters.Add("bg", OracleDbType.Varchar2).Value = bg;
                    Cmd.Parameters.Add("wt", OracleDbType.Int32).Value = wt;
                    Cmd.Parameters.Add("ag", OracleDbType.Int32).Value = ag;
                    Cmd.Parameters.Add("pno", OracleDbType.Int32).Value = pno;
                    Cmd.Parameters.Add("eCon", OracleDbType.Int32).Value = eCon;
                    Cmd.Parameters.Add("adrs", OracleDbType.Varchar2).Value = adrs;
                    Cmd.Parameters.Add("medh", OracleDbType.Varchar2).Value = medh;
                    Cmd.Parameters.Add("sal", OracleDbType.Int64).Value = sal;
                    Cmd.Parameters.Add("des", OracleDbType.Varchar2).Value = des;
                    Cmd.Parameters.Add("jDate", OracleDbType.Varchar2).Value = jDate;
                    Cmd.Parameters.Add("result", OracleDbType.Int32).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    int result = int.Parse(Cmd.Parameters["result"].Value.ToString());
                    if (result == 1)
                    { return true; }
                    else
                        return false;
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
        public string employeeIDGenerator()
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " employee_package.Id_Generator";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("eid", OracleDbType.Varchar2,6).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();

                    var result = Cmd.Parameters["eid"].Value.ToString();
                    string[] id = result.Split('-');
                    int number = Convert.ToInt32(id[1]);
                    string eid=  (++number).ToString("d4");
                    return "E-" + eid;
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
        public List<Employee> GetAllEmployees()
        {
            try
            {
                var patientList = new List<Employee>();
                var sql = "SELECT *from employees order by empid";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    Employee E = ConvertToEmployeeEntity(dt.Rows[index]);
                    patientList.Add(E);
                }
                return patientList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Employee> Search(String text)
        {
            var empList = new List<Employee>();
            var sql = "select * from employees where ename like '" + text + "' or empid like '"+text+"' or designation like '"+text+"'";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Employee E = SearchEmployee(dt.Rows[index]);
                empList.Add(E);
            }
            return empList;
        }
        private Employee SearchEmployee(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var E = new Employee();

            E.empId = row["empid"].ToString();
            E.ename = row["ename"].ToString();
            E.designation = row["designation"].ToString();


            return E;
        }
        private Employee ConvertToEmployeeEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var E = new Employee();
            E.empId = row["empid"].ToString();
            E.ename = row["ename"].ToString();
            E.bloodGroup = row["bloodgroup"].ToString();
            E.weight = Int32.Parse(row["weight"].ToString());
            E.age = Int32.Parse(row["age"].ToString());
            E.phoneNo = Int64.Parse(row["phoneno"].ToString());
            E.emergencyContact = Int64.Parse(row["emergencyContact"].ToString());
            E.address = row["address"].ToString();
            E.medicalHistory = row["medicalhistory"].ToString();
            E.salary = Int32.Parse(row["salary"].ToString());
            E.designation = row["designation"].ToString();
            E.joinningDate = row["joinningDate"].ToString();
 
            return E;
        }
        //public bool Save(Employee emp)
        //{
        //    try
        //    {
        //        string query = "select * from employees where empid = '" + emp.empId + "'";
        //        var dt = DataAccess.GetDataTable(query);

        //        if (dt == null || dt.Rows.Count == 0)
        //        {
        //            query = "Insert into employees values ('" + emp.empId + "','" + emp.ename + "','"+emp.bloodGroup + "','"+emp.weight+ "','"+emp.age+ "','"+emp.phoneNo+ "','"+emp.emergencyContact+ "','"+emp.address+ "','"+emp.medicalHistory+ "','"+emp.salary+ "','"+emp.designation+ "','" + emp.joinningDate + "')";
        //        }
        //        else
        //        {
        //            query = "Update employees set ename = '" + emp.ename + "',bloodgroup='"+emp.bloodGroup + "',weight='"+emp.weight+ "',age='"+emp.age+ "',phoneno= '" + emp.phoneNo + "',emergencycontact= '" + emp.emergencyContact + "',medicalhistory= '" + emp.medicalHistory + "',salary='" + emp.salary + "',designation= '" + emp.designation + "',joinningDate= '" + emp.joinningDate + "',address= '" + emp.address + "' where empid = '" + emp.empId + "'";
        //        }

        //        int count = DataAccess.ExecuteUpdateQuery(query);

        //        if (count >= 1)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
