using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PolyTrade_WebApp
{
    public partial class Viren : Form
    {
         Graphics Graphics;
        private cart cart;

        public Viren()
        {
            InitializeComponent();
            Graphics = CreateGraphics();
            cart = new cart();

            // Add some  items
            cart.AddItem(new cart_item("T-shirt", 10)); 
            cart.AddItem(new cart_item("Charger", 6));
            cart.AddItem(new cart_item("Fries", 3));
            cart.AddItem(new cart_item("Book", 2));
            cart.AddItem(new cart_item("Pencil", 6));

            UpdateUI();


        }
        private void UpdateUI()
        {
            listBox1.Items.Clear();
            foreach (var item in cart.GetItems())
                listBox1.Items.Add(item.ToString());

            textBox2.Text = "$" + cart.GetTotal().ToString();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            // Remove selected item (not all)
            if (listBox1.SelectedIndex >= 0)
            {
                var selected = cart.GetItems()[listBox1.SelectedIndex];
                cart.RemoveItem(selected);
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cart.GetItems().Count > 0)
            {
                MessageBox.Show("Your order has been confirmed!", "Order Confirmed",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cart.Clear();
                UpdateUI();
            }
            else
            {
                MessageBox.Show("Please select items before checkout.", "No Items Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = Properties.Resources.;
           // pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Are you sure you want to remove all items?",
         "Confirm Remove",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear all items from ListBox
                listBox1.Items.Clear();

                // Reset total TextBox
                textBox2.Text = "$0.00";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                // If there are items in the list, confirm the order
                MessageBox.Show(
                    "Your order has been confirmed!",
                    "Order Confirmed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // If no items, ask the user to select items
                MessageBox.Show(
                    "Please select items before checkout.",
                    "No Items Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.MidnightBlue, 2)) // Blue line, 3px thick
            {
                // Draw a horizontal line across the panel
                int y = 280; // Adjust this to match where your blue line is
                e.Graphics.DrawLine(pen, 10, y, panel2.Width - 10, y);
            }
        }
    }
}
