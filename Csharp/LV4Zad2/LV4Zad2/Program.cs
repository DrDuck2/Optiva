using System;

namespace LV4Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeFilter prime = new PrimeFilter();
            PerfectFilter perfect = new PerfectFilter();
            Random random = new Random();
            Console.WriteLine("GENERIRAM POLJE MOLIM PRICEKAJTE...");
            System.Threading.Thread.Sleep(3000);
            int[] polje = new int[100];
            int[] polje2 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                polje[i] = random.Next(-500, 500);
                polje2[i] = polje[i];
            }


            Console.WriteLine("Jesi li dobio polje sa svim PRIME brojevima? : ");
            Console.WriteLine(prime.IsValid(polje));
            Console.WriteLine("FILTRIRAM 'PRIME' BROJEVE");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Jesu li sada svi PRIME? :");
            polje = IFilter.Broji(polje, prime);
            Console.WriteLine(prime.IsValid(polje));
            for (int i = 0; i < polje.Length; i++)
            {
                Console.WriteLine(polje[i]);
            }

            Console.WriteLine("Jesi li dobio polje sa svim PERFECT brojevima? : ");
            Console.WriteLine(perfect.IsValid(polje2));
            Console.WriteLine("FILTRIRAM 'PERFECT' BROJEVE");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Jesu li sada svi PERFECT? :");
            polje2 = IFilter.Broji(polje2, perfect);
            Console.WriteLine(perfect.IsValid(polje2));
            for (int i = 0; i < polje2.Length; i++)
            {
                Console.WriteLine(polje2[i]);
            } 
        }
    }
}
