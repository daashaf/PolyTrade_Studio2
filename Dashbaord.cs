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

        // Category buttons
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clothing section coming soon!", "PolyTrade");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stationary section coming soon!", "PolyTrade");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Footwear section coming soon!", "PolyTrade");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Snacks section coming soon!", "PolyTrade");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Logout → back to Login form
            MessageBox.Show("Logged out successfully", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
