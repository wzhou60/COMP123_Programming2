using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalLibrary;

namespace ZooApp
{
    internal class Cow : Animal, IWorkable
    {
        public override void Talk()
        {
            Console.WriteLine("Moo!");
        }

        public void Work()
        {
            Console.WriteLine("The cow is working!");
        }
    }
}