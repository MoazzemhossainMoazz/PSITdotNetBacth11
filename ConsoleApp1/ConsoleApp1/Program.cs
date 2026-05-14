using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a length: ");
            string lengthInput = Console.ReadLine();
            Console.Write("Enter a width: ");
            string widthInput = Console.ReadLine();
            Console.Write("Enter a height: ");
            string heightInput = Console.ReadLine();

            double length = Convert.ToDouble(lengthInput);
            double width = Convert.ToDouble(widthInput);
            double height = Convert.ToDouble(heightInput);

            double volume = length * width * height;
            Console.WriteLine("The volume of the box is: " + volume);
            
        }
    }
}