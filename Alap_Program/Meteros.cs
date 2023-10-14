using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLapTest
{
    internal class Meteor
    {
        Random random = new Random();

        public Image metor {  get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public Meteor()
        {
            metor = Image.FromFile(@"asserts\\FallingMeteor.gif");
            PosX = random.Next(20, 500);
            PosY = random.Next(-10, 500);
        }
    }
}
