using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_project
{
    public class Teacher : Person
    {
        public Teacher(int id, string name, string add, double salary, string years_of_service) : base(id, name, add)
        {
            Salary = salary;
            Year_Of_Service = years_of_service;
        }
        public double Salary { get; set; }
        public string Year_Of_Service { get; set; }
    }
}
