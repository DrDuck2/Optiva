using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Zad3
{
    public class Utilities
    {
        public static int CountSpikes<T>(T[] ulaz) where T : IComparable<T>
        {
            int count = 0;
            for (int i = 0; i < ulaz.Length; i++)
            {
                if(i>0 && i< ulaz.Length-1)
                {
                    if(ulaz[i].CompareTo(ulaz[i-1]) == 1 && ulaz[i].CompareTo(ulaz[i+1]) == 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
            
    }
}
