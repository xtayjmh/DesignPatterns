namespace ConsoleApp1.DesignModes.Factory;

public class CAPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        switch (type)
        {
            case "cheese":
                pizza = new CAStyleCheesePizza();
                break;
            case "clam":
                pizza = new CAStyleClamPizza();
                break;
            case "veggie":
                pizza = new CAStyleVeggiePizza();
                break;
            default:
                pizza = new CAStyleGreekPizza();
                break;
        }

        return pizza;
    }
}