using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_project
{
    public class Person
    {
        public int IdNum { get; set; }

        public string fullName { get; set; }

        public string address { get; set; }

        public Person(int id, string fn, string add)
        {
            IdNum = id;
            fullName = fn;
            address = add;
        }
        
             
        
    }
}
