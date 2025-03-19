using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_lab_17_gui_interface_shapes
{
    internal class DrawableArc: Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end) : base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end; 
        }

        public void Draw(Graphics g)
        {

            Pen pen = new Pen(color);
            g.DrawArc(pen, boundingRectangle, start, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Arc: {color}, Filled: {filled}, Bounding Rectangle: {boundingRectangle}, {start}, {end}");
        }
    }
}
