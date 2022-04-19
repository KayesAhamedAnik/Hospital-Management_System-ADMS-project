using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entity
{
    class Admit
    {
        public int admissionId { get; set; }
        public string patientId { get; set; }
        public int wardNo { get; set; }
        public string status { get; set; }
        public string admissionDate { get; set; }
        public string dischargeDate { get; set; }
        public string assignedDoctor { get; set; }
        public int billId { get; set; } // inherit bill, patient,doctor

    }
}
