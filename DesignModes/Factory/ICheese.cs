namespace ConsoleApp1.DesignModes.Factory;

public interface ICheese
{
    string Name { get; }
}

public class ReggianoCheese : ICheese
{
    public string Name { get; } = "ReggianoCheese";
}