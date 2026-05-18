using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListEx_Patient
{
    internal class Patient
    {
        static int counter;
        public Patient()
        {
            counter++;
            this.Id = counter;
            
        }
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

    }
}
