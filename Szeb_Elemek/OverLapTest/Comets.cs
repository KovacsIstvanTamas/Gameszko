using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLapTest
{
    internal class Comets
    {
        Random random = new Random();

        public Image comet { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Comets()
        {
            comet = Image.FromFile(@"asserts\\Comet.gif");
            PosX = random.Next(20, 500);
            PosY = random.Next(-10, 500);
        }
    }
}
