using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> name = new List<string>();
            name.Add("Sakib");
            name.Add("Tamim");
            name.Add("Mushfiq");
            name.AddRange(new List<string>
            {
                "Riyad",
                "Robel",
                "Taskin"
            });

            foreach (var item in name)
            {
                Console.WriteLine(item);
            }


            name.Insert(2, "Rakib");
            Console.WriteLine("After inserting Rakib at index 2: ");
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }


            //name.Sort();
            //Console.WriteLine("After organize in ascending order: ");
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            //name.Reverse();
            //Console.WriteLine("After organize in descending order: ");
            //foreach (var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Enter a name for search or add: ");
            //string searchName = Console.ReadLine();
            //if (name.Contains(searchName))
            //{
            //    Console.WriteLine(name.IndexOf(searchName));
            //}
            //else
            //{
            //    name.Add(searchName);
            //    Console.WriteLine($"{searchName} is added to the list.");
            //}

            //foreach(var item in name)
            //{
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Remove a name: ");
            //string removeName = Console.ReadLine();
            //name.Remove(removeName);
            //foreach(var item in name)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("Names that start with R: ");
            name.Where(x => x.StartsWith("R")).ToList().ForEach(x => Console.WriteLine(x));

            name.Where(x => x.ToLower().Equals("sakib")).ToList().ForEach(x => Console.WriteLine($"Name is: {x}"));
            var result = name.Where(x => x.ToLower().EndsWith("b")) .ToList();

            if(result.Count() > 0)
            {
                result.ForEach(x => Console.WriteLine($"End with b: {x}"));
            }
            else
            {
                Console.WriteLine("Sorry! No name found that end with b");
            }
        }
    }
}