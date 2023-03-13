using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Rpon
{
    public class ShippingService
    {
        private double pricePerMass;
        public ShippingService(double pricePerMass)
        {
            this.pricePerMass = pricePerMass;
        }

        public double PackagePrice(Box package)
        {
            return package.Weight * pricePerMass;
        }
    }
}
