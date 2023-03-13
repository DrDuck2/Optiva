using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_8
{
    interface ILocationManager
    {
        public Location ClosestLocation(Location currentLocation, Location[] neighbourLocations);
        public Location[] NeighbourLocationInRange(Location currentLocation, Location[] neighbourLocations, double range);
    }
}
