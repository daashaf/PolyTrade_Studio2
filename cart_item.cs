using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTrade_WebApp
{
    
    /// Represents a single item in the shopping cart.
    /// Holds the item name and its price.
    /// </summary>
    public class cart_item
    {
        
        /// Name of the item (e.g., "T-shirt", "Charger").
        /// </summary>
        public string Name { get; set; }

        
        /// Price of the item (in whole numbers, e.g., 10 means $10).
        
        public int Price { get; set; }

        
        /// Constructor to create a new cart item with a name and price.
        
        /// <param name="name">The name of the product.</param>
        /// <param name="price">The price of the product.</param>
        public cart_item(string name, int price)
        {
            Name = name;   // Set the item name
            Price = price; // Set the item price
        }

       
        /// Overrides ToString() to display item information
        /// in the format: "Name - $Price".
        /// This is what will be shown in the ListBox.
       
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}
