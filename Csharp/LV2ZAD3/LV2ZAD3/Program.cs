using System;

namespace LV2ZAD3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite broj termina:");
            int termini = int.Parse(Console.ReadLine());
            Termin[] termin = new Termin[termini];
            string message = "Hello";
            message += "World";
            Console.WriteLine(message);
            for(int i =0;i<termini; i++)
            {
                Console.WriteLine("Molim unesite podatke termina:");
                Console.WriteLine("Ime pacijenta:");
                string name = Console.ReadLine();
                Console.WriteLine("Prezime pacijenta:");
                string surname = Console.ReadLine();
                Console.WriteLine("Datum termina i vrijeme:");
                string time = Console.ReadLine();
                Console.WriteLine("Vrijeme trajanja termina:");
                string trajanje = Console.ReadLine();
                termin[i] = new Termin(name, surname, time, trajanje);
            }

            for (int i = 0; i < termini - 1; i++)
            {
                for (int j = 0; j < termini - i - 1; j++)
                {
                    Termin holder = new Termin();
                    if (DateTime.Compare(termin[j].Time, termin[j + 1].Time) > 0)
                    {
                        holder = termin[j];
                        termin[j] = termin[j + 1];
                        termin[j + 1] = holder;
                    }
                }
            }
            Console.WriteLine("Max SpanTime is:");
            Console.WriteLine(Termin.PostTime(termin,termini));

        }
    }
}
