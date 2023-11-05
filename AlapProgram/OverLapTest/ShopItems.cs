using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OverLapTest
{
    internal class ShopItems
    {
        public Image ShopButton { get; set; }

        public ShopItems() 
        {
            ShopButton = Image.FromFile(@"asserts\\ShopButton.png");
        }

    }
}
