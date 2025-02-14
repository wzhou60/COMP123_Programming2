using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Talk();
        
        public override string ToString()
        {
            return $"{GetType()} Name: {Name}";
        }
    }
}
