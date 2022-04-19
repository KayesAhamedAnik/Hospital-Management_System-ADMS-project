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
    class PatientRepo
    {
        public string patient_Crud(string queryType, Patient patient)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " patient_package.patient_CRUD";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
                    Cmd.Parameters.Add("pid", OracleDbType.Varchar2).Value = patient.patientId;
                    Cmd.Parameters.Add("nam", OracleDbType.Varchar2).Value = patient.name;
                    Cmd.Parameters.Add("bg", OracleDbType.Varchar2).Value = patient.bloodGroup;
                    Cmd.Parameters.Add("wt", OracleDbType.Int32).Value = patient.weight;
                    Cmd.Parameters.Add("ag", OracleDbType.Int32).Value = patient.age;
                    Cmd.Parameters.Add("pno", OracleDbType.Int32).Value = patient.phoneNo;
                    Cmd.Parameters.Add("eCon", OracleDbType.Int32).Value = patient.emergencyContact;
                    Cmd.Parameters.Add("adrs", OracleDbType.Varchar2).Value = patient.address;
                    Cmd.Parameters.Add("sick", OracleDbType.Varchar2).Value = patient.sickness;

                    Cmd.Parameters.Add("result", OracleDbType.Varchar2, 30).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    var result = Cmd.Parameters["result"].Value;
                    return result.ToString();

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
        public string patient_Discharge(string pid,int amt,string dtl,string dDate)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " patient_package.patient_Discharge";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("pid", OracleDbType.Varchar2).Value = pid;
                    Cmd.Parameters.Add("amt", OracleDbType.Int16).Value = amt;
                    Cmd.Parameters.Add("dtl", OracleDbType.Varchar2).Value = dtl;
                    Cmd.Parameters.Add("dDate", OracleDbType.Varchar2).Value = dDate;

                    Cmd.Parameters.Add("result", OracleDbType.Varchar2, 30).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();
                    var result = Cmd.Parameters["result"].Value;
                    return result.ToString();

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
        public string patient_Admission_Crud(string queryType, Admit admit)
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = " patient_package.patient_admit_CRUD";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("queryType ", OracleDbType.Varchar2).Value = queryType;
                    Cmd.Parameters.Add("aid", OracleDbType.Int32).Value = admit.admissionId;
                    Cmd.Parameters.Add("pid", OracleDbType.Varchar2).Value = admit.patientId;
                    Cmd.Parameters.Add("wno", OracleDbType.Int32).Value = admit.wardNo;
                    Cmd.Parameters.Add("st", OracleDbType.Varchar2).Value = admit.status;
                    Cmd.Parameters.Add("aDate", OracleDbType.Varchar2).Value = admit.admissionDate;
                    Cmd.Parameters.Add("dDate", OracleDbType.Varchar2).Value =admit.dischargeDate;
                    Cmd.Parameters.Add("aDoctor", OracleDbType.Varchar2).Value = admit.assignedDoctor;
                    Cmd.Parameters.Add("bid", OracleDbType.Int32).Value = admit.billId;

                    Cmd.Parameters.Add("result", OracleDbType.Varchar2, 40).Direction = ParameterDirection.Output; //out parameter --query succesion

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
        public string patientIDGenerator()
        {
            using (OracleConnection oCon = new OracleConnection("DATA SOURCE = localhost:1521;USER ID = PROJECTDB;Password=pass"))
            {
                OracleCommand Cmd = new OracleCommand();
                try
                {
                    Cmd.Connection = oCon;
                    Cmd.CommandText = "patient_package.patient_IdGenerator";
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.Parameters.Add("pid", OracleDbType.Varchar2, 6).Direction = ParameterDirection.Output; //out parameter --query succesion

                    oCon.Open();
                    Cmd.ExecuteNonQuery();

                    var result = Cmd.Parameters["pid"].Value.ToString();
                    string[] id = result.Split('-');
                    int number = Convert.ToInt32(id[1]);
                    string eid = (++number).ToString("d4");
                    return "P-" + eid;
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
        public List<Patient> GetAllpatients()
        {
            try
            {
                var patientList = new List<Patient>();
                var sql = "SELECT *from patient order by patientid";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    Patient P = ConvertToEntity(dt.Rows[index]);
                    patientList.Add(P);
                }
                return patientList;
              
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private Patient ConvertToEntity(DataRow row)
        {
          
                if (row == null)
            {
                return null;
            }
            var P = new Patient();
            P.patientId = row["patientId"].ToString();
            P.name = row["name"].ToString();
            P.bloodGroup = row["bloodgroup"].ToString();
            P.weight = Int32.Parse(row["weight"].ToString());
            P.phoneNo = Int32.Parse(row["phoneno"].ToString());
            P.emergencyContact = Int32.Parse(row["emergencycontact"].ToString());
            P.sickness = row["sickness"].ToString();
            P.age =Int32.Parse(row["age"].ToString());
            P.address = row["address"].ToString();
            //DateTime dt = new DateTime();
            return P;
        }
        public List<Admit> GetAllAdmissions()
        {
            try
            {
                var admissionList = new List<Admit>();
                var sql = "SELECT *from admit order by admissionid";
                var dt = DataAccess.GetDataTable(sql);

                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    Admit A = ConvertToAdmissionEntity(dt.Rows[index]);
                    admissionList.Add(A);
                }
                return admissionList;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string[] getPatientIds()
        {
            try
            {

                var patientList = new List<Doctor>();
                var sql = "select patientid,name from patient where patientid not in(select patientid from admit where status='Active')";
                var dt = DataAccess.GetDataTable(sql);
                string[] arr = new string[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    if (dt.Rows[index].Field<string>("patientid") != null)
                    {
                        arr[index] = dt.Rows[index].Field<string>("patientid")+"    "+dt.Rows[index].Field<string>("name");

                    }
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string[] getActivePatientIds()
        {
            try
            {

                var patientList = new List<Doctor>();
                var sql = "select patientid,name from patient where patientid  in(select patientid from admit where status='Active')";
                var dt = DataAccess.GetDataTable(sql);
                string[] arr = new string[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    if (dt.Rows[index].Field<string>("patientid") != null)
                    {
                        arr[index] = dt.Rows[index].Field<string>("patientid") + "    " + dt.Rows[index].Field<string>("name");

                    }
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string[] getPatientNames(string id)
        {
            try
            {

                var sql = "select name from patient where patientid='"+id+"'";
                var dt = DataAccess.GetDataTable(sql);
                string[] arr = new string[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                    if (dt.Rows[index].Field<string>("name") != null)
                    {
                        arr[index] = dt.Rows[index].Field<string>("name");

                    }
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private Admit ConvertToAdmissionEntity(DataRow row)
        {

            if (row == null)
            {
                return null;
            }
            var A = new Admit();
            A.patientId = row["patientId"].ToString();
            A.admissionId =int.Parse(row["admissionid"].ToString());
            A.admissionDate = row["admissiondate"].ToString();
            A.dischargeDate = row["dischargedate"].ToString();
            A.assignedDoctor = row["assignedDoctor"].ToString();
            A.wardNo = int.Parse(row["wardno"].ToString());
            A.billId = int.Parse(row["billid"].ToString());
            A.status = row["status"].ToString();
            return A;
        }

    }
}
