namespace ConsoleApplication1
{
    public class Shop
    {
        private Warehouse _warehouse;
        
        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public Cart Cart()
        {
            return new Cart(this);
        }

        public bool PutCart(Product product, int count)
        {
           return _warehouse.TakeProduct(product, count);
        }
    }
}