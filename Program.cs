using ConsoleApp1.Implements;
using ConsoleApp1.Models;
using System.Threading.Tasks;using ConsoleApp1.DesignModes.Decorator;using ConsoleApp1.DesignModes.Factory;
using ConsoleApp1.DesignModes.Observe;
using ConsoleApp1.DesignModes.Command;
using ConsoleApp1.DesignModes.Adapter;

//int[] input = { 4, 1, 2, 6, 9, 10, 3 };
//int sum = 0;
//try
//{
//    Parallel.ForEach(input, () => { return  0; }, NewMethod(),

//        (localSum) => Interlocked.Add(ref sum, localSum)
//    );
//    Console.WriteLine("\nSum=0", sum);

//}
//catch (AggregateException ex)
//{
//    Console.WriteLine("Parallel.ForEach has thrown an exception. THIS WAS NOT EXPECTED.\n{0}", ex);
//}

//static Func<int, ParallelLoopState, int, int> NewMethod()
//{
//    return (n, loopState, localSum) =>
//    {
//        localSum += n;
//        Console.WriteLine("Thread={0},n={1},localSum{2}", Thread.CurrentThread.ManagedThreadId, n, localSum);
//        return localSum;
//    };
//}

// new StrategyPattern().Invoke(); //策略模式
// new ObservePattern().Invoke(); //观察者模式
// new DecoratorPattern().Invoke(); //装饰者模式
// new NYPizzaStore().Invoke(); //工厂模式&抽象工厂模式
// new CAPizzaStore().Invoke();
// new CommandPattern().Invoke(); //命令模式
// new MacroCommandPattern().Invoke();

new AdapterPattern().Invoke();
Console.ReadKey();//监听键盘事件，按任意键执行退出。