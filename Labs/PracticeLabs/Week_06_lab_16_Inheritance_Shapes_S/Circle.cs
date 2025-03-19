using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Circle : Square
    {
        protected override double Area
        {
            get
            {
                return Math.PI * Length * Length;
            }
        }

        public Circle(string name, double length) : base(name, length)
        {
        }
    }
}