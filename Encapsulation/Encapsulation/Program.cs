using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "2020";
            car.Model = "A1";
            car.Price = 500000;
            Car car2 = new Car();
            car2.Make = "2021";
            car2.Model = "A2";
            car2.Price = 1000000;
            Console.WriteLine("First car information: ");
            Console.WriteLine($"Make:{car.Make}\t Model:{car.Model}\t Price:{car.Price}");
            Console.WriteLine("\nSecond car information: ");
            Console.WriteLine($"Make:{car2.Make}\t Model:{car2.Model}\t Price:{car2.Price}");

            Console.WriteLine("\nIf we compare those car price: ");
            
            if(car.Price == car2.Price)
            {
                Console.WriteLine("Both are same price.");
            }
            else if (car.Price > car2.Price)
            {
                Console.WriteLine("First car is more expensive than second car.");
            }
            else if(car.Price < car2.Price)
            {
                Console.WriteLine("Second car is more expensive than first car.");
            }

        }
    }
}
