using System;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Dashbaord : Form
    {
        public Dashbaord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) { new Clothing().Show(); this.Hide(); }
        private void button2_Click(object sender, EventArgs e) { new Stationary().Show(); this.Hide(); }
        private void button3_Click(object sender, EventArgs e) { new footwear().Show(); this.Hide(); }
        private void button4_Click(object sender, EventArgs e) { new snacks().Show(); this.Hide(); }
    }
}
