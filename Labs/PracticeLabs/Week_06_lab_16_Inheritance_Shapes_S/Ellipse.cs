using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Ellipse : Rectangle
    {
        protected override double Area
        {
            get
            {
                return Math.PI * Length * Width;
            }
        }

        public Ellipse(string name, double length, double width) : base(name, length, width)
        {
        }
    }
}