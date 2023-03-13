using System;
using System.Collections.Generic;
using System.Text;

namespace LV2RPPOON
{
    class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
            Console.WriteLine(data);
        }
    }
}
