using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_06_lab_16_Inheritance_Shapes_S
{
     abstract class Shape
    {
        private string name;
        protected abstract double Area 
        { get; }

        protected Shape(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            //return $"{name} has an area of {Area:F2}";
            return $"{name} :  {Area:F2}";
        }
    }
}
