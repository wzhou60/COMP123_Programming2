﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Week_10_lab_17_gui_interface_shapes
{
    public abstract class Primitive
    {
        protected Color color;

        protected bool filled;
        protected Rectangle boundingRectangle;

        public Primitive(Color color, bool filled, Rectangle boundingRectangle)
        {
            this.color = color;
            this.filled = filled;
            this.boundingRectangle = boundingRectangle;
        }
    }
}