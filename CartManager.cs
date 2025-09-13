using System;
using System.IO;
using System.Windows.Forms;

namespace PolyTrade_WebApp
{
    public static class CartManager
    {
        private static string filePath = "Cart.txt"; // Stored in bin/Debug folder

        // Save item to text file
        public static void AddToCart(string itemName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, true)) // append mode
                {
                    sw.WriteLine(itemName);
                }

                MessageBox.Show("Item saved to cart successfully!",
                    "Add To Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving item: " + ex.Message);
            }
        }

        // Load cart items into a ListBox
        public static void LoadCart(ListBox listBox)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    listBox.Items.Clear();
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            listBox.Items.Add(line);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cart is empty.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cart: " + ex.Message);
            }
        }
    }
}
