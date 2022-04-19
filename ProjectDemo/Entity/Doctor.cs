using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entity
{
    public class Doctor:Employee
    {
        public string doctorId { get; set; }
        public string dept { get; set; }
        public string schedule { get; set; }
        public string details { get; set; }
        public string empid { get; set; }
    }
}
