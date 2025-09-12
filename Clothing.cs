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
    public partial class Clothing : Form
    {
        public Clothing()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully added to cart!", "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dashbaord back = new Dashbaord();
            back.Show();

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

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Logged out", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Viren cart = new Viren();
            cart.Show();
        }
    }
}
