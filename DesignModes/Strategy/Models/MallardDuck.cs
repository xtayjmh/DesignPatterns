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
    internal class MallardDuck : Duck
    {
        public MallardDuck() {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        protected override void Display()
        {
            Console.WriteLine("我是一只绿头鸭子");
        }
    }
}
