using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entity
{
   public class Patient
    {
        public string patientId { get; set; }
        public string name { get; set; }
        public string bloodGroup { get; set; }
        public int weight { get; set; }
        public int age { get; set; }
        public long phoneNo { get; set; }
        public long emergencyContact { get; set; }
        public string address { get; set; }
        public string sickness { get; set; }
    }
}
