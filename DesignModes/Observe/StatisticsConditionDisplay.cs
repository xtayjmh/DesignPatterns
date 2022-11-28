namespace ConsoleApp1.DesignModes.Observe;

public class StatisticsConditionDisplay : WeatherDisplayBase
{
    private List<float> temperatures = new List<float>();
    public override void OnNext(WeatherData value)
    {
        if (float.TryParse(value.Temperature, out var temperature))
        {
            temperatures.Add(temperature);
        }

        Console.WriteLine("---------------");
        Console.WriteLine("温度统计板");
        Console.WriteLine($"平均温度：{temperatures.Average()}最高温度：{temperatures.Max()}最低温度：{temperatures.Min()}");
    }
}