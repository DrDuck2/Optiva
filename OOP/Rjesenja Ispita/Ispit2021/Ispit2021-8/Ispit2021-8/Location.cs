using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_8
{
    class Location
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public Location(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

    }
}
