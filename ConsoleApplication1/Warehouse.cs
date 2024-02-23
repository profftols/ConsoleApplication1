using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Warehouse
    {
        private List<Product> _products;
        private List<int> _count;

        public Warehouse()
        {
            _products = new List<Product>();
            _count = new List<int>();
        }

        public void Deliver(Product name, int count)
        {
            _products.Add(name);
            _count.Add(count);
        }

        public void GetAllProducts()
        {
            if (_products.Count <= 0)
            {
                Console.WriteLine("There are no products in the warehouse.");
                return;
            }
            
            for (int i = 0; i < _products.Count; i++)
            {
                Console.WriteLine($"{_products[i].Name}, {_count[i]}");
            }
        }

        public bool TakeProduct(Product name, int count)
        {
            int buffer;
            
            for (int i = 0; i < _products.Count; i++)
            {
                if (_products[i].Name == name.Name)
                {
                    buffer = _count[i];
                    _count[i] -= count;
                    
                    if (_count[i] <= 0)
                    {
                        _count[i] = buffer;
                        return false;
                    }
                    
                    return true;
                }
            }

            return false;
        }
    }
}