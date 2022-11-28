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
            var cost = 0.05;
            switch (beverage.CupSize)
            {
                case CupSize.Tall:
                    cost = 0.05;
                    break;
                case CupSize.Grand:
                    cost = 0.1;
                    break;
                case CupSize.Venti:
                    cost = 0.15;
                    break;
            }
            return beverage.Cost() + cost;
        }
    }
}
