using System;
using System.Collections.Generic;
using System.Text;

namespace Zad3
{
    class Complex
    {
        private int RealPart;
        private int ImaginaryPart;
        string ComplexNumberString;

        public Complex()
        {
            RealPart = ImaginaryPart = 0;
        }
        public Complex(int RealPart, int ImaginaryPart)
        {
            this.RealPart = RealPart;
            this.ImaginaryPart = ImaginaryPart;
        }

        public int GetRealNumber()
        {
            return this.RealPart;
        }
        public int GetImaginaryNumber()
        {
            return this.ImaginaryPart;
        }

        public void SetRealNumber(int RealPart)
        {
            this.RealPart = RealPart;
        }
        public void SetImaginaryNumber(int ImaginaryPart)
        {
            this.ImaginaryPart = ImaginaryPart;
        }

        public double ComplexModule()
        {
            return Math.Sqrt(Math.Pow(RealPart, 2) + Math.Pow(ImaginaryPart, 2));
        }
        public void Add(int RealPart,int ImaginaryPart)
        {
            this.RealPart = this.RealPart + RealPart;
            this.ImaginaryPart = this.ImaginaryPart + ImaginaryPart;
        }
        public string ComplexString()
        {
            String Real=RealPart.ToString(), Imaginary=ImaginaryPart.ToString();
            return ComplexNumberString = Real +"+"+ Imaginary + "i";
           
        }
    }
}
