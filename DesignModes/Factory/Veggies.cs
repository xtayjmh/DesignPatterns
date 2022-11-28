namespace ConsoleApp1.DesignModes.Factory;

public interface IVeggies
{
    string Name { get; }
}

public class Garlic : IVeggies
{
    public string Name { get; } = "Garlic";
}
public class Onion : IVeggies
{
    public string Name { get; } = "Onion";
}
public class Mushroom : IVeggies
{
    public string Name { get; } = "Mushroom";
}
public class RedPepper : IVeggies
{
    public string Name { get; } = "RedPepper";
}