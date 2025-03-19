using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Diamond : Rectangle
    {
        protected override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public Diamond(string name, double length, double width) : base(name, length, width)
        {
        }
    }
}