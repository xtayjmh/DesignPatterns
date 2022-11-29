using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    internal class CeilingFanOffCommand : ICommand
    {
        int lastSpeed;
        CeilingFan CeilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            lastSpeed = CeilingFan.GetSpeed();
            CeilingFan.SetOff();
        }

        public void Undo()
        {
            switch (lastSpeed)
            {
                case CeilingFan.High:
                    CeilingFan.SetHigh();
                    break;
                case CeilingFan.Medium:
                    CeilingFan.SetMedium();
                    break;
                case CeilingFan.Low:
                    CeilingFan.SetLow();
                    break;
                case CeilingFan.Off:
                    CeilingFan.SetOff();
                    break;
            }
        }
    }
}
