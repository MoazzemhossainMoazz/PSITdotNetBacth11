using Delegate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{
    public delegate void SendMessage(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            SendMessage sendMessage = new SendMessage(SendSMS);
            sendMessage += SendEmail;
            sendMessage -= SendEmail;
            sendMessage("We are Asp.NET Developer");
            List<int> rolls = new List<int> { 4, 3, 5, 23, 34, 56, 77 };
            Console.Write(rolls.Max());
            List<Emp> emplist = new List<Emp>
            {
                new Emp{Name = "Sakib", Salary=32412, Address="dhaka"},
                new Emp{Name = "Tamim", Salary=32512, Address="dhaka"},
                new Emp{Name = "Musfiq", Salary=32312, Address="dhaka"},
            };
            emplist.Max(e => e.Salary);
            emplist.Average(e => e.Salary);
            emplist.Exists(e => e.Name.Equals("Pavel"));



        }

        public static void SendSMS(string message)
        {
            Console.WriteLine($"{message} send by sms");
        }
        public static void SendEmail(string message) 
        {
            Console.WriteLine($" {message} send by emil.");
        }

    }
}

