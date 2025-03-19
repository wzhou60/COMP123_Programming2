namespace Week_06_lab_16_Inheritance_Shapes_S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //although Shape is an abstract is can be used as a reference type
            //any child class of Shape is also a Shape
            double length = 2;
            double width = 3;
            List<Shape> shapes = new List<Shape>{
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Triangle($"triangle – bas:{length}, hei:{width}", length, width),
                //doubling width and length
                new Triangle($"triangle – bas:{length *= 2}, hei:{width *= 2}", length, width),
                new Square($"square – len:{length}", length),
                new Circle($"circle – rad: {length}", length),
                new Rectangle($"rectangle – wid:{length}, len:{width}", length, width),
                new Ellipse($"ellipse – min:{length}, maj:{width}", length, width),
                new Diamond($"diamond – min:{length}, maj:{width}", length, width)
};
            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}