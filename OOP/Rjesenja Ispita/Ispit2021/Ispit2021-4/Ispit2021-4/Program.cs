using System;
using System.Collections.Generic;

namespace Ispit2021_4
{
    public class Program
    {
        public static int InProfitRange(FoodTracker[] tracker, double value)
        {
            int inrange = 0;
            for (int i = 0; i < tracker.Length; i++)
            {
                if(tracker[i].MaxProfit() >= value)
                {
                    inrange++;
                }
            }
            if (inrange == 0) throw new NothingInRangeException("No Profit In Range!",value);
            return inrange;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Add the number of portions: ");
            Portion[] portion = new Portion[int.Parse(Console.ReadLine())];
            FoodTracker tracker = new FoodTracker();

            Random gen = new Random();
            for (int i = 0; i < portion.Length; i++)
            {
                portion[i] = new Portion(Math.Round((decimal)(0+(100-0)*gen.NextDouble()),2), Math.Round(gen.NextDouble(), 2), Math.Round(1 + (800 - 1) * gen.NextDouble(),2));
                tracker.Track(portion[i]);
                Console.WriteLine(portion[i]);
            }

            Console.WriteLine("After remover: ");
            Func<Portion, bool> lessThan30 = x => x.Price > 30 == true;
            tracker.PortionRemover(lessThan30);
            Console.WriteLine(tracker);


            Console.WriteLine("Add the number of portions: ");
            Portion[] portion2 = new Portion[int.Parse(Console.ReadLine())];
            Console.WriteLine("Add the number of food trackers: ");
            FoodTracker[] nutritionaltracker = new NutritionalTracker[int.Parse(Console.ReadLine())];
            for (int j = 0; j < nutritionaltracker.Length; j++)
            {
                nutritionaltracker[j] = new NutritionalTracker(gen.NextDouble(), Math.Round(1 + (300 - 1) * gen.NextDouble(), 2));
                for (int i = 0; i < portion2.Length; i++)
                {
                    portion2[i] = new Portion(Math.Round((decimal)(0 + (100 - 0) * gen.NextDouble()), 2), Math.Round(gen.NextDouble(), 2), Math.Round(1 + (800 - 1) * gen.NextDouble(), 2));
                    nutritionaltracker[j].Track(portion[i]);
                }
            }
            try
            {
                Console.Write($"{InProfitRange(nutritionaltracker, Math.Round((0 + (1000 - 0) * gen.NextDouble()), 2))}");
            }
            catch(NothingInRangeException e)
            {
                Console.Write($"{e.Message}{Environment.NewLine}{e.getValue}");
            }
           
        }
    }
}
