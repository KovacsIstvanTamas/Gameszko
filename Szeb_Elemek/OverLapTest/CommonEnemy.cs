using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLapTest
{
    internal class CommonEnemy
    {
        Random random = new Random();

        public Image ComEnemy { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public CommonEnemy(int Xpos)
        {
            ComEnemy = Image.FromFile(@"asserts\\E1.gif");
            if (Xpos > 500)
            {
                PosX = (Xpos - 500);
            }
            else 
            {
                PosX = Xpos;
            }
            
            PosY = -30;
        }
    }
}
