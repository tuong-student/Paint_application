using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_application
{
    internal abstract class Shape
    {
        internal Rectangle rectangle;
        internal Point p1;
        internal Point p2;
        internal Graphics g;
        internal bool flagZoom = false;
        internal int zoom;
        internal int width;
        internal int height;


        public abstract void Draw();

        public bool ContainPoint(Point point)
        {
            //Check if this point belong to this shape
            if (rectangle.Contains(point))
                return true;
            else
                return false;
        }

        public abstract void Zoom(int z);
    }
}
