using ConsoleApp1.Implements;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Strategy.Models
{
    internal abstract class Duck
    {
        protected abstract void Display();
        public void Swim()
        {
            Console.WriteLine("I'm swimming");
        }

        public Duck() { }

        protected IQuackBehavior QuackBehavior;
        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }
        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            QuackBehavior = quackBehavior;
        }

        protected IFlyBehavior FlyBehavior;
        public void PerformFly()
        {
            FlyBehavior.Fly();
        }
        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
        }

    }
}
