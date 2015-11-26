using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelRectangle
{
    public partial class Form1 : Form
    {
        private bool _isResizing;
        private bool _isDragging;

        private Bitmap _bitmap;
        private Point _startPoint;
        private Point _endPoint;

        public Form1()
        {
            _bitmap = new Bitmap(@"D:\xp_wallpaper.jpg");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_bitmap, new Point(0, 0));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
        }

        private void insertRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lblRectangle = new Label
            {
                BackColor = Color.FromArgb(20, Color.Red.R, Color.Red.G, Color.Red.B),
                BorderStyle  = BorderStyle.FixedSingle,
                Location = PointToClient(MousePosition),
                Size = new Size(40, 40)
            };

            lblRectangle.MouseDown += new MouseEventHandler(lblRectangle_MouseDown);
            lblRectangle.MouseMove += new MouseEventHandler(lblRectangle_MouseMove);
            lblRectangle.MouseUp += new MouseEventHandler(lblRectangle_MouseUp);

            Controls.Add(lblRectangle);
        }

        private void lblRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;

            _startPoint = new Point(e.X, e.Y);

            if (((e.X + 5) > control.Width) && (((e.Y + 5) > control.Height)))
            {
                _isResizing = true;
            }
            else
            {
                _isDragging = true;
            }
        }

        private void lblRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;

            if (_isResizing)
            {
                control.Width = e.X;
                control.Height = e.Y;
            }
            else if (_isDragging)
            {
                control.Left += e.X - _startPoint.X;
                control.Top += e.Y - _startPoint.Y;
            }
            else if (((e.X + 5) > control.Width) && ((e.Y + 5) > control.Height))
            {
                control.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                control.Cursor = Cursors.Arrow;
            }
        }

        private void lblRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            _isResizing = false;
            _isDragging = false;
        }
    }
}
