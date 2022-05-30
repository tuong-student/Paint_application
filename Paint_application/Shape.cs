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
        internal Point p1;
        internal Point p2;
        internal Graphics g;
        internal Pen myPen;
        internal bool flagZoom = false;
        internal int zoom;
        internal int width;
        internal int height;
        internal Rectangle rectangle;

        public abstract void Draw();

        public bool ContainPoint(Point point)
        {
            //Check if this point belong to this shape
            if (rectangle.Contains(point))
                return true;
            else
                return false;
        }

        public void Zoom(int z)
        {
            if (flagZoom == false && z < 0)
                return;
            else
                zoom += z;
        }
    }
}
