using System;

namespace LV3Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj rijeci: ");
            int wordcount = int.Parse(Console.ReadLine());
            string[] words = new string[wordcount];

            ScoreTool score = new ScoreTool(0);
            ScoreTool score2 = new CharCounter(0, 2, 1);

            Console.WriteLine($"Unesite {wordcount} rijeci: ");
            for (int i = 0; i < wordcount; i++)
            {
                Console.WriteLine($"{i+1}: ");
                do
                {
                    words[i] = new string(Console.ReadLine());
                } while (words[i].Length <= 3);
            }
            Console.WriteLine(score.ScoreCounter(words));
            Console.WriteLine(score2.ScoreCounter(words));
        }
    }
}
