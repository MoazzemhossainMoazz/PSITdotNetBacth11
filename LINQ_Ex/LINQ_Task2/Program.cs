using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Stock = 10 },
                new Product { Name = "Smartphone", Stock = 5 },
                new Product { Name = "Table", Stock = 0 },
                new Product { Name = "Chair", Stock = 15 },
                new Product { Name = "Headphones", Stock = 0 }
            };
            var outOfStockProducts = products.Where(p => p.Stock == 0).Select(p => p.Name);

            Console.WriteLine("Out of stock products:");

            foreach (var name in outOfStockProducts)
            {
                Console.WriteLine(name);
            }
        }
    }
}