using System;
using System.Collections;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Stackl
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("PS");
            stack.Push(2);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total items: {stack.Count}");

            stack.Pop();
            Console.WriteLine("\n--------Pop------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total items: {stack.Count}");


            Console.WriteLine("\n-----Peek-----");
            var peekvalu = stack.Peek();
            Console.WriteLine(peekvalu);

            Console.WriteLine(stack.Contains("PS"));
            Console.WriteLine(stack.Contains(5));

            bool isExist = stack.Contains("6");
            if (!isExist)
            {
                stack.Push("P");
            }
            else
            {
                Console.WriteLine("Already Exist");
            }
            Console.WriteLine("\nAfter Contains");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total items: {stack.Count}");

            stack.Clear();
            Console.WriteLine($"Total items: {stack.Count}");

        }
    }
}
