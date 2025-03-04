using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace ZooApp
{
    internal class Dog : Animal, IWorkable
    {
        public override void Talk()
        {
            Console.WriteLine("Woof!");
        }

        public void Work()
        {
            Console.WriteLine("The dog is working!");
        }
    }
}