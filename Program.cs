using ConsoleApp1.Implements;
using ConsoleApp1.Models;
using System.Threading.Tasks;using ConsoleApp1.DesignModes.Decorator;
using ConsoleApp1.DesignModes.Observe;

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
// new ObservePattern().Invoke();
new DecoratorPattern().Invoke();
Console.ReadKey();//监听键盘事件，按任意键执行退出。