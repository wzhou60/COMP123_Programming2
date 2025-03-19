namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Rectangle : Shape
    {
        protected double Width { get; set; }
        protected double Length { get; set; }

        protected override double Area
        {
            get
            {
                return Width * Length;
            }
        }

        public Rectangle(string name, double length, double width) : base(name)
        {
            Width = width;
            Length = length;
        }
    }
}