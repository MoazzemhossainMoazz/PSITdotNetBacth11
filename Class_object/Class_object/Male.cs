using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_object
{
    internal class Male:Person, IMale
    {
        public Male() { }
        public Male(string pn) : base(pn) { }

        public void Action()
        {
            throw new NotImplementedException();
        }
    }
    internal sealed class Young:Male
    {
        public override void Display()
        {
            Console.WriteLine("This is a young class.");
        }

    }

    //public class abc: Young

    internal class Female : Person, IFemale
    {
        public void Action()
        {
            throw new NotImplementedException();
        }
    }


}
