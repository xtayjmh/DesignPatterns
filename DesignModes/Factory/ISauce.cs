namespace ConsoleApp1.DesignModes.Factory;

public interface ISauce
{
    string Name { get; }
}

public class MarinaraSauce : ISauce
{
    public string Name { get; } = "MarinaraSauce";
}