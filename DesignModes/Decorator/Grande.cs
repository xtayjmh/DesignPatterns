namespace ConsoleApp1.DesignModes.Decorator;

public class Grande : Beverage
{
    private Beverage beverage;

    public Grande(Beverage beverage)
    {
        this.beverage = beverage;
        description = GetDescription() + ", Grande";
    }
    public override double Cost()
    {
        return beverage.Cost() + .15;
    }
}