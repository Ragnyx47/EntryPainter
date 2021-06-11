using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace EntryPainter.Graphics
{
    abstract class GraphicObject
    {
        public abstract void Draw(Canvas canvas);
    }
}
