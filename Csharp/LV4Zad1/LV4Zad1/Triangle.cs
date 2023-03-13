using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad1
{
    class Triangle : IShape
    {
        public double stranicaA;
        public double stranicaB;
        public double stranicaC;

        public double GetStranicaA
        {
            get { return stranicaA; }
        }
        public double GetStranicaB
        {
            get { return stranicaB; }
        }
        public double GetStranicaC
        {
            get { return stranicaC; }
        }

        public Triangle(double stranicaA,double stranicaB,double stranicaC)
        {
            this.stranicaA = stranicaA;
            this.stranicaB = stranicaB;
            this.stranicaC = stranicaC;
        }
        public double Povrsina() //pretpostavimo da je pravokutni trokut
        {
            return stranicaA * stranicaB / 2;
        }

        public double Opseg()
        {
            return stranicaA + stranicaB + stranicaC;
        }
        public override string ToString()
        {
            return $"A: {stranicaA} B: {stranicaB} C: {stranicaC}";
        }
    }
}
