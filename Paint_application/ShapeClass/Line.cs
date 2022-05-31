using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_application.ShapeClass
{
    internal class Line : Shape
    {
        Pen myPen;

        public Line(Graphics g, Pen pen, DashStyle dashStyle)
        {
            this.g = g;
            this.myPen = pen;
            myPen.DashStyle = dashStyle;
        }

        public override void Draw()
        {
            g.DrawLine(this.myPen, this.p1, this.p2);
        }

        public override void Zoom(int z)
        {
            if (flagZoom == false && z < 0)
                return;
            else
                zoom += z;
        }
    }
}
