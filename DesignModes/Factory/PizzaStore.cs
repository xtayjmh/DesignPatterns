using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Factory
{
    public abstract class PizzaStore : IBasicMode
    {
        protected PizzaStore()
        {
            
        }

        private Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            Console.WriteLine($"!!!your {pizza.Name} pizza is ready.");
            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
        

        public void Invoke()
        {
            Pizza pizza = OrderPizza("cheese");
        }
    }
}
