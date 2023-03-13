using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Zad2
{
    public delegate bool Transformer(int x);
    public static class Utilities
    {
        public static bool DividibleByThree(int x)
        {
            if(x%3 == 0 && x!=0 )
            {
                return true;
            }
            return false;
        }

        public static bool InRange(int x)
        {
            if(x>=-5 && x<=5)
            {
                return true;
            }
            return false;
        }


        public static List<int> Filter(List<int> lista, Func<int,bool> transformer)
        {
            List<int> list = new List<int>();
            for (int i = 0; i <lista.Count ; i++)
            {
               if(transformer(lista[i]) == true)
                {
                    list.Add(lista[i]);
                }
            }
            return list;
        }
    }
}
