using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Warehouse
    {
        private Dictionary<int, Product> _products;

        public Warehouse()
        {
            _products = new Dictionary<int, Product>();
        }

        public void Deliver(Product product, int count)
        {
            _products.Add(count, product);
        }

        public void PrintDeliverProducts()
        {
            if (_products.Count <= 0)
            {
                Console.WriteLine("There are no products in the warehouse.");
                return;
            }

            foreach (var product in _products)
            {
                Console.WriteLine($"Product in the warehouse: {product.Value.Name}, quantity: {product.Key}");
            }
        }

        public bool TakeProduct(Product product, int count)
        {
            foreach (var item in _products)
            {
                if (item.Value == product)
                {
                    return ChangeCountProduct(count, item.Key);
                }
            }

            return false;
        }

        private bool ChangeCountProduct(int count, int productKey)
        {
            if (productKey-count == 0)
            {
                _products.Remove(productKey);
                return true;
            }
            
            if (productKey-count > 0)
            {
                _products.TryGetValue(productKey, out Product product);
                _products.Remove(productKey);
                _products.Add(productKey - count, product);
                return true;
            }

            return false;
        }
    }
}