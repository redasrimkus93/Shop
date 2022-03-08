using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model
{
    internal class ShoppingBag
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public double FinalPrice
        {
            get
            {
                double price = 0;
                foreach (var item in Products)
                {
                    price = price + item.Price;
                }
                return price;
            }
        }
    }
}
