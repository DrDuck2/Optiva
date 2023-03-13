using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_4
{
    [Serializable]
    public class NothingInRangeException : Exception
    {
        private double value;

        public double getValue
        {
            get { return this.value; }
        }
        public NothingInRangeException() { }
        public NothingInRangeException(string message) : base(message) { }
        public NothingInRangeException(string message, Exception innerException) : base(message, innerException) { }
        public NothingInRangeException(string message, double value) : base(message)
        {
            this.value = value;
        }
    }
}
