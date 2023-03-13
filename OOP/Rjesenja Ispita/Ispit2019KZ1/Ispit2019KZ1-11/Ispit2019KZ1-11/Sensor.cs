using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ1_11
{
    class Sensor
    {
        private string nName;
        private bool mIsActive;
        private double mPreviousRead;

        public Sensor(string nName)
        {
            this.nName = nName;
            this.mIsActive = false;
            this.mPreviousRead = 0;
        }

        public virtual string getCurrentRead()
        {
            Random gen = new Random();
            double readHolder;
            double mCurrentRead = 0.0 + (10.0 - 0.0) * gen.NextDouble();
            readHolder = this.mPreviousRead;
            this.mPreviousRead = mCurrentRead;
            return $"{this.nName} sensor. Current: {Math.Round(mCurrentRead,2)} Past: {Math.Round(readHolder,2)}";

        }

        public bool setmIsActive()
        {
            if (this.mIsActive == true)
            {
                return false;
            }
            else return true;
        }
    }
}
