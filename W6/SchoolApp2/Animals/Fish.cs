﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Fish : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Glub Glub!");
        }
    }
}
