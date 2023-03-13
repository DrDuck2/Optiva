using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LV6_Zad3
{
    class Tester
    {

        public static string GetAsStringRows<T>(IEnumerable<T> data)
        {
            return string.Join(Environment.NewLine, data);
        }
        public static void CarMakers() //Svi Proizvodjaci auta, sortirano uzlazno!
        {
            var carMakers = Networking.GetUsedCars().OrderBy(maker => maker.Make).Select(maker => maker.Make).Distinct();
            Console.WriteLine(Tester.GetAsStringRows(carMakers));
        }

        public static void CarMakerBiggestKm()
        {
            var carMakerBiggestKm = Networking.GetUsedCars().Where(km => km.Km == Networking.GetUsedCars().Max(km => km.Km)).Select(maker => maker.Make);
            Console.WriteLine(Tester.GetAsStringRows(carMakerBiggestKm));
        }

        public static void AverageDaciaAge()
        {
            double averageDaciaAge = Math.Round(Networking.GetUsedCars().Where(make => make.Make == "Dacia").Average(year => year.Year),2);
            Console.WriteLine(averageDaciaAge);
        }

        public static void AgeRange()
        {
            double firstAgeRange = Networking.GetUsedCars().Min(year => year.Year);
            double lastAgeRange = Networking.GetUsedCars().Max(year => year.Year); 
            Console.WriteLine($"[{firstAgeRange}-{lastAgeRange}]");

        }
    }
}
