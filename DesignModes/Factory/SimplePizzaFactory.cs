namespace ConsoleApp1.DesignModes.Factory;

public class SimplePizzaFactory
{
    public static Pizza CreatePizza(string type)
    {
        Pizza pizza;
        switch (type)
        {
            case "cheese":
                pizza = new CheesePizza();
                break;
            case "clam":
                pizza = new ClamPizza();
                break;
            case "veggie":
                pizza = new VeggiePizza();
                break;
            default:
                pizza = new GreekPizza();
                break;
        }

        return pizza;
    }
}