using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a width: ");
            string widthInput = Console.ReadLine();

            Console.Write("Enter a height: ");
            string heightInput = Console.ReadLine();


            double width = Convert.ToDouble(widthInput);
            double height = Convert.ToDouble(heightInput);

            double area = 0.5 * width * height;
            Console.WriteLine("The area of a triangle is: " + area);

        }
    }
}