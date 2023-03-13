using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad3
{
    public class Dijete
    {
        private int brojSvadja;
        private int brojDobrihDjela;
        private bool pereRuke;

        public Dijete(int brojSvadja, int brojDobrihDjela, bool pereRuke)
        {
            this.brojSvadja = brojSvadja;
            this.brojDobrihDjela = brojDobrihDjela;
            this.pereRuke = pereRuke;
        }
        public int GetBrojSvadja
        {
            get { return brojSvadja; }
        }
        public int GetBrojDobrihDjela
        {
            get { return brojDobrihDjela; }
        }
        public bool GetPereRuke
        {
            get { return pereRuke; }
        }
        public override string ToString()
        {
            return $"Broj svađa: {brojSvadja} Broj dobrih djela: {brojDobrihDjela} Pere li ruke? : {pereRuke}";
        }
    }
}
