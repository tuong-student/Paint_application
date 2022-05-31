using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint_application.ShapeClass
{
    internal class FillRectangle : Shape
    {
        SolidBrush myBrush;

        public FillRectangle(Graphics g, SolidBrush brush)
        {
            this.g = g;
            this.myBrush = brush;
        }

        public override void Draw()
        {
            this.width = Math.Abs(this.p2.X - this.p1.X) + this.zoom;
            this.height = Math.Abs(this.p2.Y - this.p1.Y) + this.zoom;

            //Check if width or heigt less than 0 then keep the current value of zoom, dont let user zoom out
            if (this.width < 0 || this.height < 0)
                flagZoom = false;
            else
                flagZoom = true;

            rectangle = new Rectangle(Math.Min(this.p1.X, this.p2.X),
                        Math.Min(this.p1.Y, this.p2.Y),
                        this.width, this.height);
            g.FillRectangle(myBrush, rectangle);
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
