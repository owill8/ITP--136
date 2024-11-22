using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_cw
{
    internal class Salary : Employee
        //child class
    {
        public Salary(int num, string fn, double sal) : base(num, fn)//these are matching base class constuctor
        {
            SalaryAmount = sal;

        }
        public double SalaryAmount { get; set; }
    }
}
