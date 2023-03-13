using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine(provider.CPULoad);
            Console.WriteLine(provider.AvailableRAM);
        }
    }
}
