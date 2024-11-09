using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_project_2
{
    internal class Food
    {
        int fID;
        string name;
        string description;
        double cost;

        public Food(int afID, string aname, string adescription,double acost)
        {
            this.fID = afID;
            this.name = aname;
            this.description = adescription;
            this.cost = acost; 
            
        }

        public int FoodId
        {
            get { return fID; }
            set { fID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        } 

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public bool TooMuch()
        {
            if (cost > 100)
            {
                return true;
            }
            return false;
        }



    }
}
