using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    class YambChecker
    {

        public bool YambCheck(int[] array)
        {
            int count = 0;
            for(int i=1; i<5; i++)
            {
                if(array[0]== array[i])
                {
                    count++;
                }
            }
            return count == 4; 
        }

        public bool CarriageCheck(int[] array)
        {
            int count1 = 0, count2 = 0;
            for (int i = 1; i < 5; i++)
            {
                if (array[0] == array[i])
                {
                    count1++;
                }
                if (array[1] == array[i])
                {
                    count2++;
                }
            }
            return count1 == 3 || count2 == 3;
        }
    }
}
