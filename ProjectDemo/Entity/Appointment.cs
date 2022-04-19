using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entity
{
    class Appointment
    {
        //queryType varchar2,aid appointment.appointmentid%type,did doctor.doctorid%type,aDate appointment.APPOINTMENTDATE%type,pName appointment.PATIENT_NAME%type,pid appointment.PATIENTID%type,result out varchar2 );
        public int appointmentId { get; set; }
        public string doctorID { get; set; }
        public string appointmentDate { get; set; }
        public string patientName { get; set; }
        public string patientId { get; set; }
   
    }
}
