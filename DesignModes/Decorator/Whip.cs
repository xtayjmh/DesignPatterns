using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Decorator
{
    internal class Whip : Condiment
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            description = beverage.description += ", Whip";
        }
        public override double Cost()
        {
            return beverage.Cost() + .10;
        }
    }
}
