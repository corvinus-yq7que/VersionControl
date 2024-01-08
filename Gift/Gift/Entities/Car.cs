using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Entities
{
    internal class Car : Toy
    {
        protected override void DrawImage(Graphics g)
        {
            Image imageFile = Image.FromFile("https://bit.uni-corvinus.hu/irf/8_gyak_patterns/car.png");
            g.DrawImage(imageFile, new Rectangle(0, 0,Width,Height));
        }
    }
}
