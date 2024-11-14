using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_12_project
{
    public class Parts
    {
        int partnum;
        string partName, partDescription;
        double cost;

        public Parts(int pn, double c, string partn, string partd)
        {
            partnum = pn;
            partName = partn;
            partDescription = partd;
            cost = c;
        }

        public int PartNum
        {
            get { return partnum; } 
            set { partnum = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }

        public string ParDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }

    }
}
