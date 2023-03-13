using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad2
{
    interface IFilter
    {
        public bool IsValid(int[] polje);
        public static int[] Broji(int[] polje, PrimeFilter filter)
        {
            {
                var temporarylist = new List<int>();
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
                return temporarylist.ToArray();
            }
        }
        public static int[] Broji(int[] polje, PerfectFilter filter)
        {
            var temporarylist = new List<int>();
            for (int i = 0; i < polje.Length; i++)
            {
                if (polje[i] < 1)
                {
                    i++;
                }
                else if (polje[i] != 2 && polje[i] != 3 && polje[i] != 5 && polje[i] != 7 && polje[i] != 1 && (polje[i] % 2 == 0 || polje[i] % 3 == 0 || polje[i] % 5 == 0))
                {
                    temporarylist.Add(polje[i]);
                }
                else i++;
            }
            return temporarylist.ToArray();
        }
    }
}
