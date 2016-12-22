using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLearn_ConsoleApplication_01
{
    class Product
    {
        readonly string name;
        public string Name
        {
            get { return name; }
        }
        readonly decimal price;
        public decimal Price
        {
            get { return price; }
        }
        readonly int supplierID;
        public int SupplierID
        {
            get { return supplierID; }
        }
        public Product(string name, decimal price,int supplierID)
        {
            this.name = name;
            this.price = price;
            this.supplierID = supplierID;
        }

        public static List<Product> GetSampleProduct()
        {
            //List<Product> list = new List<Product>();
            return new List<Product>
            {
                new Product(name: "West Side Story", price: 9.99m,supplierID :1),
                new Product(name: "Assassins", price: 14.99m,supplierID:2),
                new Product(name: "Frogs", price: 13.99m,supplierID:3),
                new Product(name: "Sweeney Todd", price: 10.99m,supplierID:4)
            };
        }
        
        public override string ToString()
        {
            return string.Format("{0}:{1}", name, price);
        }
    }
}
