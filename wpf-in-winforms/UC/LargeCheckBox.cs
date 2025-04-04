using System.Drawing;
using System.Windows.Forms;

namespace wpf_in_winforms.UC
{
    public class LargeCheckBox : CheckBox
    {
        public LargeCheckBox()
        {
            this.TextAlign = ContentAlignment.MiddleLeft;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            // Scale tick box size based on font height, with an optional scaling factor.
            int tickSize = (int)(this.Font.Height * 0.8);
            var tickRect = new Rectangle(new Point(0, this.Height / 2 - tickSize / 2), new Size(tickSize, tickSize));

            if (this.FlatStyle == FlatStyle.Flat)
            {
                ControlPaint.DrawCheckBox(e.Graphics, tickRect,
                    this.Checked ? ButtonState.Flat | ButtonState.Checked : ButtonState.Flat | ButtonState.Normal);
            }
            else
            {
                ControlPaint.DrawCheckBox(e.Graphics, tickRect,
                    this.Checked ? ButtonState.Checked : ButtonState.Normal);
            }

            int padding = 4;
            var textRect = new Rectangle(tickRect.Right + padding, 0,
                this.ClientSize.Width - tickRect.Right - padding, this.ClientSize.Height);

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.WordBreak;
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect, this.ForeColor, flags);

            if (this.Focused)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, this.ClientRectangle);
            }
        }

    }
}