using System.Drawing;

namespace Week_10_lab_17_gui_interface_shapes
{
    internal class DrawableRectangle : Primitive, IDrawable, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle boundingRectangle) : base(color, filled, boundingRectangle)
        {
        }

        public void Draw(Graphics g)
        {
            if (filled)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillRectangle(brush, boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(color);
                g.DrawRectangle(pen, boundingRectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Rectangle: {color} {filled} {boundingRectangle}");
        }
    }

    internal class DrawableEllipse : Primitive, IDrawable, IWritable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle boundingRectangle) : base(color, filled, boundingRectangle)
        {
        }

        public void Draw(Graphics g)
        {
            if (filled)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, boundingRectangle);
            }
            else
            {
                Pen pen = new Pen(color, 2.5f);
                g.DrawEllipse(pen, boundingRectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Rectangle: {color}, Filled: {filled}, Bounding Rectangle: {boundingRectangle}");
        }
    }
}