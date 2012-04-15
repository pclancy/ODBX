using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ODBX.Controls
{
    public partial class GradientPanel : Panel
    {
        public Color GradientStartColor { get; set; }
        public Color GradientEndColor { get; set; }
        public Color LineColor { get; set; }
        public bool LineTop { get; set; }
        public bool LineBottom { get; set; }
        public bool LineLeft { get; set; }
        public bool LineRight { get; set; }

        public GradientPanel()
        {
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            PaintGradient(e);
        }

        private void PaintGradient(PaintEventArgs e)
        {
            //var gradBrush = new LinearGradientBrush(new Point(0, 0), new Point(Width, Height),
            //    GradientStartColor, GradientEndColor);

            var gradBrush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), GradientStartColor, GradientEndColor, LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(gradBrush, new Rectangle(0, 0, Width, Height));

            if (LineTop)
            {
                e.Graphics.DrawLine(new Pen(LineColor), 0, 0, Width, 0);
            }

            if (LineBottom)
            {
                e.Graphics.DrawLine(new Pen(LineColor), 0, Height - 1, Width, Height - 1);
            }

            if (LineLeft)
            {
                e.Graphics.DrawLine(new Pen(LineColor), 0, 0, 0, Height);
            }

            if (LineRight)
            {
                e.Graphics.DrawLine(new Pen(LineColor), Width - 1, 0, Width -1, Height);
            }
        }

    }
}