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
    class BillRepo
    {

        public string[] getTests()
        {
            try
            {

                var patientList = new List<Doctor>();
                var sql = "select *from tests order by testid";
                var dt = DataAccess.GetDataTable(sql);
                String[] arr = new string[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                       
                        arr[index] =/* dt.Rows[index].Field<Int16>("testid").ToString() + ". " + */dt.Rows[index].Field<string>("testname") + "     ." + dt.Rows[index].Field<Int32>("amount").ToString();
                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string[] getServices()
        {
            try
            {

                var patientList = new List<Doctor>();
                var sql = "select *from charges order by serviceid";
                var dt = DataAccess.GetDataTable(sql);
                string[] arr = new string[dt.Rows.Count];
                for (int index = 0; index < dt.Rows.Count; index++)
                {
                        arr[index] = /*dt.Rows[index].Field<Int32>("serviceid") + ". " +*/ dt.Rows[index].Field<string>("servicename") + "    ." + dt.Rows[index].Field<Int32>("amount");


                }
                return arr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Bill> GetAllBills()
        {
            var billList = new List<Bill>();
            var sql = "select *from bill order by billid";
            var dt = DataAccess.GetDataTable(sql);

            for (int index = 0; index < dt.Rows.Count; index++)
            {
                Bill B = ConvertToBillEntity(dt.Rows[index]);
                billList.Add(B);
            }
            return billList;
        }
        private Bill ConvertToBillEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var  B = new Bill();
            B.billid=Int16.Parse(row["billid"].ToString());
            B.amount= Int16.Parse(row["amount"].ToString());
            B.due= Int16.Parse(row["Due"].ToString());
            B.billdetails= row["billdetails"].ToString();
            B.patientId= row["patientid"].ToString();

            return B;
        }
    }
}
