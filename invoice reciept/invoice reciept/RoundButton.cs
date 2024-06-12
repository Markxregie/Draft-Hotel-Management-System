using System.Drawing;
using System.Drawing.Drawing2D;
using FontAwesome.Sharp;
using System.Windows.Forms;

namespace HOTELMANAGE.Customs
{
    public class RoundButton : IconButton
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
