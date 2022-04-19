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
    class DoctorRepo
    {
        public bool doctor_Crud(string queryType,Doctor doctor)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " doctor_package.doctor_CRUD";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
                    Cmd.Parameters.Add("did", OracleDbType.Varchar2).Value = doctor.doctorId;
                    Cmd.Parameters.Add("dep", OracleDbType.Varchar2).Value = doctor.dept;
                    Cmd.Parameters.Add("sch", OracleDbType.Varchar2).Value = doctor.schedule;
                    Cmd.Parameters.Add("eid", OracleDbType.Varchar2).Value = doctor.empid;
                    Cmd.Parameters.Add("dtl", OracleDbType.Varchar2).Value = doctor.details;
                    Cmd.Parameters.Add("result", OracleDbType.Varchar2,30).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    var result = int.Parse(Cmd.Parameters["result"].Value.ToString());
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
        public string DoctorAppointment_Crud(string queryType, Appointment app)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {//queryType varchar2,aid appointment.appointmentid%type,did doctor.doctorid%type,aDate appointment.APPOINTMENTDATE%type,pName appointment.PATIENT_NAME%type,pid appointment.PATIENTID%type,result out varchar2 );
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " doctor_package.appointment_CRUD";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
                    Cmd.Parameters.Add("aid", OracleDbType.Int16).Value =app.appointmentId ;
                    Cmd.Parameters.Add("did", OracleDbType.Varchar2).Value = app.doctorID;
                    Cmd.Parameters.Add("aDate", OracleDbType.Varchar2).Value = app.appointmentDate;
                    Cmd.Parameters.Add("pName", OracleDbType.Varchar2).Value = app.patientName;  
                    Cmd.Parameters.Add("pid", OracleDbType.Varchar2).Value = app.patientId;
                    Cmd.Parameters.Add("result", OracleDbType.Varchar2, 30).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    string result = Cmd.Parameters["result"].Value.ToString();
                    return result;
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
        public List<Doctor> GetDoctors()
        {
            try
            {
                var patientList = new List<Doctor>();
                var sql = "SELECT doc.doctorid,emp.ename,doc.schedule,doc.dept,details from employees emp,doctor doc where emp.empid = doc.empid order by dept";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    Doctor D = ConvertToDoctorEntity(dt.Rows[index]);
                    patientList.Add(D);
                }
                return patientList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Appointment> GetAppointments(string id,string date)
        {
            try
            {
                var appList = new List<Appointment>();
                var sql = "SELECT appointmentid,patient_name,appointmentDate from appointment where doctorid='"+id+ "' and appointmentDate='"+date+"' ";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    Appointment A = ConvertToAppointementEntity(dt.Rows[index]);
                    appList.Add(A);
                }
                return appList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Appointment ConvertToAppointementEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var A = new Appointment();
           A.appointmentId =Int16.Parse(row["appointmentid"].ToString());
           A.patientName = row["patient_name"].ToString();
           A.appointmentDate = row["appointmentdate"].ToString();


            return A;
        }
        public int[] getAvailableWards()
        {
            try
            {

                var patientList = new List<Doctor>();
                var sql = "SELECT wardno from ward where status=0 order by wardno";
                var dt = DataAccess.GetDataTable(sql);
                int[] arr = new int[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                  //  if (dt.Rows[index].Field<Int16>("wardno")!=null)
                    {
                        arr[index] =dt.Rows[index].Field<Int16>("wardno");

                    }
                }
                return arr; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string[]  GetDoctorNames(string dept)
        {
            try
            {
               if(dept=="")
                {
                    var patientList = new List<Doctor>();
                    var sql = "SELECT emp.ename,doc.doctorid from employees emp,doctor doc where emp.empid = doc.empid order by doctorid";
                    var dt = DataAccess.GetDataTable(sql);
                    string[] arr = new string[dt.Rows.Count];
                    for (int index = 0; index < dt.Rows.Count; index++)
                    {
                        if (dt.Rows[index].Field<string>("ename") != null)
                        {
                            arr[index] = dt.Rows[index].Field<string>("doctorid")+"  "+dt.Rows[index].Field<string>("ename");

                        }
                        else
                        {
                            arr[index] = "No Doctor Found";

                        }

                    }

                    return arr;
                }
                else
                {
                    var patientList = new List<Doctor>();
                    var sql = "SELECT emp.ename,doc.doctorid from employees emp,doctor doc where emp.empid = doc.empid and dept='" + dept + "' order by ename";
                    var dt = DataAccess.GetDataTable(sql);
                    string[] arr = new string[dt.Rows.Count];
                    for (int index = 0; index < dt.Rows.Count; index++)
                    {
                        if (dt.Rows[index].Field<string>("ename") != null)
                        {
                            arr[index] = dt.Rows[index].Field<string>("ename") + "                     | " + dt.Rows[index].Field<string>("doctorid");

                        }
                        else
                        {
                            arr[index] = "No Doctor Found";

                        }

                    }

                    return arr;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Doctor ConvertToDoctorEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var D = new Doctor();
            D.doctorId = row["doctorid"].ToString();
            D.ename = row["ename"].ToString();
            D.dept = row["dept"].ToString();
            D.schedule = row["schedule"].ToString();
            D.details = row["details"].ToString();

            return D;
        }
        public string doctorIDGenerator()
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " doctor_package.Id_Generator";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("did", OracleDbType.Varchar2, 6).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();

                    var result = Cmd.Parameters["did"].Value.ToString();
                    string[] id = result.Split('-');
                    int number = Convert.ToInt32(id[1]);
                    string eid = (++number).ToString("d4");
                    return "D-" + eid;
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

    }
}
