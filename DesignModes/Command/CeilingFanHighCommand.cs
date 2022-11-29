﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    internal class CeilingFanHighCommand : ICommand
    {
        int lastSpeed;
        CeilingFan CeilingFan;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            CeilingFan = ceilingFan;
        }

        public void Execute()
        {
            lastSpeed = CeilingFan.GetSpeed();
            CeilingFan.SetHigh();
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
