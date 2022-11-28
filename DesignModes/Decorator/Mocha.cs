using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Decorator
{
    internal class Mocha : Condiment
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage; 
            description = beverage.description += ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.2;
        }
    }
}
