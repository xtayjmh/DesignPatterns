using ConsoleApp1.Implements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DesignModes.Strategy.Implements;
using ConsoleApp1.DesignModes.Strategy.Models;

namespace ConsoleApp1.Models
{
    internal class RubDuck : Duck
    {
        public RubDuck() {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        protected override void Display()
        {
            Console.WriteLine("我是一只橡皮鸭子");
        }
    }
}
