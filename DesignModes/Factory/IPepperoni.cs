namespace ConsoleApp1.DesignModes.Factory;

public interface IPepperoni
{
    string Name { get; }
}

public class SlicedPepperoni : IPepperoni
{
    public string Name { get; } = "SlicedPepperoni";
}