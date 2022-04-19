using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.Entity
{
    class Bill
    {
        public int billid { get; set; }
        public string patientId { get; set; } //inherit patient
        public string billdetails { get; set; }
        public int amount { get; set; }
        public int due { get; set; }
        public int discount { get; set; }

    }
}
