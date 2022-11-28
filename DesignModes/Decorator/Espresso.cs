namespace ConsoleApp1.DesignModes.Decorator;

public class Espresso : Beverage
{
    public Espresso()
    {
        description = "Espresso";
    }
    public override double Cost() => 1.99;
}