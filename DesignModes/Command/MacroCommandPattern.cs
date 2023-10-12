using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    public class MacroCommandPattern : IBasicMode
    {
        public void Invoke()
        {
            RemoteController remoteController = new RemoteController();
            Light light = new Light("Living Room");
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);

            Light light1 = new Light("Kitchen Room");
            LightOnCommand lightOnCommand1 = new LightOnCommand(light1);
            LightOffCommand lightOffCommand1 = new LightOffCommand(light1);

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            ICommand[] partyOnCommands = new ICommand[] { lightOnCommand, lightOnCommand1, ceilingFanHighCommand };
            
            ICommand[] partyOffCommands = new ICommand[] { lightOffCommand, lightOffCommand1, ceilingFanOffCommand };
            remoteController.SetCommand(0, new MacroCommand(partyOnCommands), new MacroCommand(partyOffCommands));
            remoteController.OnKeyPressed(0);
            remoteController.OffKeyPressed(0);
            remoteController.Undo();
            Console.WriteLine(remoteController.ToString());
            
        }
    }
}
