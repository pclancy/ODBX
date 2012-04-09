using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ODBX.Controls
{
    public partial class GradientTable : TableLayoutPanel
    {
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            PaintGradient(e);

        }

        private void PaintGradient(PaintEventArgs e)
        {
            var gradBrush = new LinearGradientBrush(new Point(0, 0),
                                                    new Point(Width, Height), StartColor, EndColor);
            e.Graphics.FillRectangle(gradBrush, new Rectangle(0, 0, Width, Height));
        }

    }
}