using System;
using System.Collections.Generic;

namespace LV6_Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pozitivan broj n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();
            Random gen = new Random();
            for (int i = 0; i <n ; i++)
            {
                lista.Add(gen.Next(-10, 10));
                Console.WriteLine($"{lista[i]} ");
            }

            Func<int, bool> funcTransformer = Utilities.DividibleByThree;
            List<int> DividibleBythree = new List<int>();
            DividibleBythree = Utilities.Filter(lista, funcTransformer);
            Console.WriteLine("Divideable by 3: ");
            foreach (var item in DividibleBythree)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            funcTransformer = Utilities.InRange;
            DividibleBythree = Utilities.Filter(lista, funcTransformer);
            Console.WriteLine("InRange: ");
            foreach (var item in DividibleBythree)
            {
                Console.Write($"{item} ");
            }

            Func<int, bool> dbt = x => x%3 == 0 && x!= 0;
            Func<int, bool> ir = x => x >= -5 && x <= 5;

            Console.WriteLine();
            DividibleBythree = Utilities.Filter(lista, dbt);
            Console.WriteLine("Divideable by 3 DBT: ");
            foreach (var item in DividibleBythree)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            funcTransformer = Utilities.InRange;
            DividibleBythree = Utilities.Filter(lista, ir);
            Console.WriteLine("InRange IR: ");
            foreach (var item in DividibleBythree)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
