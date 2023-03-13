using System;

namespace Ispit2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Wind w1 = new Wind(31.5, "North");
            Wind w2 = new Wind();
            Console.WriteLine($"Speed: {w2.SpeedKmh} km/h, description: {w2.Description}");

            Console.WriteLine("Unesite velicinu polja vjetrova: ");
            Wind[] ElNino = new Wind[int.Parse(Console.ReadLine())];
            Random gen = new Random();
            for (int i = 0; i < ElNino.Length; i++)
            {
                ElNino[i] = new Wind(1 + (100 - 1) * gen.NextDouble(), "description");
            }
            Console.WriteLine($"Number of extreme winds: {WeatherStatistics.ExtremeWinds(ElNino)}");
        }
    }
}
