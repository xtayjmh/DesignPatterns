using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IClams Clams { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }

        public List<string> Toppings { get; set; } = new List<string>();
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("baking pizza.");
        }

        public void Cut()
        {
            Console.WriteLine("cutting pizza.");
        }

        public void Box()
        {
            Console.WriteLine("boxing pizza.");
        }
    }
}
