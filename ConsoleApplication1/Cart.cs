using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Cart
    {
        private readonly Dictionary<int, Product> _products;
        private readonly Item _item;
        private readonly ISeller _seller;

        public Cart(ISeller seller)
        {
            _products = new Dictionary<int, Product>();
            _seller = seller;
            _item = new Item();
        }

        public void AddShopping(Product product, int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("the number cannot be negative or zero");
                return;
            }

            if (_seller.TryFindProduct(product, count))
            {
                _products.Add(count, product);
            }
            else
            {
                Console.WriteLine("There are no products in the warehouse");
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

        public Item Order()
        {
            foreach (var product in _products)
            {
                _seller.ChangeCountProduct(product.Value, product.Key);
            }
            
            _products.Clear();
            return _item;
        }
    }
}