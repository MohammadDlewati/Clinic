using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Clinic
{
    class RoundButton:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);            
            this.Region = new System.Drawing.Region(p);
            base.OnPaint(pevent);
        }
    }
}
