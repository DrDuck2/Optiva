using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad2
{
    public class PrimeFilter : IFilter
    {
        public bool IsValid(int[] polje)
        {
            var temporarylist = new List<int>();
            int velicina = polje.Length;
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i] < 1)
                {
                    i++;
                }
                else if (polje[i] == 1)
                {
                    temporarylist.Add(polje[i]);
                }
                else if (polje[i] == 2 || polje[i] == 3 || polje[i] == 5 || polje[i] == 7)
                {
                    temporarylist.Add(polje[i]);
                }
                else if (polje[i] % 2 != 0 && polje[i] % 3 != 0 && polje[i] % 5 != 0)
                {
                    temporarylist.Add(polje[i]);
                }
            }
            if(temporarylist.ToArray().Length == velicina)
            {
                return true;
            }
            return false;
        }
    }
}
