namespace ConsoleApplication1
{
    public class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        
        public string Name { get; private set; }
        
    }
}