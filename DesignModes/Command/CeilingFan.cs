using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    public class CeilingFan
    {
        public const int High = 3;
        public const int Low = 4;
        public const int Medium = 5;
        public const int Off = 6;
        public string Name;
        int Speed;

        public CeilingFan(string name)
        {
            Name = name;
        }
        public void SetHigh()
        {
            Console.WriteLine($"{Name} ceiling fan is on High");
            Speed = High;
        }
        public void SetMedium()
        {
            Console.WriteLine($"{Name} ceiling fan is on medium");
            Speed = Medium;
        }
        public void SetLow()
        {
            Console.WriteLine($"{Name} ceiling fan is on low");
            Speed = Low;
        }
        public void SetOff()
        {
            Console.WriteLine($"{Name} ceiling fan is off");
            Speed = Off;
        }
        public int GetSpeed()
        {
            return Speed;
        }
    }
}
