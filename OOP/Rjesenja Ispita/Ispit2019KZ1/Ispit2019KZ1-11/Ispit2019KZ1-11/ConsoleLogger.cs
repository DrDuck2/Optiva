using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ1_11
{
    class ConsoleLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Log(message, ConsoleColor.Green);
        }
        public void LogError(string message)
        {
            Log(message, ConsoleColor.Yellow);
        }
        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.ResetColor();
        }
    }
}
