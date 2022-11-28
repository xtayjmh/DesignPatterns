using ConsoleApp1.DesignModes;
using ConsoleApp1.DesignModes.Strategy;
using ConsoleApp1.DesignModes.Strategy.Models;
using ConsoleApp1.Models;

public class StrategyPattern : IBasicMode
{
    public void Invoke()
    {
        // 策略模式
        Console.WriteLine("I'm a MallardDuck");
        Duck mallard = new MallardDuck();
        //mallard.SetFlyBehavior(new FlyWithWings());
        mallard.PerformFly();
        //mallard.SetQuackBehavior(new Quack());
        mallard.PerformQuack();

        Console.WriteLine("I'm a RubDuck");

        Duck rubDuck = new RubDuck();
        rubDuck.PerformFly();
        rubDuck.PerformQuack();

        rubDuck.SetFlyBehavior(new FlyWithRocketPower());
        rubDuck.PerformFly();
    }
}