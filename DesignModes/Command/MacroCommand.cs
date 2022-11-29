namespace ConsoleApp1.DesignModes.Command;

public class MacroCommand : ICommand
{
    private ICommand[] _commands;

    public MacroCommand(ICommand[] commands)
    {
        this._commands = commands;
    }

    public void Execute()
    {
        foreach (var command in _commands)
        {
            command.Execute();
        }
    }

    public void Undo()
    {
        foreach (var command in _commands)
        {
            command.Undo();
        }
    }
}