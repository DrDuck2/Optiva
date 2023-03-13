using System;

namespace Ispit2019KZ1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            LoggingSensor accelerationSensor = new LoggingSensor("Acceleration",logger);
            accelerationSensor.getCurrentRead();
        }
    }
}
