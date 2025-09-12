using System;

namespace PolyTrade_WebApp
{
    /// <summary>
    /// Represents a single item in the shopping cart.
    /// Holds the item name and its price.
    /// </summary>
    public class cart_item
    {
        /// <summary>
        /// Name of the item (e.g., "T-shirt", "Charger").
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Price of the item (can include cents, e.g., 10.50 means $10.50).
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Constructor to create a new cart item with a name and price.
        /// </summary>
        /// <param name="name">The name of the product.</param>
        /// <param name="price">The price of the product.</param>
        public cart_item(string name, decimal price)
        {
            Name = name;   // Set the item name
            Price = price; // Set the item price
        }

        /// <summary>
        /// Overrides ToString() to display item information
        /// in the format: "Name - $Price".
        /// This is what will be shown in the ListBox.
        /// </summary>
        public override string ToString()
        {
            return $"{Name} - ${Price:0.00}";
        }
    }
}
