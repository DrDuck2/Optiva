using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_4
{
    class NutritionalTracker : FoodTracker
    {
        private double calRange;
        private double portionweightRange;

        public NutritionalTracker(double calRange, double portionweightRange) : base()
        {
            this.calRange = calRange;
            this.portionweightRange = portionweightRange;
        }

        public override double MaxProfit()
        {
            double profit = 0;
            for (int i = 0; i < porcije.Count; i++)
            {
                if(porcije[i].Weight < portionweightRange && porcije[i].Kcal > calRange)
                {
                    profit += 10 / 100 * (double)porcije[i].Price;
                }
            }
            return profit + base.MaxProfit();
        }

    }
}
