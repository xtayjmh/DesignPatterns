namespace ConsoleApp1.DesignModes.Factory;

public class NYStyleClamPizza : Pizza
{
    IPizzaIngredientFactory factory;
    public NYStyleClamPizza(IPizzaIngredientFactory factory)
    {
        Name = "NYStyleClamPizza";
        this.factory = factory;
    }
    public override void Prepare()
    {
        Console.WriteLine($"Preparing: {Name}");
        Clams = factory.CreateClams();
    }
}