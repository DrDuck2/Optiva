using System;

namespace Ispit2019_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite velicinu polja Panela: ");
            Random gen = new Random();
            SolarPanel[] paneli = new SolarPanel[int.Parse(Console.ReadLine())];
            for (int i = 0; i < paneli.Length; i++)
            {
                if (i < paneli.Length / 2)
                {
                    paneli[i] = new SolarPanel(gen.Next(1,10),gen.Next(1,10),gen.NextDouble());
                }
                else paneli[i] = new SolarPanelAge(gen.NextDouble(),gen.Next(0,10), gen.Next(1, 10), gen.Next(1, 10), gen.NextDouble());
            }
            double maxEnergy = 0;
            for (int i = 0; i < paneli.Length; i++)
            {
                try
                {
                    if (paneli[i].YearlyEnergy() > maxEnergy)
                    {
                        maxEnergy = paneli[i].YearlyEnergy();
                    }
                }
                catch(EfficiencyException e)
                {
                    Console.WriteLine($"Efficiency: {e.GetmEfficiency}");
                }
            }
            Console.WriteLine($"MaxEnergy: {maxEnergy}");
        }
    }
}
