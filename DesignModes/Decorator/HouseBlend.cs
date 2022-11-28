﻿namespace ConsoleApp1.DesignModes.Decorator;

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        description = "House Blend Coffee";
    }
    public override double Cost() => 0.89;
}