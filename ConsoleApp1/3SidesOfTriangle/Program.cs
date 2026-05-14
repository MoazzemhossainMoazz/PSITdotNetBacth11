using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter 1st side: ");
            string 1stSideInput = Console.ReadLine();

            Console.Write("Enter 2nd side: ");
            string 2ndSideInput = Console.ReadLine();

            Console.Write("Enter 3rd side: ");
            string 3rdSideInput = Console.ReadLine();


            double width = Convert.ToDouble(widthInput);
            double height = Convert.ToDouble(heightInput);

            double area = 0.5 * width * height;
            Console.WriteLine("The area of a triangle is: " + area);

        }
    }
}