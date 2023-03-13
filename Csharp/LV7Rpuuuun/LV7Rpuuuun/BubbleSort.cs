using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j+1]);
                    }
                }
            }
        }
    }
}
