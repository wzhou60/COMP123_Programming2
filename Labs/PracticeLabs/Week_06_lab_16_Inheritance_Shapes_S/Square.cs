namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Square : Shape
    {
        protected double Length
        { get; }

        protected override double Area
        {
            get
            {
                return Length * Length;
            }
        }
        public Square(string name, double length) : base(name)
        {
            Length = length;
        }
    }
}