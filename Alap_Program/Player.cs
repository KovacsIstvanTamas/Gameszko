using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLapTest
{
    internal class Player
    {
        Random random = new Random();

        public Image playerIMG { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int HP { get; set; }
        public Player()
        {
            playerIMG = Image.FromFile(@"asserts\\player.png");
            PosX = 300;
            PosY = 500;
            HP = 3;
        }
    }
}
