using System;
using System.Collections.Generic;
using System.Text;

namespace LV2ZAD2
{
    class Vektor
    {
        int componentI;
        int componentJ;
        int componentK;

        public int ComponentI
        {
            get { return this.componentI; }
        }
        public int ComponentJ
        {
            get { return this.componentJ; }
        }
        public int ComponentK
        {
            get { return this.componentI; }
        }

        public Vektor()
        {
            componentI = 0;
            componentJ = 0;
            componentK = 0;
        }

        public Vektor(int componentI, int componentJ, int componentK)
        {
            this.componentI = componentI;
            this.componentJ = componentJ;
            this.componentK = componentK;
        }

        public string GetVektor()
        {
            return $"I = {componentI} J = {componentJ} K = {componentK}";
        }

        public static Vektor operator+ (Vektor first, Vektor second)
        {
            return new Vektor(first.componentI + second.componentI, first.componentJ + second.componentJ, first.componentK + second.componentK);
        }
        public static Vektor operator- (Vektor first, Vektor second)
        {
            return new Vektor(first.componentI - second.componentI, first.componentJ - second.componentJ, first.componentK - second.componentK);
        }
    }
}
