namespace ConsoleApp1.DesignModes.Factory;

public class NYPizzaStore : PizzaStore
{
    private IPizzaIngredientFactory factory = new NYPizzaIngredientFactory();

    public override Pizza CreatePizza(string type)
    {
        Pizza pizza;
        switch (type)
        {
            case "cheese":
                pizza = new NYStyleCheesePizza(factory);
                break;
            case "clam":
                pizza = new NYStyleClamPizza(factory);
                break;
            case "veggie":
                pizza = new NYStyleVeggiePizza();
                break;
            default:
                pizza = new NYStyleGreekPizza();
                break;
        }

        return pizza;
    }
}