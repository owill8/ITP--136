using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_13_cw
{
    internal class Commission : Employee
    {
        public Commission(int num, string fn, double commis) : base(num, fn)
        {
            Sales = commis;
        }
        public double Sales
        {
            get { return PayAmt; }
            set { PayAmt = value * .02; }
        }

            double PayAmt;
    }
}
