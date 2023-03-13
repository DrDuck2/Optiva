using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Ispit2019KZ2_9
{
    class Program
    {
        public static double MaxAmount(List<ITaxable> lista)
        {
            int numOfElements = (int)(lista.Count * 10 / 100);
            double[] maxAmount = new double[numOfElements];
            double max = 0;
            for (int i = 0; i<lista.Count; i++)
            {
                if(numOfElements >0)
                {
                    maxAmount[i] = lista[i].AmountWithTax();
                    numOfElements--;
                }
                else
                {
                    for (int j = 0; j < maxAmount.Length; j++)
                    {
                        if(lista[i].AmountWithTax()>maxAmount[j])
                        {
                            maxAmount[j] = lista[i].AmountWithTax();
                        }
                    }
                }
            }
            for (int i = 0; i < maxAmount.Length; i++)
            {
                max += maxAmount[i];

            }
            return max;
        }
        static void Main(string[] args)
        {
            List<ITaxable> lista = new List<ITaxable>();
            Random gen = new Random();
            for (int i = 0; i < 10; i++)
            {
                lista.Add(new Flour(gen.Next(1,100), gen.Next(1, 100), gen.Next(1, 100)));
            }
            Console.WriteLine(MaxAmount(lista));
            
        }
    }
}
