using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_object
{
    internal class Person
    {
        string name;

        public Person()
        {
            name = "Unknown";
        }

        public Person(string n)
        {
            name = n;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: " + name);
        }
    }
}
