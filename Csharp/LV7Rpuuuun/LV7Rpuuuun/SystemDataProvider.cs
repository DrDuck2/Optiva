using System;
using System.Collections.Generic;
using System.Text;
namespace LV7Rpuuuun
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (currentLoad != this.previousCPULoad)
            {
                if (currentLoad/this.previousCPULoad > 0.1 || this.previousCPULoad/currentLoad > 0.1)
                {
                    this.Notify();
                }
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAMAvailable = this.AvailableRAM;
            if (currentRAMAvailable / this.AvailableRAM > 0.1 || this.AvailableRAM / currentRAMAvailable > 0.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentRAMAvailable;
            return currentRAMAvailable;
        }
    }
}
