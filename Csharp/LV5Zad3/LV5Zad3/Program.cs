using System;

namespace LV5Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj elemenata polja: ");
            int brojElem = int.Parse(Console.ReadLine());
            int[] V = new int[brojElem];

            Random generator = new Random();
            for(int i = 0; i < brojElem-1; i++)
            {
                V[i] = generator.Next(-50, 50);
                Console.Write(V[i]);
                Console.Write(",");
            }
;
            Console.WriteLine($"Broj skokova: {Utilities.CountSpikes<int>(V)}");
        }
    }
}
