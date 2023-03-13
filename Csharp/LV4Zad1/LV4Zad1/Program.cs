using System;

namespace LV4Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite koliko trokuta i krugova zelite: ");
            int broj = int.Parse(Console.ReadLine());
            Random random = new Random();
            IShape[] shape = new IShape[broj*2];
            for (int i = 0; i < broj; i++)
            {
                shape[i] = new Circle(random.Next(0,10));
                shape[i+broj] = new Triangle(random.Next(0,10), random.Next(0, 10), random.Next(0, 10));
            }
            Console.WriteLine("Opseg Circle:");
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine(shape[i].Opseg());
            }
            Console.WriteLine("Povrsina Circle:");
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine(shape[i].Povrsina());
            }
            Console.WriteLine("Opseg Triangle:");
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine(shape[i+broj].Opseg());
            }
            Console.WriteLine("Povrsina Triangle:");
            for (int i = 0; i < broj; i++)
            {
                Console.WriteLine(shape[i+broj].Povrsina());
            }
        }
    }
}
