using System;

namespace LV4Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Koliko djece? : ");
            int brDjece = int.Parse(Console.ReadLine());
            Dijete[] dijeca = new Dijete[brDjece];
            for (int i = 0; i < dijeca.Length; i++)
            {
                Console.WriteLine($"Pere li {i+1} dijete ruke? da/ne");
                bool pere;
                if (Console.ReadLine() == "ne")
                {
                    pere = false;
                }
                else pere = true;
                dijeca[i] = new Dijete(random.Next(0, 100), random.Next(0, 100),pere);
            }
            for (int i = 0; i < dijeca.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(dijeca[i].ToString());
            }
            IGoodBad goodbad = new EpidemiologyChecker();
            SantasHelper helper = new SantasHelper(random.Next(0, 100), random.Next(0, 100), goodbad);
            Console.WriteLine(helper.ToString());
            Console.WriteLine($"EpidemiologyChecker SantaReady: {helper.SantaReady(dijeca)}");
            goodbad = new HolidayChecker();
            helper.SetGoodBad(goodbad);
            Console.WriteLine($"HolidayChecker SantaReady: {helper.SantaReady(dijeca)}");
        }
    }
}
