using ConsoleApp1.Services;

public class FlyWithRocketPower : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying with rocket power");
    }
}