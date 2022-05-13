using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added : " + product.ProductName);
        }
        public void Updated(Product product)
        {
            Console.WriteLine("Updated : " + product.ProductName);
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Deleted : " + product.ProductName);
        }
    }
}
