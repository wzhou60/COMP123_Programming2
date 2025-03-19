using System.Drawing;

namespace Week_10_lab_17_gui_interface_shapes
{
    internal class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            this.lineStart = start;
            this.lineEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color,5.0f);
            g.DrawLine(pen, lineEnd, lineStart);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"Line: {color}, Line Start:{lineStart}, Line End:{lineEnd}");
        }
    }
}