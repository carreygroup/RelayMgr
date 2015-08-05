using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CSharpWin;

namespace RelayMgr
{
    public partial class RegionControl : UserControl
    {
        private Color _borderColor = Color.FromArgb(23, 169, 254);

        public RegionControl()
        {
            InitializeComponent();
            CreateRegion();

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            CreateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = ClientRectangle;
            rect.Width--;
            rect.Height--;
            using (Pen pen = new Pen(_borderColor))
            {
                using (GraphicsPath path = CreatePath(ClientRectangle))
                {
                    e.Graphics.DrawPath(
                        pen,
                        path);
                }
                using (GraphicsPath path = CreatePath(rect))
                {
                    e.Graphics.DrawPath(
                        pen,
                        path);
                }
            }
        }

        private void CreateRegion()
        {
            using (GraphicsPath path = CreatePath(ClientRectangle))
            {
                Region = new Region(path);
            }
        }

        private GraphicsPath CreatePath(Rectangle rect)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y + 30, 8, 8, 180, 90);

            path.AddCurve(new Point[] {
                new Point(rect.X + rect.Width/2 + 5,rect.Y + 30),
                new Point(rect.X + rect.Width/2,rect.Y + 15),
                new Point(rect.X + rect.Width/2 - 10,rect.Y)}, 1f);

            path.AddCurve(new Point[] {
                new Point(rect.X + rect.Width/2 - 10,rect.Y),
                new Point(rect.X + rect.Width/2+ 10,rect.Y + 15),
                new Point(rect.X + rect.Width/2 + 20,rect.Y + 30)}, 1f);

            path.AddArc(rect.Right - 9, rect.Y + 30, 8, 8, 270, 90);
            path.AddArc(rect.Right - 9, rect.Bottom - 9, 8, 8, 0, 90);
            path.AddArc(rect.X, rect.Bottom - 9, 8, 8, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
