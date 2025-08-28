using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTrade_WebApp
{
    internal class product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            // This will display nicely in ListBox
            return $"{Name}   ${Price}";
        }
    }
}
