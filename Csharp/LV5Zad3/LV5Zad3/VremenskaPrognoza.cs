using System;
using System.Collections.Generic;
using System.Text;

namespace LV5Zad3
{
    class VremenskaPrognoza
    {
        private float stupnjevi;
        private string opis;

        public VremenskaPrognoza(float stupnjevi)
        {
            this.stupnjevi = stupnjevi;
            this.opis = VremenskaPrognoza.OpisVremena(stupnjevi);
        }

        public float GetStupnjevi
        {
            get { return stupnjevi; }
        }
        public string GetOpis
        {
            get { return opis; }
        }

        public static string OpisVremena(float stupnjevi)
        {
            if(stupnjevi < 0)
            {
                return "Temperatura je ispod nule!";
            }
            else if(stupnjevi > 15 && stupnjevi <20)
            {
                return "Zatoplilo je!";
            }
            else if(stupnjevi>25 && stupnjevi < 30)
            {
                return "Pocinje biti vruce!";
            }
            else return "Prevruce je!";
        }
        public override string ToString()
        {
            return $"Temperatura: {stupnjevi}, {opis}";
        }
    }
}
