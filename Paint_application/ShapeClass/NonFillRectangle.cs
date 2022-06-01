using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_application.ShapeClass
{
    internal class NonFillRectangle : Shape
    {
        Pen myPen;
        

        public NonFillRectangle(Graphics g, Pen pen, DashStyle dashStyle)
        {
            this.g = g;
            this.myPen = pen;
            this.myPen.DashStyle = dashStyle;
        }

        public override void Draw()
        {
            width = Math.Abs(this.p2.X - this.p1.X) + this.zoom;
            height = Math.Abs(this.p2.Y - this.p1.Y) + this.zoom;

            //Check if width or heigt less than 0 then keep the current value of zoom, dont let user zoom out
            if (this.width < 0 || this.height < 0)
                flagZoom = false;
            else
                flagZoom = true;

            rectangle = new Rectangle(Math.Min(this.p1.X, this.p2.X),
                        Math.Min(this.p1.Y, this.p2.Y),
                        width, height);
            g.DrawRectangle(myPen, rectangle);
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
