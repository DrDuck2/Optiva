using System;

namespace LV3Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj voznji: ");
            int br_voznji = int.Parse(Console.ReadLine());
            int[] polje = new int[br_voznji];
            Random random = new Random();
            Console.WriteLine("Broj KM po svakoj voznji: ");
            for (int i = 0; i <br_voznji; i++)
            {
                polje[i] = random.Next(1,10);
                Console.WriteLine($"{i+1}.    {polje[i]}");
            }

            Console.WriteLine("Unesite cijenu po KM i pocetnu cijenu za prvi taximetar i: ");
            double cijenaPoKm = double.Parse(Console.ReadLine());
            FixTaximetar taximetar1 = new FixTaximetar(double.Parse(Console.ReadLine()),cijenaPoKm);

            Console.WriteLine("Unesite fiksnu vrijednost i broj kilometara nakon koje prestaje: ");

            FixValueTaximetar taximetar2 = new FixValueTaximetar(double.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), cijenaPoKm);

            double TopVoznja1=0;
            double TopVoznja2=0;
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < br_voznji; i++)
            {
                 if(TopVoznja1 < taximetar1.FullPrice(polje[i]))
                 {
                    TopVoznja1 = taximetar1.FullPrice(polje[i]);
                    Console.WriteLine(TopVoznja1);
                    index1 = i;
                 }
                 if(TopVoznja2 < taximetar2.FullPrice(polje[i]))
                {
                    TopVoznja2 = taximetar2.FullPrice(polje[i]);
                    Console.WriteLine(TopVoznja2);
                    index2 = i;
                }
            }
            Console.WriteLine($"Za Prvi taximetar nabolja je voznja broj {index1 + 1}");
            Console.WriteLine($"Za Drugi taximetar nabolja je voznja broj {index2 + 1}");
        }
    }
}
