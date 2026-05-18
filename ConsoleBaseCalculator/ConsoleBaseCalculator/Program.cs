using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Console.Write("Enter an integer value: ");
            int input = int.Parse(Console.ReadLine());

            Console.Write("Enter an Operator [Subtract -, Add +, Multiply *, Divide /]: ");
            string op = Console.ReadLine();
            Console.Write("Enter another integer value: ");
            int input2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    result = input + input2;
                    Console.WriteLine($"{input} plus {input2} equals {result}");
                    break;

                case "-":
                    result = input - input2;
                    Console.WriteLine($"{input} minus {input2} equals {result}");
                    break;

                case "*":
                    result = input * input2;
                    Console.WriteLine($"{input} multiplied {input2} equals {result}");
                    break;

                case "/":
                    result = input / input2;
                    Console.WriteLine($"{input} divided {input2} equals {result}");
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }
        }
    }
}
