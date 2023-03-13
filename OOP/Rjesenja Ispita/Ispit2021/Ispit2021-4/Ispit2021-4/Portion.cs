using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021_4
{
    public class Portion
    {
        private decimal price;
        private double weight;
        private double kcal;
        public Portion(decimal price, double weight, double kcal)
        {
            this.price = price;
            this.weight = weight;
            this.kcal = kcal;
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public double Kcal
        {
            get { return this.kcal; }
            set { this.kcal = value; }
        }

        public override string ToString()
        {
            return $"Price: {price} Weight: {weight} Kcal: {kcal}";
        }

    }
}
