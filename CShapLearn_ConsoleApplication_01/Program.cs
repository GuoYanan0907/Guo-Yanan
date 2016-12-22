using CShapLearn_ConsoleApplication_01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CShapLearn_ConsoleApplication_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Product> products = Product.GetSampleProduct();
            //List<Supplier> supliers = Supplier.GetSampleSupplier();
            //var filtered = from p in products
            //               join s in supliers
            //               on p.SupplierID equals s.SupplierID
            //               where p.Price > 10
            //               orderby s.Name, p.Name
            //               select new { SupplierName = s.Name, ProductName = p.Name };
            //foreach (var v in filtered)
            //{
            //    Console.WriteLine("Supplier = {0};Product={1}",
            //        v.SupplierName, v.ProductName);
            //}

            //LINQ操作XML
            XDocument doc = XDocument.Load("C:/Users/yn_09/Source/Repos/Guo-Yanan2/CShapLearn_ConsoleApplication_01/data.xml");
            var filtered = from p in doc.Descendants("Product")
                           join s in doc.Descendants("Supplier")
                           on (int)p.Attribute("SupplierID")
                           equals (int)s.Attribute("SupplierID")
                           where (decimal)p.Attribute("Price") > 10
                           orderby (string)s.Attribute("Name"),
                                   (string)p.Attribute("Name")
                           select new
                           {
                               SupplierName = (string)s.Attribute("Name"),
                               ProductName = (string)p.Attribute("Name")
                           };
            foreach (var v in filtered)
            {
                Console.WriteLine("Supplier = {0};Product = {1}", v.SupplierName, v.ProductName);
            }
                 
            //products.Sort(delegate (Product x, Product y)//匿名委托
            //{ return x.Name.CompareTo(y.Name); }
            //);
            //foreach (Product product in products)
            //{
            //    Console.WriteLine(product);
            //}
            Console.ReadKey();
            /////////////
        }
    }
}
