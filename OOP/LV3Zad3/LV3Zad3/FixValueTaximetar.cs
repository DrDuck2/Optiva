using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad3
{
    class FixValueTaximetar : Taximetar
    {
        private double fixedValue;
        private int fixedKmValue;
        public double FixedValue
        {
            get { return fixedValue; }
        }
        public int FixedKmValue
        {
            get { return fixedKmValue; }

        }

        public FixValueTaximetar(double fixedValue,int fixedKmValue,double cijenaPoKm) : base(cijenaPoKm)
        {
            this.fixedValue = fixedValue;
            this.fixedKmValue = fixedKmValue;
        }

        public override double FullPrice(int brojKm)
        {
            if(fixedKmValue > brojKm)
            {
                return fixedValue;
            }
            else
            {
                return brojKm * base.CijenaPoKm;
            }
        }
    }
}
