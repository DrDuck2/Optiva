using System;

namespace Zad2
{
    class Program
    {
        static void Main()
        {
            Die kockica = new Die();
            YambChecker yamb = new YambChecker();
            int[] array = new int[5];
            int[] array2 = new int[5];

            for (int i=0; i<5; i++)
            {
                array[i] = kockica.SetDieSide(0);
                array[i] = kockica.DieThrow(1);
                System.Console.WriteLine(array[i]);
            }

            System.Console.WriteLine(yamb.YambCheck(array));
            System.Console.WriteLine(yamb.CarriageCheck(array));

            do
            {
                for (int i = 0; i < 5; i++)
                {
                    array2[i] = kockica.SetDieSide(0);
                    array2[i] = kockica.DieThrow(1);
                    System.Console.WriteLine(array2[i]);
                }
            } while (yamb.YambCheck(array2) == false);
        }
    }
}
