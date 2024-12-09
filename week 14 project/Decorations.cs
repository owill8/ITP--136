﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_project
{
    internal class Decorations
    {
        public Decorations(string line)
        {
            var split = line.Split(',');
            DecorationId = Convert.ToInt32(split[0]);
            DecorationName = split[1];
        }
        public int DecorationId { get; set; }
        public string DecorationName { get; set; }
    }
}
