using System;

namespace ConsoleApplication1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Product iPhone12 = new Product("iPhone 12");
            Product iPhone11 = new Product("iPhone 11");

            Warehouse warehouse = new Warehouse();
            Shop shop = new Shop(warehouse);
            
            warehouse.Deliver(iPhone12, 10);
            warehouse.Deliver(iPhone11, 1);
            
            warehouse.PrintDeliverProducts();

            Cart cart = shop.Cart();
            
            cart.AddShopping(iPhone12, 4);
            cart.AddShopping(iPhone11, 3);
            
            cart.ProductsShopping();

            cart.Order();

            cart.AddShopping(iPhone12, 9);
        }
    }
}