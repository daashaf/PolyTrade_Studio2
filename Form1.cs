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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clothing category1 = new Clothing();
            category1.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully", "Log Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stationary category2 = new Stationary();
            category2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            footwear category3 = new footwear();
            category3.Show();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            snacks category4 = new snacks();
            category4.Show();   
        }
    }
}
