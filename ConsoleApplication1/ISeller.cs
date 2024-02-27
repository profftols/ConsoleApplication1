using System;

namespace ConsoleApplication1
{
    public interface ISeller
    {
        void ChangeCountProduct(Product product, int count);
        bool TryFindProduct(Product product, int count);
    }
}