namespace ConsoleApplication1
{
    public class Product
    {
        public string Name { get; private set; }
        
        public Product(string name)
        {
            Name = name;
        }
    }
}