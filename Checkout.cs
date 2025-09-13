using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public partial class Checkout : Form
    {
        private List<cart_item> checkoutItems;

        public Checkout(List<cart_item> items)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // ✅ center form
            this.WindowState = FormWindowState.Maximized;        // ✅ maximize on open
            checkoutItems = new List<cart_item>(items);
        }


        private void Checkout_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            decimal total = 0;

            // Add header
            listBox1.Items.Add(string.Format("{0,-25} {1,10}", "Item", "Price"));
            listBox1.Items.Add(new string('-', 40));

            // Add items
            foreach (var item in checkoutItems)
            {
                listBox1.Items.Add(string.Format("{0,-25} ${1,8:0.00}", item.Name, item.Price));
                total += item.Price;
            }

            // ✅ Show total in label2
            label2.Text = $"Total: ${total:0.00}";
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(
                "Hi!\nYou can pay the front desk and collect your item.\nMake sure to show your identity!\n\nThank you for shopping with us!",
                "Order Placed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Dashbaord dash = new Dashbaord();
            dash.Show();
            this.Hide();
        }
    }
}
