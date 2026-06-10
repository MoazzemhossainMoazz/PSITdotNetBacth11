using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200.00m, Category = "Electronics" },
                new Product { Name = "Smartphone", Price = 800.00m, Category = "Electronics" },
                new Product { Name = "Table", Price = 150.00m, Category = "Furniture" },
                new Product { Name = "Chair", Price = 80.00m, Category = "Furniture" },
                new Product { Name = "Headphones", Price = 200.00m, Category = "Electronics" }
            };

            var filteredProducts = products.Where(p => p.Category == "Electronics" && p.Price > 500);
            Console.WriteLine("Products in the 'Electronics' category with a price greater than $500:");

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}