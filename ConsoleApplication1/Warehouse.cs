using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Warehouse : ISeller
    {
        private Dictionary<int, Product> _products;

        public Warehouse()
        {
            _products = new Dictionary<int, Product>();
        }

        public void Deliver(Product product, int count)
        {
            if (_products.ContainsValue(product))
            {
                foreach (var item in _products)
                {
                    if (item.Value == product)
                    {
                        count += item.Key;
                        _products.Remove(item.Key);
                        _products.Add(count, product);
                    }
                }
            }
            else
            {
                _products.Add(count, product);
            }
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

        public void ChangeCountProduct(Product product, int count)
        {
            foreach (var item in _products)
            {
                if (item.Value == product)
                {
                    if (item.Key - count == 0)
                    {
                        _products.Remove(item.Key);
                        return;
                    }

                    if (item.Key - count > 0)
                    {
                        _products.Remove(item.Key);
                        _products.Add(item.Key - count, product);
                        return;
                    }
                }
            }
        }

        public bool TryFindProduct(Product product, int count)
        {
            foreach (var item in _products)
            {
                if (item.Value == product && item.Key >= count)
                {
                    return true;
                }
            }

            return false;
        }
    }
}