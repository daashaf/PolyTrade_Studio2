using System;
using System.IO;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Stationary : Form
    {
        readonly string cartPath = Path.Combine(Application.StartupPath, "cart.txt");

        public Stationary()
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

        private void button1_Click(object sender, EventArgs e) { SaveItemToFile("Pen Collection | $3"); }
        private void button2_Click(object sender, EventArgs e) { SaveItemToFile("Notebooks | $10"); }
        private void button3_Click(object sender, EventArgs e) { SaveItemToFile("Calculator | $5"); }
        private void button4_Click(object sender, EventArgs e) { SaveItemToFile("School Bag | $15"); }

        private void button5_Click(object sender, EventArgs e) { new Viren().Show(); this.Hide(); }
        private void button7_Click(object sender, EventArgs e) { new Dashbaord().Show(); this.Hide(); }
    }
}
