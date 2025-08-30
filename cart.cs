using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

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

        public int GetTotal()
        {
            return items.Sum(i => i.Price);
        }
    }
}
