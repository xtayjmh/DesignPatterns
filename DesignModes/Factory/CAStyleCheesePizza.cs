namespace ConsoleApp1.DesignModes.Factory;

public class CAStyleCheesePizza : Pizza
{
    public CAStyleCheesePizza()
    {
        Name = "CA Style deep dish cheese pizza";
        Toppings.Add("shredded mozzarella Cheese");
    }

    public override void Prepare()
    {
    }
}