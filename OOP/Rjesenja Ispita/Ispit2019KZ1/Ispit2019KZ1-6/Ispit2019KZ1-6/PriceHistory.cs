using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Ispit2019KZ1_6
{
    class PriceHistory
    {
        private double[] mPrices;
        private int mCount;

        public int GetmCount
        {
            get { return this.mCount; }
        }
        public double GetmPrices(int i)
        {
            return mPrices[i];
        }
        public PriceHistory(int mCount, double mPrices)
        {
            this.mCount = mCount;
            this.mPrices = new double[mCount];
            for (int i = 0; i < mCount; i++)
            {
                this.mPrices[i] = mPrices;
            }
        }

        public PriceHistory(PriceHistory item)
        {
            this.mCount = item.GetmCount;
            this.mPrices = new double[this.mCount];
            for (int i = 0; i < this.mCount; i++)
            {
                this.mPrices[i] = item.GetmPrices(i);
            }
        }
        public static bool operator >(PriceHistory item1, PriceHistory item2)
        {
            double average1 = 0;
            double average2 = 0;
            for (int i = 0; i < item1.GetmCount; i++)
            {
                average1 += item1.GetmPrices(i);
            }
            average1 /= item1.GetmCount;
            for (int i = 0; i < item2.GetmCount; i++)
            {
                average2 += item2.GetmPrices(i);
            }
            average2 /= item2.GetmCount;
            if (average1 > average2)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(PriceHistory item1, PriceHistory item2)
        {
            double average1 = 0;
            double average2 = 0;
            for (int i = 0; i < item1.GetmCount; i++)
            {
                average1 += item1.GetmPrices(i);
            }
            average1 /= item1.GetmCount;
            for (int i = 0; i < item2.GetmCount; i++)
            {
                average2 += item2.GetmPrices(i);
            }
            average2 /= item2.GetmCount;
            if (average1 < average2)
            {
                return true;
            }
            return false;
        }

        public int Trend(PriceHistory item)
        {
            int jumpCounter = 0;
            int fallCounter = 0;
            for (int i = 0; i <item.GetmCount ; i++)
            {
                if(i!=item.GetmCount-1)
                {
                    if(item.GetmPrices(i) > item.GetmPrices(i+1))
                    {
                        fallCounter++;
                    }
                    else if (item.GetmPrices(i) < item.GetmPrices(i + 1))
                    {
                        jumpCounter++;
                    }
                }
            }
            if(jumpCounter > fallCounter)
            {
                return 1;
            }
            else if(jumpCounter < fallCounter)
            {
                return -1;
            }
            return 0;
        }

        public static void Store(PriceHistory item, string filename)
        {
            if (!File.Exists(filename))
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    sw.Write(item);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filename))
                {
                    sw.Write(item);
                }
            }
            using(StreamReader sr = new StreamReader(filename))
            {
                Console.WriteLine(sr.ReadLine());
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            {
                builder.Append($"Count: {this.mCount}, ");
            }
            for (int i = 0; i < this.mCount; i++)
            {
                builder.Append($"{i+1}. price:{this.mPrices[i]} ");
            }
            return builder.ToString();

        }
    }
}
