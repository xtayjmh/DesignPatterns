namespace ConsoleApp1.DesignModes.Decorator;

public abstract class Beverage
{
    internal string description = "Unknown Beverage";

    public string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}