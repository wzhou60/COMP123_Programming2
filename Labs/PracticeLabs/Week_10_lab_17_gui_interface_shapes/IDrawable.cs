using System;

using System.Drawing;
using System.Drawing.Imaging;

namespace Week_10_lab_17_gui_interface_shapes
{
    internal interface IDrawable
    {
        void Draw(Graphics g);
    }

    internal interface IWritable
    {
        void Write(TextWriter writer);
    }
}