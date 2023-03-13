using System;

namespace LV2ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite koliko vektora zelite:");
            int vectorAmount = int.Parse(Console.ReadLine());
            Vektor[] vektor = new Vektor[vectorAmount];
            Console.WriteLine("Molim unesite granice velicine vektora:");
            int lowLimit = int.Parse(Console.ReadLine());
            int highLimit = int.Parse(Console.ReadLine());
            for(int i=0;i<vectorAmount;i++)
            {
                Random generator = new Random();
                vektor[i] = new Vektor(generator.RandomExtension(lowLimit,highLimit), generator.RandomExtension(lowLimit, highLimit), generator.RandomExtension(lowLimit, highLimit));
                Console.WriteLine(vektor[i].GetVektor());
            }
            Vektor a = new Vektor();
            a = vektor[0] + vektor[1];     
        }
    }
}
