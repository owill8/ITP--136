using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_project
{
    internal class Design
    {
        public Design(string line)
        {
            var split = line.Split(',');
            DesignId = Convert.ToInt32(split[0]);
            DesignName = split[1];
        }

        public int DesignId { get; set; }
        public string DesignName { get; set; }
    }
}
