using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ1_11
{
    class LoggingSensor : Sensor
    {
        ConsoleLogger logger;
        public LoggingSensor(string nName,ConsoleLogger logger) : base(nName)
        {
            this.logger = logger;
        }
        public override string getCurrentRead()
        {
            Random gen = new Random();
            double mCurrentRead = 0.0 + (10.0 - 0.0) * gen.NextDouble();
            logger.LogInfo(base.getCurrentRead());
            return base.getCurrentRead();
        }
    }
}
