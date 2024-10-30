using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK10__project_
{
    public class Food
    {

        int fID;
        string name;
        string description;
        double cost;


        public int FoodID
        {
            get { return fID; }
            set { fID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

    }
}
