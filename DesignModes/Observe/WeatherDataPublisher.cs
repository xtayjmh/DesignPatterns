namespace ConsoleApp1.DesignModes.Observe;
// 实现IObservable
public class WeatherDataPublisher : IObservable<WeatherData>
{
    List<IObserver<WeatherData>> observers = new List<IObserver<WeatherData>>();
    // 订阅主题，将观察者添加到观察者列表中
    public IDisposable Subscribe(IObserver<WeatherData> observer)
    {
        observers.Add(observer);
        return new UnSubscribe(this.observers, observer);
    }

    private class UnSubscribe : IDisposable
    {
        private List<IObserver<WeatherData>> observers;
        private IObserver<WeatherData> observer;
        // 取消订阅
        public UnSubscribe(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer)
        {
            this.observers = observers;
            this.observer = observer;
        }
        public void Dispose()
        {
            if (this.observers.Any())
            {
                this.observers.Remove(observer);
            }
        }
    }
    // 通知已订阅的观察者
    private void Notify(WeatherData data)
    {
        observers?.ForEach(observer => { observer.OnNext(data); });
    }
    // 接收最新的天气情况
    public void ReceiveNewData(WeatherData data)
    {
        Notify(data);
    }
}