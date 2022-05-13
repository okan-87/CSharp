using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 10;
            product1.ProductName = "Table";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 20,
                UnitPrice = 35,
                ProductName = "Pencil",
                UnitInStock = 35
            };

            ProductManager productmanager = new ProductManager();
            productmanager.Add(product1);
            productmanager.Add(product2);
        }
    }
}
