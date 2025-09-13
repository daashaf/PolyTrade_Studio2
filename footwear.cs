using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PolyTrade_WebApp
{
    public partial class footwear : Form
    {
        readonly string cartPath = Path.Combine(Application.StartupPath, "cart.txt");
        public footwear()
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

        private void button1_Click(object sender, EventArgs e) { SaveItemToFile("Air Jordans | $80"); }
        private void button2_Click(object sender, EventArgs e) { SaveItemToFile("Women Heels | $40"); }
        private void button3_Click(object sender, EventArgs e) { SaveItemToFile("Women Shoes | $50"); }
        private void button4_Click(object sender, EventArgs e) { SaveItemToFile("New Balances | $90"); }

        private void button5_Click(object sender, EventArgs e) { new Viren().Show(); this.Hide(); }
        private void button7_Click(object sender, EventArgs e) { new Dashbaord().Show(); this.Hide(); }
    }
}