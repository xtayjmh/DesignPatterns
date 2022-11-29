namespace ConsoleApp1.DesignModes.Singleton;

public class Singleton
{
    // private static Singleton uniqueInstance;
    private static volatile Singleton uniqueInstance; //volatile解决多线程中的单例模式的问题

    public Singleton() { }

    public static Singleton Instance()
    {
        if (uniqueInstance == null)
            uniqueInstance = new Singleton();

        return uniqueInstance;
    }
}