using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2_9
{
    class Flour : ITaxable
    {
        public int TaxPercentage { get; private set; }
        public int QuantityKg { get; private set; }
        public int PricePerKg { get; private set; }


        public Flour(int taxPercentage, int quantityKg, int pricePerKg)
        {
            this.TaxPercentage = taxPercentage;
            this.QuantityKg = quantityKg;
            this.PricePerKg = pricePerKg;
        }
        public double getTaxPercentage()
        {
            return Math.Round((double)this.TaxPercentage/100,2);
        }
        public double AmountWithTax()
        {
            return Math.Round((double)(TaxAmount()+ this.PricePerKg * this.QuantityKg),2);
        }
        public double TaxAmount()
        {
            return Math.Round((double) (this.PricePerKg * this.QuantityKg * getTaxPercentage()),2);
        }

        public override string ToString()
        {
            return $"TaxPerc: {this.TaxPercentage} QuantityKg: {this.QuantityKg} PricePerKg: {this.PricePerKg}";
        }
    }
}
