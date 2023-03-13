using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad3
{
    public class SantasHelper
    {
        
        private int brojSiba;
        private int brojDarova;
        private IGoodBad goodbad;

        public SantasHelper(int brojSiba, int brojDarova,IGoodBad goodbad)
        {
            this.brojSiba = brojSiba;
            this.brojDarova = brojDarova;
            this.goodbad = goodbad;
        }

        public int GetBrojSiba
        {
            get { return brojSiba; }
        }
        public int GetBrojDarova
        {
            get { return brojDarova; }
        }
        
        public void SetGoodBad(IGoodBad goodbad)
        {
            this.goodbad = goodbad;
        }

        public bool SantaReady(Dijete[] dijeca)
        {
            int brojDobra = 0;
            int brojLosa = 0;
            for (int i = 0; i <dijeca.Length; i++)
            {
                if (goodbad.CheckGoodBad(dijeca[i]))
                {
                    brojDobra++;
                }
                else brojLosa++;
            }
            if(brojDobra <=  brojDarova && brojLosa <= brojSiba)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Broj siba: {brojSiba} Broj darova: {brojDarova} ";
        }

    }
}
