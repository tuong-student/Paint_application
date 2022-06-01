using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint_application.ShapeClass;

namespace Paint_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            selectedShapes = new List<Shape>();
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            pen = new Pen(Color.Black, size);
            erase = new Pen(Color.White, size);
            dashStyle = DashStyle.Solid;
            new_color = Color.Black;
        }

        float size = 1;

        List<Shape> shapes, selectedShapes;
        Shape zoomedShape = null;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        bool fill = false;
        bool dragging = false;
        bool zooming = false;
        bool touchedShape = false;
        bool multiselect;

        Point p1, p2;
        Point currentPositionCursor;
        Point newPositionCursor;
        int position;

        int index = 0;
        Pen pen;
        DashStyle dashStyle;
        Pen erase;
        ColorDialog cd = new ColorDialog();
        Color new_color;


        private void pic_color_Click(object sender, EventArgs e)
        {
            btn_color_Click(sender, e);
        }

        private void pictrureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (zooming == true && zoomedShape != null)
            {
                if (e.Delta > 0)
                {
                    zoomedShape.Zoom(1);
                    pictureBox1.Refresh();
                }
                else
                {
                    zoomedShape.Zoom(-1);
                    pictureBox1.Refresh();
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Refresh screen every time it has change on the screen
            switch (index)
            {
                case 6:
                    for(int i = 0; i<shapes.Count - 1; i++)
                    {
                        shapes[i].g = e.Graphics;
                        shapes[i].Draw();
                        shapes[i].g = g;
                    }
                    break;
                default:
                    foreach (Shape shape in shapes)
                    {
                        shape.g = e.Graphics;
                        shape.Draw();
                        shape.g = g;
                    }
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = p2 = e.Location; //Set point to free draw and erase

            dragging = true;
            paint = true;

            if (Form.ModifierKeys == Keys.Control)
                multiselect = true;
            switch (index)
            {
                case 1:
                    dragging = false;
                    break;
                case 2:
                    dragging = false;
                    break;
                case 3:
                    if (fill)
                    {
                        Shape fillEllipse = new FillEllipse(g, new SolidBrush(new_color));
                        fillEllipse.p1 = e.Location;
                        fillEllipse.p2 = e.Location;
                        shapes.Add(fillEllipse);
                    }
                    else
                    {
                        Shape ellipse = new NonFillEllipse(g, new Pen(new_color, size), dashStyle);
                        ellipse.p1 = e.Location;
                        ellipse.p2 = e.Location;
                        shapes.Add(ellipse);
                    }
                    dragging = false;
                    break;
                case 4:
                    if (fill)
                    {
                        Shape fillRectangle = new FillRectangle(g, new SolidBrush(new_color));
                        fillRectangle.p1 = e.Location;
                        fillRectangle.p2 = e.Location;
                        shapes.Add(fillRectangle);
                    }
                    else
                    {
                        Shape rectangle = new NonFillRectangle(g, new Pen(new_color, size), dashStyle);
                        rectangle.p1 = e.Location;
                        rectangle.p2 = e.Location;
                        shapes.Add(rectangle);
                    }
                    dragging = false;
                    break;
                case 5:
                    Shape line = new Line(g, new Pen(new_color, size), dashStyle);
                    line.p1 = e.Location;
                    line.p2 = e.Location;
                    shapes.Add(line);
                    dragging = false;
                    break;
                case 6:
                    Shape arc = new Arc(g, new Pen(new_color, size), dashStyle);
                    arc.p1 = e.Location;
                    arc.p2 = e.Location;
                    shapes.Add(arc);
                    dragging = false;
                    break;
                case 8:
                    if (fill)
                    {
                        Shape fillcircle = new FillCircle(g, new SolidBrush(new_color));
                        fillcircle.p1 = e.Location;
                        fillcircle.p2 = e.Location;
                        shapes.Add(fillcircle);
                    }
                    else
                    {
                        Shape cirle = new NonFillCircle(g, new Pen(new_color, size), dashStyle);
                        cirle.p1 = e.Location;
                        cirle.p2 = e.Location;
                        shapes.Add(cirle);
                    }
                    dragging = false;
                    break;
                default:
                    paint = false;
                    break;
            }

            if (dragging == true)
            {
                for (int i = 0; i < shapes.Count; i++)
                {
                    if (shapes[i].ContainPoint(e.Location))
                    {
                        if (multiselect == true)
                            selectedShapes.Add(shapes[i]);
                        currentPositionCursor = e.Location;
                        position = i;
                        touchedShape = true;
                        zoomedShape = shapes[i];
                        zooming = true;
                    }
                }
                if (touchedShape == false)
                    dragging = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //Calculate offset
            if (dragging == true)
            {
                newPositionCursor = e.Location;
                int offSetX = newPositionCursor.X - currentPositionCursor.X;
                int offSetY = newPositionCursor.Y - currentPositionCursor.Y;
                currentPositionCursor = newPositionCursor;

                this.shapes[position].p1.X += offSetX;
                this.shapes[position].p1.Y += offSetY;
                this.shapes[position].p2.X += offSetX;
                this.shapes[position].p2.Y += offSetY;
                pictureBox1.Refresh();
            }

            if (!paint) return;
            dragging = false;

            switch (index)
            {
                case 1:
                    p1 = e.Location;
                    g.DrawLine(pen, p1, p2);
                    p2 = p1;
                    break;
                case 2:
                    p1 = e.Location;
                    g.DrawLine(erase, p1, p2);
                    p2 = p1;
                    break;
                default:
                    shapes.Last().p2 = e.Location;
                    break;
            }
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            index = 0;  //Unchoose shape
            pictureBox1.Refresh();
            fill = false;
            dragging = false;
            zooming = false;
            paint = false;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //if(index == 7)
            //{
            //    Point p = set_point(pictureBox1, e.Location);
            //    Fill(bm, p.X, p.Y, new_color);
            //    pictureBox1.Refresh();
            //}
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void numberBox_ValueChanged(object sender, EventArgs e)
        {
            size = (float) numberBox.Value;
            pen = new Pen(Color.Black, size);
            erase = new Pen(Color.White, size);
        }

        private void btn_fill_shape_Click(object sender, EventArgs e)
        {
            fill = true;
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t **Programmer** \n School: University of Technology and Education \n \nNguyễn Thanh Tường-19110066");
        }

        private void btn_arc_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static Point set_point(PictureBox pictureBox, Point point)
        {
            float p1 = 1f * pictureBox.Image.Width / pictureBox.Width;
            float p2 = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * p1), (int)(point.Y * p2));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> stackPixel, int x, int y, Color current_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == current_color)
            {
                stackPixel.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void dashStylePicker_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (dashStylePicker.SelectedItem.ToString())
            {
                case "Dash":
                    dashStyle = DashStyle.Dash;
                    break;
                case "DashDot":
                    dashStyle = DashStyle.DashDot;
                    break;
                case "DashDotDot":
                    dashStyle = DashStyle.DashDotDot;
                    break;
                case "Dot":
                    dashStyle = DashStyle.Dot;
                    break;
                case "Solid":
                    dashStyle = DashStyle.Solid;
                    break;
            }
            pen.DashStyle = dashStyle;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedShapes.Count == 0)
                return;
            foreach (var item in selectedShapes)
            {
                shapes.Remove(item);
            }
            pictureBox1.Refresh();
        }

        private void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color current_color = bm.GetPixel(x, y);
            Stack<Point> stackPixel = new Stack<Point>();
            stackPixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);
            if (current_color == new_color) return;

            while (stackPixel.Count > 0)
            {
                Point p = (Point)stackPixel.Pop();
                if (p.X > 0 && p.Y > 0 && p.X < bm.Width - 1 && p.Y < bm.Height - 1)
                {
                    validate(bm, stackPixel, p.X - 1, p.Y, current_color, new_color);
                    validate(bm, stackPixel, p.X, p.Y - 1, current_color, new_color);
                    validate(bm, stackPixel, p.X + 1, p.Y, current_color, new_color);
                    validate(bm, stackPixel, p.X, p.Y + 1, current_color, new_color);
                }
            }
        }
    }
}
