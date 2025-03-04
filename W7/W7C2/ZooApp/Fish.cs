using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;
namespace ZooApp
{
    internal class Fish : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Glub Glub!");
        }
    }
}
