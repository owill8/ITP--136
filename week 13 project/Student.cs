using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_project
{
    public class Student : Person
    {
        public Student(int id, string name, string add, string major, string advisor) : base(id, name, add)
        {
            Advisor = advisor;
            Major = major;
        }
        public string Advisor {  get; set; }
        public string Major { get; set; }
    }
}
