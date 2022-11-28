using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Decorator
{
    internal class Soy : Condiment
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description += ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.15;
        }
    }
}
