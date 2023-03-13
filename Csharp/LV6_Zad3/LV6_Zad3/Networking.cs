using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Zad3
{
    public static class Networking 
    {
        private static List<Car> usedCars = new List<Car>
        {
            new Car("Peugeot", "308", 178000, 2011),
            new Car("VW", "Passat", 129000, 2016),
            new Car("Volvo", "V40", 141600, 2016),
            new Car("Opel", "Insignia", 320395, 2011),
            new Car("Dacia", "Duster", 53509, 2015),
            new Car("VW", "Golf VI", 170000, 2010),
            new Car("VW", "Golf VI", 149000, 2009),
            new Car("Opel", "Astra", 146200, 2007),
            new Car("Peugeot", "4007", 249800, 2008),
            new Car("Ford", "Fiesta", 158111, 2013),
            new Car("Dacia", "Sandero", 121000, 2014),
            new Car("Peugeot", "208", 134878, 2016),
            new Car("Opel", "Meriva", 128500, 2010),
            new Car("VW", "Golf VII", 178000, 2013),
            new Car("Opel", "Astra", 167000, 2011),
            new Car("Ford", "C-Max", 1203835, 2009),
            new Car("VW", "Passat", 132700, 2014),
            new Car("Renault", "Megane", 186650, 2009),
            new Car("Ford", "Focus", 182459, 2012),
            new Car("Hyundai", "ix35", 163258, 2013),
            new Car("Peugeot", "308", 148000, 2014),
            new Car("Renault", "Megane", 150000, 2016),
            new Car("Opel", "Astra", 230000, 2011),
            new Car("Dacia", "Duster", 126000, 2015),
            new Car("Renault", "Clio", 118000, 2007),
            new Car("VW", "Polo", 102000, 2014),
            new Car("Nissan", "Qashqai", 132000, 2014),
            new Car("VW", "Golf V", 280000, 2005),
            new Car("Seat", "Ibiza", 73000, 2013),
            new Car("Renault", "Scenic", 98895, 2017),
        };

        public static IEnumerable<Car> GetUsedCars()
        {
            return usedCars.AsReadOnly();
        }
    }
}
