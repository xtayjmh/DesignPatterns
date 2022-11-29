namespace ConsoleApp1.DesignModes.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}