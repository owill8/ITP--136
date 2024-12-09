using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_project
{
    internal class CakeOrders
    {
        public CakeOrders(string caken, string caked, string cakeDecoration)
        {
            CakeName = caken;
            CakeDescription = caked;
            CakeDecoration = cakeDecoration;
        }

        public string CakeName { get; set; }

        public string CakeDescription { get; set; }

        public string CakeDecoration { get; set; }
    }
}
