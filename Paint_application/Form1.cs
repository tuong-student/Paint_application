using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            pen = new Pen(Color.Black, size);
            brush = new SolidBrush(Color.Black);
            erase = new Pen(Color.White, size);
            dashStyle = DashStyle.Solid;
        }

        float size = 1;

        List<Shape> shapes;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        bool fill = false;
        bool dragging = false;
        Point p1, p2;
        int index = 0;
        int x, y, startX, startY, width, height;
        Pen pen;
        DashStyle dashStyle;
        Pen erase;
        SolidBrush brush;
        ColorDialog cd = new ColorDialog();
        Color new_color;


        private void pic_color_Click(object sender, EventArgs e)
        {
            btn_color_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Refresh screen every time it has change on the screen
            Graphics g = e.Graphics;
            if (!paint) return;

            switch (index)
            {
                case 3:
                    if (fill) { g.FillEllipse(brush, startX, startY, width, height); }
                    else
                    {
                        g.DrawEllipse(pen, startX, startY, width, height);
                    }
                    break;
                case 4:
                    if (fill) { g.FillRectangle(brush, startX, startY, width, height); }
                    else
                    {
                        g.DrawRectangle(pen, startX, startY, width, height);
                    }
                    break;
                case 5:
                    g.DrawLine(pen, startX, startY, x, y);
                    break;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            pen.Color = cd.Color;
            brush.Color = cd.Color;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            dragging = true;
            p1 = e.Location;
            p2 = e.Location;

            startX = e.Location.X;
            startY = e.Location.Y;

            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
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
            }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            width = x - startX;
            height = y - startY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            width = x - startX;
            height = y - startY;

            switch (index)
            {
                case 3:
                    if (fill) 
                    { 
                        g.FillEllipse(brush, startX, startY, width, height); 
                    }
                    else
                    {
                        g.DrawEllipse(pen, startX, startY, width, height);
                    }
                    break;
                case 4:
                    if (fill) { g.FillRectangle(brush, startX, startY, width, height); }
                    else
                    {
                        g.DrawRectangle(pen, startX, startY, width, height);
                    }
                    break;
                case 5:
                    g.DrawLine(pen, startX, startY, x, y);
                    break;
            }
            fill = false;
            paint = false;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point p = set_point(pictureBox1, e.Location);
                Fill(bm, p.X, p.Y, new_color);
                pictureBox1.Refresh();
            }
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
            pen.Color = pic_color.BackColor;
            brush.Color = pic_color.BackColor;
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

        private void Fill(Bitmap bm, int x, int y, Color new_color)
        {
            Color current_color = bm.GetPixel(x, y);
            Stack<Point> stackPixel = new Stack<Point>();
            stackPixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_color);
            if (current_color == new_color) return;

            while(stackPixel.Count > 0)
            {
                Point p = (Point)stackPixel.Pop();
                if(p.X > 0 && p.Y > 0 && p.X < bm.Width-1 && p.Y < bm.Height - 1)
                {
                    validate(bm, stackPixel, p.X-1, p.Y, current_color, new_color);
                    validate(bm, stackPixel, p.X, p.Y-1, current_color, new_color);
                    validate(bm, stackPixel, p.X+1, p.Y, current_color, new_color);
                    validate(bm, stackPixel, p.X, p.Y+1, current_color, new_color);
                }
            }
        }
    }
}
