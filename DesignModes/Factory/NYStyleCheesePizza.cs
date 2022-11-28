namespace ConsoleApp1.DesignModes.Factory;

public class NYStyleCheesePizza : Pizza
{
    private IPizzaIngredientFactory ingredientFactory;

    public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        this.ingredientFactory = ingredientFactory;
        Name = "NY Style Sauce and cheese pizza";
        Toppings.Add("Grated Reggiano Cheese");
    }

    public override void Prepare()
    {
        Console.WriteLine($"Preparing: {Name}");
        Dough = ingredientFactory.CreateDough();
        Sauce = ingredientFactory.CreateSauce();
        Cheese = ingredientFactory.CreateCheese();
    }
}