using System;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Dashbaord : Form   // ✅ fixed spelling
    {
        public Dashbaord()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clothing category1 = new Clothing();
            category1.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(
                "Logged out successfully",
                "Log Out",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void Dashbaord_Load(object sender, EventArgs e)
        {

        }
    }
}
