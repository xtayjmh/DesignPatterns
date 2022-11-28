using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Decorator
{
    internal class DecoratorPattern : IBasicMode
    {
        public void Invoke()
        {
            Beverage beverage = new Espresso();//定一杯Espresso
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.GetDescription()} ${beverage1.Cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            beverage2 = new Soy(beverage2);
            Console.WriteLine($"{beverage2.GetDescription()} ${beverage2.Cost()}");

            Console.WriteLine("Venti Espresso");
            Beverage beverage3 = new Espresso() { CupSize = CupSize.Venti };
            beverage3 = new Mocha(beverage3);
            Console.WriteLine($"{beverage3.GetDescription()} {beverage3.Cost()}");
            
            Console.WriteLine("Tall Espresso");
            Beverage beverage4 = new Espresso() { CupSize = CupSize.Tall };
            beverage4 = new Mocha(beverage4);
            Console.WriteLine($"{beverage4.GetDescription()} {beverage4.Cost()}");
        }
    }
}
