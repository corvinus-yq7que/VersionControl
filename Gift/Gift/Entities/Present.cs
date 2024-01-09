using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Entities
{
    internal class Present : Toy
    {
        public SolidBrush PresentColor { get; private set; }
        public Present(Color present) 
        {
            PresentColor = new SolidBrush(present);
        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle();
        }
    }
}
