using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicApp
{
    public partial class RectangleForm : Form
    {
        #region "Private Instance Variables"
        private Point _startPoint;
        private bool _isDragging;
        private bool _isResizingBottomRight;
        private bool _isResizingTopRight;
        #endregion

        #region "Public Properties"
        public List<Label> Rectangles { get; private set; }
        #endregion

        public RectangleForm()
        {
            InitializeComponent();
        }

        #region "Exposed methods"
        public Label AddRectangle(Rectangle rectangle)
        {
            var lblRectangle = new Label()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(rectangle.X, rectangle.Y),
                Size = new Size(rectangle.Width, rectangle.Height)
            };

            lblRectangle.MouseDown += label_MouseDown;
            lblRectangle.MouseMove += label_MouseMove;
            lblRectangle.MouseUp += label_MouseUp;
            lblRectangle.MouseLeave += (senderargs, eventargs) => Cursor = Cursors.Default;

            Rectangles.Add(lblRectangle);

            return lblRectangle;
        }

        public void ClearLabels()
        {
            Rectangles = null;
            Rectangles = new List<Label>();
        }
        #endregion

        #region "Events Handlers"
        private void addLabelRectamgleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lblRectangle = new Label()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(100, 100),
                Location = new Point(MousePosition.X, MousePosition.Y)
            };

            lblRectangle.MouseDown += label_MouseDown;
            lblRectangle.MouseMove += label_MouseMove;
            lblRectangle.MouseUp += label_MouseUp;
            lblRectangle.MouseLeave += (senderargs, eventargs) => Cursor = Cursors.Default;

            Controls.Add(lblRectangle);
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;

            _startPoint = new Point(e.X, e.Y);

            if (e.X + 5 > label.Width && e.Y + 5 > label.Height)
            {
                _isResizingBottomRight = true;
            }
            else if (e.X + 5 > label.Width && e.Y < 5)
            {
                _isResizingTopRight = true;
            }
            else
            {
                _isDragging = true;
            }
        }

        private void label_MouseUp(object sender, MouseEventArgs e)
        {
            _isResizingBottomRight = false;
            _isDragging = false;
            _isResizingTopRight = false;
        }

        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;

            if (_isResizingBottomRight)
            {
                label.Size = new Size(e.X, e.Y);
            }
            else if (_isResizingTopRight)
            {
                label.Top += e.Y - _startPoint.Y;
                label.Size = new Size(e.X, label.Height + -e.Y);
            }
            else if (_isDragging)
            {
                label.Left += e.X - _startPoint.X;
                label.Top += e.Y - _startPoint.Y;
            }
            else
            {
                ChangeCursor(label, e.Location);
            }
        } 
        #endregion

        private void ChangeCursor(Label label, Point e)
        {
            bool BottomRight = label.Width < e.X + 5 && label.Height < e.Y + 5;
            bool TopRight = e.X + 5 > label.Width && e.Y == 0;

            bool Left = e.X == 0 && e.Y + 5 > label.Height;
            bool Top = false;
            bool Right = e.X + 5 > label.Width && e.Y < label.Height;
            bool Bottom = false;

            if (BottomRight)
            {
                Cursor = Cursors.SizeNWSE;
            }
            else if (TopRight)
            {
                Cursor = Cursors.SizeNESW;
            }
            else if (Left)
            {
                Cursor = Cursors.SizeWE;
            }
            else if (Top)
            {
                Cursor = Cursors.SizeNS;
            }
            else if (Right)
            {
                Cursor = Cursors.SizeWE;
            }
            else if (Bottom)
            {
                Cursor = Cursors.SizeNS;
            }
            else
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
