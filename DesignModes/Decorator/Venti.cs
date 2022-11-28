namespace ConsoleApp1.DesignModes.Decorator;

public class Venti:CupSize
{
    private Beverage beverage;
    public Venti(Beverage beverage)
    {
        this.beverage = beverage;
        description = beverage.description + ", Venti";
    }
    public override double Cost()
    {
        return beverage.Cost() + .2;
    }
}