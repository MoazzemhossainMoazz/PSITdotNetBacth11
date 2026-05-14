using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_object
{
   internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John");
            person.Display();
            Male male = new Male("Moazzem");
            person.Display();
            male.Display();
            Young young = new Young();
            young.Display();
        }

        
    }
}