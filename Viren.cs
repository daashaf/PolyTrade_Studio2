using System;
using System.IO; // added for file reading/writing
using System.Linq; // added for summing prices
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Viren : Form
    {
        // 🔹 file path for the cart
        readonly string cartPath = Path.Combine(Application.StartupPath, "cart.txt");

        public Viren()
        {
            InitializeComponent();
            this.Load += Viren_Load; // make sure load event runs
        }

        // 🔹 Load items into listBox1 from text file + update total
        private void Viren_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decimal total = 0;

            if (File.Exists(cartPath))
            {
                var lines = File.ReadAllLines(cartPath);
                listBox1.Items.AddRange(lines);

                // calculate total based on prices in lines
                foreach (var line in lines)
                {
                    // expects format like "Mens Hoodie | $20"
                    var parts = line.Split('$');
                    if (parts.Length > 1 && decimal.TryParse(parts[1], out decimal price))
                    {
                        total += price;
                    }
                }
            }

            textBox2.Text = total.ToString("C"); // show as currency
        }

        // 🔹 Checkout button (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Checkout successful! Thank you for your order.",
                "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // clear after checkout
            File.WriteAllText(cartPath, string.Empty);
            listBox1.Items.Clear();
            textBox2.Text = "$0.00";
        }

        // 🔹 Remove Order button (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // remove selected item from ListBox
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // update file with remaining items
                using (StreamWriter sw = new StreamWriter(cartPath, false))
                {
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                // recalculate total
                decimal total = 0;
                foreach (var item in listBox1.Items)
                {
                    var parts = item.ToString().Split('$');
                    if (parts.Length > 1 && decimal.TryParse(parts[1], out decimal price))
                    {
                        total += price;
                    }
                }

                textBox2.Text = total.ToString("C");

                MessageBox.Show("Item removed from cart.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
