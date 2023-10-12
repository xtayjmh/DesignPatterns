using ConsoleApp1.DesignModes.Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Adapter
{
    internal class AdapterPattern : IBasicMode
    {
        public void Invoke()
        {
            IDuck duck = new MallardDuck();
            duck.Fly();
            duck.Quack();

            ITurkey turkey = new WildTurkey();
            turkey.Gooby();
            turkey.Fly();

            ITurkey turkey1 = new WildTurkey();
            IDuck adapterDuck = new TurkeyAdapter(turkey1);
            Console.WriteLine("I'm a duck adapter");
            adapterDuck.Quack();
            adapterDuck.Fly();
        }
    }
}
