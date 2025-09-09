using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class snacks : Form
    {
        public snacks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added to cart!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added to cart!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added to cart!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added to cart!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashbaord dashboard = new Dashbaord();
            dashboard.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successsfully", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
