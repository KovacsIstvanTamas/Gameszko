using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverLapTest
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pages.SelectTab(((Control)sender).Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pages.SelectTab(((Control)sender).Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pages.SelectTab(((Control)sender).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pages.SelectTab(((Control)sender).Text);
        }
    }
}
