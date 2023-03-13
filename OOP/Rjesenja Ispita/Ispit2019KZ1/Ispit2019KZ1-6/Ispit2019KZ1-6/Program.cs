using System;

namespace Ispit2019KZ1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceHistory ikeaSofa = new PriceHistory(10, 3420.0);
            PriceHistory[] primaSofa = new PriceHistory[ikeaSofa.GetmCount];
            for (int i = 0; i < primaSofa.Length; i++)
            {
                primaSofa[i] = new PriceHistory(ikeaSofa);
            }

            PriceHistory appleStock = new PriceHistory(6, 74545);
            PriceHistory googleStock = new PriceHistory(10, 41656);
            if (appleStock < googleStock)
            {
                Console.WriteLine("Invest in Apple!");
            }
            else Console.WriteLine("Invest in Google!");

            PriceHistory testitem = new PriceHistory(10, 2022);

            PriceHistory.Store(testitem, "C:\\Users\\vidov\\Desktop\\DominikVidovic.txt");
            
        }
    }
}
