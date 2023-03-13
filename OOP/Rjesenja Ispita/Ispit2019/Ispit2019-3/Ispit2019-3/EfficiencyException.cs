using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019_3
{
    [Serializable]
    public class EfficiencyException : SystemException //SystemException je ekvivalent runtime_error iz C++
    {
        private double mEfficiency;
        public double GetmEfficiency
        {
            get { return this.mEfficiency; }
        }
        public EfficiencyException() { }
        public EfficiencyException(string message) : base(message) { }
        public EfficiencyException(string message, Exception innerException) : base(message,innerException) { }
        public EfficiencyException(double mEfficiency, string message) : base(message)
        {
            this.mEfficiency = mEfficiency;
        }
    }
}
