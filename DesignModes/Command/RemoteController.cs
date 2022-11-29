using System.Text;

namespace ConsoleApp1.DesignModes.Command;

public class RemoteController
{
    private ICommand[] _onCommands;
    private ICommand[] _offCommands;
    private ICommand? _lastCommand;

    public RemoteController()
    {
        _lastCommand = null;
        this._onCommands = new ICommand[7];
        this._offCommands = new ICommand[7];
        for (int i = 0; i < 7; i++)
        {
            _onCommands[i] = new NoCommand();
            _offCommands[i] = new NoCommand();
        }
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        _onCommands[slot] = onCommand;
        _offCommands[slot] = offCommand;
    }

    public void OnKeyPressed(int slot)
    {
        _onCommands[slot].Execute();
        _lastCommand = _onCommands[slot];
    }

    public void OffKeyPressed(int slot)
    {
        _offCommands[slot].Execute();
        _lastCommand = _offCommands[slot];
    }

    public void Undo()
    {
        if(_lastCommand != null)
        {
            _lastCommand.Undo();
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < _onCommands.Length; i++)
        {
            sb.AppendLine($"slot:{i}, {_onCommands[i].GetType().Name} --- {_offCommands[i].GetType().Name}");
        }
        return sb.ToString();
    }
}