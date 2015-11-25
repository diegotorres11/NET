using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsPathApp
{
    public partial class Form1 : Form
    {
        private readonly List<Point> _points;
        private readonly System.Drawing.Drawing2D.GraphicsPath _path;
        private readonly List<Rectangle> _rectangles; 

        public Form1()
        {
            InitializeComponent();

            _points = new List<Point>
            {
              new Point(10, 10),
              new Point(200, 10),
              new Point(200, 200)
            };

            _path = new System.Drawing.Drawing2D.GraphicsPath();
            _rectangles = new List<Rectangle>();
        }

        private void btnDrawPath_Click(object sender, EventArgs e)
        {
            //if (_path.PathData.Points.Length == 0)
            _path.AddPolygon(_points.ToArray());

            _rectangles.Add(new Rectangle(300, 300, 200, 200));

            _path.AddRectangles(_rectangles.ToArray());

            Graphics graphics = CreateGraphics();

            graphics.DrawPath(Pens.Turquoise, _path);
            graphics.Dispose();
        }

        private void btnFillpath_Click(object sender, EventArgs e)
        {
            Graphics graphics = CreateGraphics();

            graphics.FillPath(Brushes.Blue, _path);
            graphics.Dispose();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(Pens.Teal, _path);
            e.Graphics.FillPath(Brushes.Blue, _path);
        }

        private void btnDrawBitmap_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(@"C:\Users\Fischer\Downloads\xp_wallpaper.jpg");

            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.DrawImage(bitmap, new Point(0,0));
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_path.IsVisible(e.Location))
            {
                _path.Reset();

                foreach (Rectangle rectangle in _rectangles)
                {
                    if (rectangle.Contains(e.Location))
                    {
                        _rectangles.Remove(rectangle);
                    }
                    else
                    {
                        _path.AddRectangle(rectangle);
                    }
                }
                
                this.Invalidate();

                //MessageBox.Show("Inside the polygon");
            }
        }
    }
}
