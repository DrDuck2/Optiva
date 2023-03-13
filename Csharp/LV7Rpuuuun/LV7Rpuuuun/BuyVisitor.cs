using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class BuyVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BookTax = 0.3;
        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price * (1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + DVDTax);
        }
        
        public double Visit(Book BOOKItem)
        {
            return BOOKItem.Price * (1 + BookTax);
        }
    }
}
