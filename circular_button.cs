﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace resturant_project_final
{
    class circular_button:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath gr = new GraphicsPath();
            gr.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(gr);
            base.OnPaint(pevent);
        }

    }
}
