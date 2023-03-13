using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class SequentialSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arraySize = array.Length;
            for (int i = 0; i < arraySize - 1; i++)
            {
                for (int j = i + 1; j < arraySize; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
    }
}
