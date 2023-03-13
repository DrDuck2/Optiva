using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ispit2021_8
{
    class EuclideanManager : ILocationManager
    {
        public Location ClosestLocation(Location currentLocation, Location[] neighbourLocations)
        {
            int locationHolder = 0;
            double lenght = Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbourLocations[0].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbourLocations[0].Longitude, 2));
            for (int i = 1; i < neighbourLocations.Length; i++)
            {
                if (Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbourLocations[i].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbourLocations[i].Longitude, 2)) < lenght)
                {
                    lenght = Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbourLocations[i].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbourLocations[i].Longitude, 2));
                    locationHolder = i;
                }
            }
            return neighbourLocations[locationHolder];
        }
        public Location[] NeighbourLocationInRange(Location currentLocation, Location[] neighbourLocations, double range)
        {
            List<Location> lokacije = new List<Location>();
            for (int i = 0; i < neighbourLocations.Length; i++)
            {
                if(Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbourLocations[i].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbourLocations[i].Longitude, 2)) < range)
                {
                    lokacije.Add(neighbourLocations[i]);
                }
            }
            return lokacije.Cast<Location>().ToArray();
        }
    }

}
