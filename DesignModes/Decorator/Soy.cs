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
            var cost = 0.15;
            switch (beverage.CupSize)
            {
                case CupSize.Tall:
                    cost = 0.1;
                    break;
                case CupSize.Grand:
                    cost = 0.15;
                    break;
                case CupSize.Venti:
                    cost = 0.2;
                    break;
            }
            return beverage.Cost() + cost;
        }
    }
}
