namespace ConsoleApp1.DesignModes.Decorator;

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        description = "DarkRoast Coffee";
    }

    public override double Cost()
    {
        return 0.99;
    }
}