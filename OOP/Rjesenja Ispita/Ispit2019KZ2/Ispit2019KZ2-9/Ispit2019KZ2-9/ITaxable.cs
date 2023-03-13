using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2019KZ2_9
{
    interface ITaxable
    {
        public double getTaxPercentage();
        public double AmountWithTax();
        public double TaxAmount();
    }
}
