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
        public decimal Price { get; set; }
        public string Notes { get; set; }   // e.g., "Size: M"
    }
}
