﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    public class ExitCommand: ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
}
