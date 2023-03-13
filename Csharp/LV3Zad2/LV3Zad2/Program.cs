using System;

namespace LV3Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite koliko maceva imate: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite koliko stitova imate: ");
            int b = int.Parse(Console.ReadLine());
            Item[] items = new Item[a + b];
            for (int i = 0; i < items.Length; i++)
            {
                if(i<a)
                {
                    Console.WriteLine($"Unesite podatke za {i+1} mac: (Jacina,Ime,Tezina,Vrijednost) ");
                    items[i] = new Sword(double.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine($"Unesite podatke za {i + 1 - a} stit: (Jacina,Ime,Tezina,Vrijednost) ");
                    items[i] = new Sword(double.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine(Item.ValueAverage(items));
        }
    }

}
            

  
