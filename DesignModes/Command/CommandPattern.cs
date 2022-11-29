using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    internal class CommandPattern : IBasicMode
    {
        public void Invoke()
        {
            RemoteController remoteController = new RemoteController();
            Light light = new Light("Living Room");
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            LightOffCommand lightOffCommand = new LightOffCommand(light);
            remoteController.SetCommand(0, lightOnCommand, lightOffCommand);
            
            Light light1 = new Light("Kitchen Room");
            LightOnCommand lightOnCommand1 = new LightOnCommand(light1);
            LightOffCommand lightOffCommand1 = new LightOffCommand(light1);
            remoteController.SetCommand(1, lightOnCommand1, lightOffCommand1);

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanOffCommand ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            remoteController.SetCommand(2, ceilingFanHighCommand, ceilingFanOffCommand);
            CeilingFanLowCommand ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            remoteController.SetCommand(3, ceilingFanLowCommand, ceilingFanOffCommand);


            Console.WriteLine(remoteController.ToString());
            remoteController.OnKeyPressed(0);
            remoteController.OffKeyPressed(0);
            remoteController.Undo();

            remoteController.OnKeyPressed(1);
            remoteController.OffKeyPressed(1);
            remoteController.Undo();
            
            remoteController.OnKeyPressed(2);
            remoteController.OffKeyPressed(2);
            remoteController.Undo();
            
            remoteController.OnKeyPressed(3);
            remoteController.OffKeyPressed(3);
            remoteController.Undo();
        }
    }
}
