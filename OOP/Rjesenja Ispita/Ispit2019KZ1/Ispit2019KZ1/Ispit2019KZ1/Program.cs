using System;

namespace Ispit2019KZ1
{
    class Program
    {
        public static bool CanItStore(PcImage[] images, double space)
        {
            double biggestImage = 0;
            for (int i = 0; i < images.Length; i++)
            {
                if(images[i].Space() > biggestImage)
                {
                    biggestImage = images[i].Space();
                }
            }
            Console.WriteLine(biggestImage);
            return biggestImage <= space;
        }
        static void Main(string[] args)
        {
            PcImage[] values = new PcImage[10];
            Random gen = new Random();
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = new PcImage(gen.Next(0,1024), gen.Next(0,1024), gen.Next(0,256));
            }
            Console.WriteLine($"Can you store biggest image: {CanItStore(values, 13588)}");
        }
    }
}
