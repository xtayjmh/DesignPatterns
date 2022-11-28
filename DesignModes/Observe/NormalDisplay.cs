namespace ConsoleApp1.DesignModes.Observe;

public class NormalDisplay:WeatherDisplayBase
{
    
    public override void OnNext(WeatherData weatherData)
    {
        Console.WriteLine("---------------");
        Console.WriteLine("当前天气状况板");
        Console.WriteLine($"温度：{weatherData.Temperature}湿度：{weatherData.Humidity} 气压：{weatherData.Pressure}");
    }
}