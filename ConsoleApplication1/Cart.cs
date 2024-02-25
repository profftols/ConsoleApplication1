using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Cart : ISeller
    {
        private Dictionary<int, Product> _products;
        private Shop _shop;

        public Cart(Shop shop)
        {
            _shop = shop;
            _products = new Dictionary<int, Product>();
        }

        public void AddShopping(Product product, int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("the number cannot be negative or zero");
                return;
            }

            if (_shop.PutCart(product, count))
            {
                _products.Add(count, product);
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

            foreach (var product in _products)
            {
                Console.WriteLine($"Product in the cart: {product.Value.Name}, quantity: {product.Key}");
            }
        }

        public Shop Order()
        {
            _products = null;
            Console.WriteLine("Thank you for your order!");
            return _shop;
        }
    }
}