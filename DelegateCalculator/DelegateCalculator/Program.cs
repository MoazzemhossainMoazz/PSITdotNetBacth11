using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    class Program
    {
        delegate double Calculator(double a, double b);

            static double Add(double a, double b)
            {
                return a + b;
            }
            static double Sub(double a, double b)
            {
                return a - b;
            }
            static double Mult(double a, double b)
            {
                return a * b;
            }
            static double Div(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                return a / b;
            }

            static void Main(string[] args)
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Calculator add = Add;
                Calculator sub = Sub;
                Calculator mult = Mult;
                Calculator div = Div;


                Console.WriteLine("\nResults: ");
                Console.WriteLine($"Addition: {add(num1, num2)}");
                Console.WriteLine($"Subtraction: {sub(num1, num2)}");
                Console.WriteLine($"Multiplication: {mult(num1, num2)}");
                Console.WriteLine($"Division: {div(num1, num2)}");


            }
        
    }
}