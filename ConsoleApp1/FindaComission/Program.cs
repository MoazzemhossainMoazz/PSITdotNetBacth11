using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int saleAmount = 0;
            Console.WriteLine("Enter sales amound: ");
            saleAmount = int.Parse(Console.ReadLine());
            String answer = "";
            do
            {
                if (saleAmount <= 1000)
                {
                    Console.WriteLine("Comission amount 1%");
                }

                else if (saleAmount > 1000 && saleAmount <= 2000)
                {
                    Console.WriteLine("Comission amount 2%");
                }
                else if (saleAmount > 2000 && saleAmount <= 3000)
                {
                    Console.WriteLine("Comission amount 3%");
                }
                else if (saleAmount > 3000 && saleAmount <= 4000)
                {
                    Console.WriteLine("Comission amount 4%");
                }
                else if (saleAmount > 4000 && saleAmount <= 5000)
                {
                    Console.WriteLine("Comission amount 5%");
                }
                else if (saleAmount > 5000 && saleAmount <= 6000)
                {
                    Console.WriteLine("Comission amount 6%");
                }
                else if (saleAmount > 6000 && saleAmount <= 7000)
                {
                    Console.WriteLine("Comission amount 7%");
                }
                else if (saleAmount > 7000 && saleAmount <= 8000)
                {
                    Console.WriteLine("Comission amount 8%");
                }
                else if (saleAmount > 8000 && saleAmount <= 9000)
                {
                    Console.WriteLine("Comission amount 9%");
                }
                else if (saleAmount > 9000 && saleAmount <= 10000)
                {
                    Console.WriteLine("Comission amount 10%");
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                answer = Console.ReadLine();
            }
            while (answer.ToLower() == "y");

        }
    }
}