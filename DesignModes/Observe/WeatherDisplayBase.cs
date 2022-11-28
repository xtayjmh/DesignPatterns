namespace ConsoleApp1.DesignModes.Observe;

public abstract class WeatherDisplayBase:IObserver<WeatherData>
{
    public virtual void OnCompleted()
    {
    }

    public virtual void OnError(Exception error)
    {
    }

    public abstract void OnNext(WeatherData value);
}