using System;
using System.Collections.Generic;
using System.Linq;

namespace PolyTrade_WebApp
{
    internal class cart
    {
        private List<cart_item> items;

        public cart()
        {
            items = new List<cart_item>();
        }

        public void AddItem(cart_item item)
        {
            items.Add(item);
        }

        public void RemoveItem(cart_item item)
        {
            items.Remove(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public List<cart_item> GetItems()
        {
            return items;
        }

        /// <summary>
        /// Calculates the total cost of items in the cart.
        /// Uses decimal instead of int (for cents support).
        /// </summary>
        public decimal GetTotal()
        {
            return items.Sum(i => i.Price);
        }
    }
}
