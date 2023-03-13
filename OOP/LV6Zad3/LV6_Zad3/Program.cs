using System;

namespace LV6_Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All car companies: ");
            Tester.CarMakers();
            Console.WriteLine("Car company with most Km passed: ");
            Tester.CarMakerBiggestKm();
            Console.WriteLine("Average Dacia age: ");
            Tester.AverageDaciaAge();
            Console.WriteLine("Car Age Range: ");
            Tester.AgeRange(); ---------------------------------
        }
    }
}
