using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad3
{
    class FixTaximetar : Taximetar
    {
        private double startCijena;
 

        public double StartCijena
        {
            get { return startCijena; }
        }

        public FixTaximetar(double startCijena, double cijenaPoKm) : base(cijenaPoKm) 
        {
            this.startCijena = startCijena;
        }

        public override double FullPrice(int brojKm)
        {
            return startCijena + (base.CijenaPoKm * brojKm);  
        }

    }
}
