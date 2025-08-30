using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTrade_WebApp
{
    public class cart_item
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public cart_item(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
    }
}
