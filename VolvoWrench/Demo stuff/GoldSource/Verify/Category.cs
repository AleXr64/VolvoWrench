﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolvoWrench.Demo_stuff.GoldSource.Verify
{
    public class Category
    {
        public string name;
        public List<Tuple<String,Commandtype>> CommandRules;
        public List<Cvar> CvarRules;

        public Category()
        {
            CommandRules = new List<Tuple<string, Commandtype>>();
            CvarRules = new List<Cvar>();
        }
    }
}
