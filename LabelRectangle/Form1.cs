using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabelRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"D:\xp_wallpaper.jpg");
            Graphics graphics = Graphics.FromImage(bitmap);

            e.Graphics.DrawImage(bitmap, new Point(0, 0));
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

        private void lblRectangle_MouseUp(object sender, MouseEventArgs e)
        {
            _isResizing = false;
            _isDragging = false;
        }

        private void lblRectangle_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;

            if (((e.X + 5) > control.Width) && ((e.Y + 5) > control.Height))
            {
                control.Cursor = Cursors.SizeNWSE;
            }
            else
            {
                control.Cursor = Cursors.Arrow;
            }
        }

        private void lblRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = (Control) sender;

            if (e.X > control.Width && e.Y > control.Height)
            {
                _isResizing = true;
            }
            else
            {
                _isDragging = true;
            }
        }

        private bool _isResizing;
        private bool _isDragging;
    }
}
