namespace ConsoleApp1.DesignModes.Factory;

public interface IClams
{
    string Name { get; }
}

public class FreshClams : IClams
{
    public string Name { get; } = "FreshClams";
}