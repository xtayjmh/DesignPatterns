namespace ConsoleApp1.DesignModes.Factory;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Console.WriteLine("a cheese pizza.");
    }

    public override void Prepare()
    {
    }
}