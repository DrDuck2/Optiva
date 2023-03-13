using System;
using System.Collections.Generic;
using System.Text;

namespace LV7Rpuuuun
{
    public class RentVisitor : IVisitor
    {
        public double Visit(DVD DVDItem)
        {
            if(DVDItem.Type == DVDType.SOFTWARE)
            {
                return double.NaN;
            }
            return DVDItem.Price;
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price;
        }
        public double Visit(Book BOOKItem)
        {
            return BOOKItem.Price;
        }
    }
}
