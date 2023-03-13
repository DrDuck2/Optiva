using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad3
{
    public class HolidayChecker : IGoodBad
    {
        public bool CheckGoodBad(Dijete dijete)
        {
            if (dijete.GetBrojDobrihDjela > dijete.GetBrojSvadja)
            {
                return true;
            }
            else if (dijete.GetBrojDobrihDjela < dijete.GetBrojSvadja)
            {
                return false;
            }
            else return dijete.GetPereRuke;
        }
    }
}
