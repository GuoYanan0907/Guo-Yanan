using System.Collections;
using System.Collections.Generic;
namespace CShapLearn_ConsoleApplication_01
{
    class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product  x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
