using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Cart
    {
        private List<Product> _products;
        private List<int> _count;
        private Shop _shop;

        public Cart(Shop shop)
        {
            _shop = shop;
            _products = new List<Product>();
            _count = new List<int>();
        }

        public void Add(Product name, int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("the number cannot be negative or zero");
                return;
            }

            if (_shop.PutCart(name, count))
            {
                _products.Add(name);
                _count.Add(count);
            }
            else
            {
                Console.WriteLine("There is no such quantity of goods.");
            }
        }

        public void ProductsShopping()
        {
            if (_products.Count <= 0)
            {
                Console.WriteLine("There are no products in the cart.");
                return;
            }

            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"Product in the shopping cart: {_products[i].Name}, {_count[i]}");
            }
        }

        public Shop Order()
        {
            _products = null;
            _count = null;

            return _shop;
        }
    }
}