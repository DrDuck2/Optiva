using System;
using System.Collections.Generic;
using System.Text;

namespace LV2ZAD2
{
    public static class RandomClass
    {
        public static int RandomExtension(this Random generator,int low, int high)
        {
            return generator.Next(low, high);
        }
    }
}
