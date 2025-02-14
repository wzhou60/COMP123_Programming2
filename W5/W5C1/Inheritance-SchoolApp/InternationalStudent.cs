using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_SchoolApp
{
    class InternationalStudent : Student
    {
        public string Country { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Country = {Country}";
        }
    }
}