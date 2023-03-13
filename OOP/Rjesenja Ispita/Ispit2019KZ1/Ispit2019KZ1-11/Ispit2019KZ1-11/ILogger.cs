using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ1_11
{
    interface ILogger
    {
        public void LogInfo(string message);
        public void LogError(string message);
    }
}
