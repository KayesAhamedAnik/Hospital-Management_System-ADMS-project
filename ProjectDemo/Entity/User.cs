using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectDemo.Entity
{
    class User:Employee
    {
        public string userid { get; set; }
        public string password
        {
            get; set;
        }
        public string role{ get; set; }
        public string status { get; set; }
    }
}
