using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_10_cw
{
    public class Employee
    {
        int empID;
        string fname, lname;

        public int EmployeeId //property example with int empID data.
        {
            get { return empID; }
            set { empID = value; }
        }

        public string Firstname
        {
            get { return fname; } set { fname = value; }
        }

        public string Lastname
        {
            get { return lname; }
            set { lname = value; }
        }


    }
}
