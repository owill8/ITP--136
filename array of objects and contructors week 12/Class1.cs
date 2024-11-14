using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace array_of_objects_and_contructors_week_12
{
    public class Employee
    {
        int employeeNum;
        double salary;
        string fname, lname, position;

        public Employee(int EmpNum, double s, string ln, string fn, string pos)
        {
            employeeNum = EmpNum;
            salary = s;
            fname = ln;
            lname = fn;
            position = pos;

        }

        public int EmployeeNumber
        {
            get { return employeeNum; }//get function
            set { employeeNum = value; }//set function
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string FirstName
        {
            get { return fname; } 
            set { fname = value; }
        }

        public string LastName
        {
            get { return lname; } 
            set { lname = value; }
        }

        public string Position
        {
            get { return  position; } 
            set { position = value; } 
        }



    }
}
