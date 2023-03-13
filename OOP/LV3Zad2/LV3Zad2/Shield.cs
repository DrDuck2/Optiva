using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad2
{
    class Shield : Item
    {
        private double shieldAmount;

        public double ShieldAmount
        {
            get { return shieldAmount; }
            set { shieldAmount = value; }
        }

        public Shield(double shieldAmount, string name, double weight, double valueGold) : base(name, weight, valueGold)
        {
            this.shieldAmount = shieldAmount;
        }
        public override string ToString()
        {
            return $"Type : Shield {base.ToString()}";
        }
    }


}
