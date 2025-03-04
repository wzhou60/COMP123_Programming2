using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace ZooApp
{
    internal class Horse : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Neigh!");
        }
    }
}