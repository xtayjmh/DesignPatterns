﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DesignModes.Command
{
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }
    }
}
