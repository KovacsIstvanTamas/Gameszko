using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class ShopItem : UserControl
    {
        public ShopItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return pictureBox1.Image;
            }

            set
            {
                pictureBox1.Image = value;
            }
        }

        public string ItemLabel
        {
            get
            {
                return itemName.Text;
            }
            set
            {
                itemName.Text = value;
            }

        }

        public string ItemPrice
        {
            get
            {
                return itemPrice.Text;
            }
            set
            {
                itemPrice.Text = value;
            }
        }

        private void itemName_Click(object sender, EventArgs e)
        {

        }
    }
}
