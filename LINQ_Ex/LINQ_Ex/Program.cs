using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new[]
            {
                    new { CustomerID = 1, FirstName = "John", LastName = "Doe", CompanyName = "Alpha group" },
                    new { CustomerID = 2, FirstName = "Jane", LastName = "Smith", CompanyName = "Beta group" },
                    new { CustomerID = 3, FirstName = "Michael", LastName = "Johnson", CompanyName = "Alpha group" },
                    new { CustomerID = 4, FirstName = "Emily", LastName = "Davis", CompanyName = "Gamma group" },
                    new { CustomerID = 5, FirstName = "David", LastName = "Wilson", CompanyName = "Beta group" },
                    new { CustomerID = 6, FirstName = "Sarah", LastName = "Miller", CompanyName = "Alpha group" },
                };

            var result = from c in customers
                         group c by c.CompanyName into g
                         select new { CompanyName = g.Key, Customers = g };
            Console.WriteLine("------------Company Name-------------");
            foreach(var item in result)
            {
                Console.Write(item.CompanyName + "\t");
            }

            Console.WriteLine("\n------------Employee List-------------");
            result.ToList().ForEach(x =>
            {
                Console.WriteLine(x.CompanyName);
                x.Customers.ToList().ForEach(c =>
                {
                    Console.WriteLine("\t {0} {1}", c.FirstName, c.LastName); 
                }); 
                Console.WriteLine("------------------------------------");
            });
            var output = customers.Where(c => c.FirstName.Equals("David"));
            Console.WriteLine("FirstName \t \t item.LastName \t\t item.CompanyName");
            foreach (var item in output)
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2}", item.FirstName, item.LastName, item.CompanyName);
            }
            Console.WriteLine("----------------Ony first item------------------");
            var cust = customers.Where(c => c.FirstName.Equals("David")).SingleOrDefault();
            Console.WriteLine("FirstName \t\t item.LastName \t\t item.CompanyName");

            Console.WriteLine("{0} \t\t {1} \t\t {2}", cust.FirstName, cust.LastName, cust.CompanyName);
            string query = "A";

            output = customers.Where(c => c.FirstName.ToLower().Contains(query.ToLower()));
            Console.WriteLine("FirstName\t\t item.LastName \t\t item.CompanyName");

            foreach (var item in output)
            {
                Console.WriteLine("{0}\t\t {1}\t\t {2}", item.FirstName, item.LastName, item.CompanyName);
            }
            Console.WriteLine("----------After sorting----------");
            var sorted = customers.OrderBy(c => c.FirstName).ToList();
            sorted.ForEach (x => Console.WriteLine(x.FirstName + "\t" + x.LastName));

            var cnt = customers.Count();
            Console.WriteLine($"Total customer{cnt}");
            var data = customers.Select(s => new { name = s.FirstName + " " + s.LastName, Company = s.CompanyName });
            Console.WriteLine("------------------------------------");
            foreach (var item in data)
            {
                Console.WriteLine("{0}\t\t{1}", item.name, item.Company);
            }
            Console.WriteLine("---------------2 record----------------");
            var take = customers.Take(2).Select(s => new { name = s.FirstName + " " + s.LastName, Company = s.CompanyName });
            Console.WriteLine("Name\t\tCompanyname");
            Console.WriteLine("--------------------------------------");
            foreach (var item in take)
            {
                Console.WriteLine("{0} \t\t {1}", item.name, item.Company);
            }
            Console.WriteLine("---------------------skip 2 record--------------");
            var skipex = customers.Skip(2).Take(2).Select(s => new { name = s.FirstName + " " + s.LastName, Company = s.CompanyName });
            Console.WriteLine("Name\t\t CompanyName");
            Console.WriteLine("------------------------------------------------");
            foreach (var item in skipex)
            {
                Console.WriteLine("{0} \t\t {1}", item.name, item.Company);
            }
        }
    }
}
