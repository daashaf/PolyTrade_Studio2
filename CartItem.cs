namespace PolyTrade_WebApp
{
    public class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public CartItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - ${Price:0.00}";
        }
    }
}
