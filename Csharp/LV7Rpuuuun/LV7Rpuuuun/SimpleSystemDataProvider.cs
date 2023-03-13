using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace LV7Rpuuuun
{
    public abstract class SimpleSystemDataProvider
    {
        private System.Diagnostics.PerformanceCounter cpuCounter;
        private System.Diagnostics.PerformanceCounter ramCounter;
        private List<Logger> loggers;
        public SimpleSystemDataProvider()
        {
            this.cpuCounter =
            new System.Diagnostics.PerformanceCounter("Processor", "% processor time", "_Total");
            this.ramCounter =
            new System.Diagnostics.PerformanceCounter("Memory", "Available MBytes");
            this.loggers = new List<Logger>();
        }
        public float CPULoad { get { return this.cpuCounter.NextValue(); } }
        public float AvailableRAM { get { return this.ramCounter.NextValue(); } }
        public void Attach(Logger logger)
        {
            if (!this.loggers.Contains(logger))
                this.loggers.Add(logger);
        }
        public void Detach(Logger logger)
        {
            this.loggers.Remove(logger);
        }
        public void Notify()
        {
            foreach (Logger logger in this.loggers)
            {
                logger.Log(this);
            }
        }
    }
}
}
