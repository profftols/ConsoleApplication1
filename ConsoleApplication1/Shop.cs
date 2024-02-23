namespace ConsoleApplication1
{
    public class Shop
    {
        public string Paylink { get; private set; } = "Thank you for your order!";
        
        private Warehouse _warehouse;
        
        public Shop(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public Cart Cart()
        {
            return new Cart(this);
        }

        public bool PutCart(Product name, int count)
        {
           return _warehouse.TakeProduct(name, count);
        }
    }
}