namespace ConsoleApp1.DesignModes.Factory;

public interface IDough
{
    string Name { get; }
}

public class ThinCrustDough : IDough
{
    public string Name { get; } = "ThinCrustDough";
}