using System;

namespace Ispit2019KZ2
{
    class Program
    {
        public static double inRange<T>(T[] array, int lowerRange, int upperRange) where T : IComparable
        {
            double percentage = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].CompareTo(lowerRange) >0 && array[i].CompareTo(upperRange) <0)
                {
                    percentage++;
                }
            }
            return Math.Round(percentage / array.Length * 100,2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unesite velicinu polja: ");
            Money[] money = new Money[int.Parse(Console.ReadLine())];
            Random gen = new Random();
            for (int i = 0; i < money.Length; i++)
            {
                money[i] = new Money(gen.Next(0,100));
            }
            Console.WriteLine($"Percentage in range: {inRange(Money.MoneyToString(money), 30,50)}%");

        }
    }
}
