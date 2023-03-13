using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Test
{
    public class Package : IEquatable<Package>
    {
        private readonly double weight;
        private readonly decimal price;

        public double Weight
        {
            get { return this.weight; }
        }
        public decimal Price
        {
            get { return this.price; }
        }

        public Package(double weight, decimal price)
        {
            this.weight = weight;
            this.price = price;
        }

        public override string ToString()
        {
            return $"Package weighting: {weight} at the price: {price}";
        }

        public bool Equals(Package package)
        {
            return weight == package.weight && price == package.price;
        }

        public override bool Equals(object obj)
        {
            if (obj is Package == false) return false;
            return Equals((Package)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Weight, Price);
        }
    }
}
