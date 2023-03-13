using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class LinearchSearch : SearchStrategy
    {
        public override bool Search(double[] array, double searchItem)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                if(array[i] == searchItem)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
