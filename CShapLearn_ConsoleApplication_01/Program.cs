using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLearn_ConsoleApplication_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProduct();

            products.Sort(delegate (Product x, Product y)//匿名委托
            { return x.Name.CompareTo(y.Name); }
            );
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            Console.ReadKey();
            /////////////
        }
    }
}
