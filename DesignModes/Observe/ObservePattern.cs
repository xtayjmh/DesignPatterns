namespace ConsoleApp1.DesignModes.Observe;

public class ObservePattern : IBasicMode
{
    WeatherDataPublisher weatherDataPublisher = new WeatherDataPublisher();
    NormalDisplay normalDisplay = new NormalDisplay();
    StatisticsConditionDisplay statisticsConditionDisplay = new StatisticsConditionDisplay();
    public void Invoke()
    {
        IDisposable normalDisplayDisposable = weatherDataPublisher.Subscribe(normalDisplay);
        IDisposable statisticsDisplayDisposable = weatherDataPublisher.Subscribe(statisticsConditionDisplay);

        while (true)
        {
            WeatherData weatherData = new WeatherData();
            Console.WriteLine("请输入温度，湿度，压力");
            string? input = Console.ReadLine();
            var arr = input?.Split(",");
            weatherData.Temperature = arr?.ElementAtOrDefault(0);
            weatherData.Humidity = arr?.ElementAtOrDefault(1);
            weatherData.Pressure = arr?.ElementAtOrDefault(2);
            weatherDataPublisher.ReceiveNewData(weatherData);

            if(weatherData.Temperature=="5")
                normalDisplayDisposable.Dispose();
        }
    }
}