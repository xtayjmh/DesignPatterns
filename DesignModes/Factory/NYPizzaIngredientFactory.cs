namespace ConsoleApp1.DesignModes.Factory;

public class NYPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
    {
        Console.WriteLine("creating thinCrust dough");
        return new ThinCrustDough();
    }

    public ISauce CreateSauce()
    {
        Console.WriteLine("creating marinara sauce");
        return new MarinaraSauce();
    }

    public ICheese CreateCheese()
    {
        Console.WriteLine("creating reggiano cheese");
        return new ReggianoCheese();
    }

    public IPepperoni CreatePepperoni()
    {
        Console.WriteLine("creating sliced pepperoni");
        return new SlicedPepperoni();
    }

    public IClams CreateClams()
    {
        return new FreshClams();
    }

    public List<IVeggies> CreateVeggies()
    {
        return new List<IVeggies>() { new RedPepper(), new Garlic(), new Mushroom(), new Onion() };
    }
}