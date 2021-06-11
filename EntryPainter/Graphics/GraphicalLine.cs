using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace EntryPainter.Graphics
{
    internal class GraphicalLine
    {
        public Color LineColor { get; set; }
        public float Linewidth { get; set; }
        public bool Selected { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
    }
}
