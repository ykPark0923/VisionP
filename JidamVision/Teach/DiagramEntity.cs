﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JidamVision.Teach
{
    internal class DiagramEntity
    {
        public InspWindow LinkedWindow { get; set; }
        public Rectangle EntityROI { get; set; }
        public Color EntityColor { get; set; }
        public bool IsHold {  get; set; }
        public RectangleF ImageBasedROI { get; set; }

        public DiagramEntity()
        {
            LinkedWindow = null;
            EntityROI = new Rectangle(0, 0, 0, 0);
            ImageBasedROI = new Rectangle(0, 0, 0, 0);
            EntityColor = Color.White;
            IsHold = false;
        }

        public DiagramEntity(Rectangle screenRect, RectangleF imageRect, Color entityColor, bool hold = false)
        {
            LinkedWindow = null;
            EntityROI = screenRect;
            ImageBasedROI = imageRect;
            EntityColor = entityColor;
            IsHold = hold;
        }
    }
}
