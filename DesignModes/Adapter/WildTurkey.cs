using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Adapter
{
    internal class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I can fly a short distance.");
        }

        public void Gooby()
        {
            Console.WriteLine("Gooby");
        }
    }
}
