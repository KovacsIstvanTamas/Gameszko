using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLapTest
{
    internal class Bullet
    {
        public Image BulletIMG { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Bullet() 
        {
            BulletIMG = Image.FromFile(@"asserts\\ammo1.png");

		}

    }
}
