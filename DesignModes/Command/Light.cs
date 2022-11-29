using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    public class Light
    {
        public string LightName;

        public Light(string lightName)
        {
            LightName = lightName;
        }

        public void On()
        {
            Console.WriteLine($"{LightName} is on");
        }
        public void Off()
        {
            Console.WriteLine($"{LightName} is off");
        }
    }
}
