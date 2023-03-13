using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021
{
    public class Wind
    {
        private double speed;
        private string description;

        public double SpeedKmh
        {
            get { return this.speed; }
        }
        public string Description
        {
            get { return this.description; }
        }

        public Wind(double speed, string description)
        {
            this.speed = speed;
            this.description = description;
        }
        public Wind()
        {
            this.speed = 0;
            this.description = "Calm";
        }

        public double Osjet(double temp)
        {
            if(temp<=10)
            {
                return 0.6215 * temp - 11.37 * Math.Pow(this.speed, 0.16) + 0.3965 * temp * Math.Pow(this.speed, 0.16) + 13.12;
            }
            else return 0.6215 * temp - 11.37 + 0.3965 * temp + 13.12;
        }
    }
}
