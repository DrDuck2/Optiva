using System;

namespace Ispit2019
{
    class Program
    {

        public static bool checkUnique<T>(T[] array) where T : IComparable
        {

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj youtube videa: ");
            YoutubeVideo[] yv = new YoutubeVideo[int.Parse(Console.ReadLine())];
            for (int i = 0; i < yv.Length; i++)
            {
                Console.WriteLine($"Unesite Title {i+1} videa: ");
                yv[i] = new YoutubeVideo($"{i + 1}", Console.ReadLine());
            }
            Console.WriteLine(checkUnique(YoutubeVideo.mTitleArray(yv)));
        }
    }   
}
