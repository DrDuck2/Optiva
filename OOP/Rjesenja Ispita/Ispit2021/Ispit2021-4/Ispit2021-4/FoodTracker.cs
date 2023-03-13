using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ispit2021_4
{
    public class FoodTracker
    {
        protected List<Portion> porcije;

        public FoodTracker()
        {
            porcije = new List<Portion>();
        }
        public void Track(Portion portion)
        {
            porcije.Add(portion);
        }

        public virtual double MaxProfit()
        {
            double profit = 0;
            for (int i = 0; i < this.porcije.Count; i++)
            {
                profit += (double)porcije[i].Price;
            }
            return profit;
        }

        public void PortionRemover(Func<Portion,bool> transformer)
        {
            for (int i = 0;i<porcije.Count;i++)
            {
                if (transformer(porcije[i]) == true)
                {
                    porcije.RemoveAt(i);
                    i--;
                }
            }
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (var item in porcije)
            {
                output += $"{item}{Environment.NewLine}";
            }
            return output;
        }

    }
}
