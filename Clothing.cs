using System;
using System.IO;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Clothing : Form
    {
        readonly string cartPath = Path.Combine(Application.StartupPath, "cart.txt");

        public Clothing()
        {
            InitializeComponent();
        }

        private void SaveItemToFile(string item)
        {
            using (StreamWriter sw = new StreamWriter(cartPath, true))
                sw.WriteLine(item);

            MessageBox.Show(item + " has been added to your cart!",
                "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e) { SaveItemToFile("Men Hoodie | $20"); }
        private void button2_Click(object sender, EventArgs e) { SaveItemToFile("Men Pants | $20"); }
        private void button3_Click(object sender, EventArgs e) { SaveItemToFile("Women Shirt | $10"); }
        private void button4_Click(object sender, EventArgs e) { SaveItemToFile("Women Jeans | $20"); }

        private void button6_Click(object sender, EventArgs e) { new Viren().Show(); this.Hide(); }
        private void button7_Click(object sender, EventArgs e) { new Dashbaord().Show(); this.Hide(); }
    }
}
