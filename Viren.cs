using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Viren : Form
    {
        private cart cart;
        private readonly string filePath = @"C:\Users\daash\Downloads\dashboard.txt";  // ✅ updated path

        public Viren()
        {
            InitializeComponent();
            cart = new cart();

            LoadItemsFromFile();   // ✅ Load items from dashboard.txt
            UpdateUI();
        }

        // 🔹 Load items from text file
        private void LoadItemsFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Skip empty lines or category headers (starting with #)
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                        continue;

                    string[] parts = line.Split(',');

                    if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal price))
                    {
                        cart.AddItem(new cart_item(parts[0].Trim(), price));
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Item file not found:\n" + filePath,
                    "File Missing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // 🔹 Refresh UI
        private void UpdateUI()
        {
            listBox1.Items.Clear();

            foreach (var item in cart.GetItems())
                listBox1.Items.Add(item.ToString());

            textBox2.Text = "$" + cart.GetTotal().ToString("0.00");
        }

        // 🔹 Remove selected item
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                var selected = cart.GetItems()[listBox1.SelectedIndex];
                cart.RemoveItem(selected);
                UpdateUI();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Please select an item to remove.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // 🔹 Clear all items
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                "Are you sure you want to remove all items?",
                "Confirm Remove",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                cart.Clear();
                UpdateUI();
            }
        }

        // 🔹 Checkout → open Checkout form
        private void Cart_Click(object sender, EventArgs e)
        {
            if (cart.GetItems().Count > 0)
            {
                // Pass the cart items to Checkout
                Checkout checkoutForm = new Checkout(cart.GetItems());
                checkoutForm.Show();
                this.Hide();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Please select items before checkout.",
                    "No Items Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }




        // 🔹 Draw blue separator line
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.MidnightBlue, 2))
            {
                int y = 280;
                e.Graphics.DrawLine(pen, 10, y, panel1.Width - 10, y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashbaord dash = new Dashbaord();
            dash.Show();
            this.Hide();
        }
    }
}
