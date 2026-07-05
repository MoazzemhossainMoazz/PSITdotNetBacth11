using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FunctionCalculator
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error:Division by zero is not allowed.");
                return 0;
            }
            return a / b;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Result:");
            Console.WriteLine("Addition: " + (num1, num2));
            Console.WriteLine("Subtraction: " + Subtract(num1, num2));
            Console.WriteLine("Multiplication: " + Multiply(num1, num2));
            Console.WriteLine("Division: " + Divide(num1, num2));
            Console.ReadLine();
        }
    }
}
