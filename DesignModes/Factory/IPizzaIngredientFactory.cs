namespace ConsoleApp1.DesignModes.Factory;

/// <summary>
/// 抽象工厂
/// </summary>
public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public IPepperoni CreatePepperoni();
    public IClams CreateClams();
    public List<IVeggies> CreateVeggies();
}