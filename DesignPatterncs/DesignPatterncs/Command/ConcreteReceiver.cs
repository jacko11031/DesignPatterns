﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterncs.Command
{
   public class ConcreteReceiver : Receiver
    {
        public void Action()
        {
            Console.WriteLine("Action Method called from Receiver!");
        }
    }
}
