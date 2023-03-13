using System;

namespace LV5Zad2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Unesite dimenzije trokuta (a,b,c): ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                Trokut trokut = new Trokut(a, b, c);
                Console.WriteLine($"Opseg: {trokut.Opseg()}");
                Console.WriteLine($"Povrsina: {trokut.Povrsina()}");
            }
            catch (GeometryException e)
            {
                Console.WriteLine($"Triangle: {e.GetA},{e.GetB},{e.GetC} = {e.Message}");
            }
        }
    }
}
