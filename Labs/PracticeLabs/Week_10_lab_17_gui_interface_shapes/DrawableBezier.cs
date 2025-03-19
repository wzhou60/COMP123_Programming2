using System.Drawing;

namespace Week_10_lab_17_gui_interface_shapes
{
    internal class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            curveStart = start;
            controlFirst = first;
            controlSecond = second;
            curveEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color,2.5f);
            g.DrawBezier(pen, curveStart, controlFirst, controlSecond, curveEnd);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Bezier: {color}, curveStart:{curveStart}, controlFirst:{controlFirst}, controlSecond:{controlSecond}, curveEnd:{curveEnd} {curveStart} {controlFirst} {controlSecond} {curveEnd}");
        }
    }
}