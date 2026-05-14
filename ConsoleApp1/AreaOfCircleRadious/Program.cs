using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a radious: ");
            string radiousInput = Console.ReadLine();
            

            double radious = Convert.ToDouble(radiousInput);

            double area = 3.1416 * radious * radious;
            Console.WriteLine("The area of a circle is: " + area);

        }
    }
}