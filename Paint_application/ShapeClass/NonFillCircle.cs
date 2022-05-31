using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_application.ShapeClass
{
    internal class NonFillCircle : Shape
    {
        int radius = 0;
        Pen myPen;

        public NonFillCircle(Graphics g, Pen pen, DashStyle dashStyle)
        {
            this.g = g;
            this.myPen = pen;
            myPen.DashStyle = dashStyle;
        }

        public override void Draw()
        {
            radius = Math.Abs(this.p2.X - this.p1.X);

            if (Math.Abs(this.p2.Y - this.p1.Y) >= radius)
                radius = Math.Abs(this.p2.Y - this.p1.Y);

            int startPointX = this.p1.X - radius;
            int startPointY = this.p1.Y - radius;

            //Reset zoom out action
            if (this.radius + this.zoom <= 0)
                flagZoom = false;
            else
                flagZoom = true;

            this.radius = this.radius + this.zoom;

            rectangle = new Rectangle(startPointX, startPointY, radius * 2, radius * 2);
            g.DrawEllipse(myPen, rectangle);
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
