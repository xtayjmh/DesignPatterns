namespace ConsoleApp1.DesignModes.Decorator;

public class Tall : CupSize
{
    private Beverage beverage;

    public Tall(Beverage beverage)
    {
        this.beverage = beverage;
        description = beverage.description + ", Tall";
    }
    public override double Cost()
    {
        return beverage.Cost() + 0.1;
    }
}