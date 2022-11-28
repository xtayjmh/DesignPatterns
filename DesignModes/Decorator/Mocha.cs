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
            var cost = 0.2;
            switch (beverage.CupSize)
            {
                case CupSize.Tall:
                    cost = 0.2;
                    break;
                case CupSize.Grand:
                    cost = 0.25;
                    break;
                case CupSize.Venti:
                    cost = 0.3;
                    break;
            }
            return beverage.Cost() + cost;
        }
    }
}
