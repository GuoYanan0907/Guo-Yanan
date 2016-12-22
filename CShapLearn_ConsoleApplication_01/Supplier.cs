using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapLearn_ConsoleApplication_01
{
    class Supplier
    {
        readonly string name;
        public string Name
        {
            get { return name; }
        }
        readonly int supplierID;
        public int SupplierID
        {
            get { return supplierID; }
        }
        public Supplier(string name, int supplierID)
        {
            this.supplierID = supplierID;
        }
        public static List<Supplier> GetSampleSupplier()
        {
            return new List<Supplier>
            {
                new Supplier(name:"a",supplierID:1),
                new Supplier(name:"b",supplierID:2),
                new Supplier(name:"c",supplierID:3),
                new Supplier(name:"d",supplierID:4)

            };
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}", name, supplierID);
        }
    }
}
