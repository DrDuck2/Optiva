using System;
using System.Collections.Generic;
using System.Text;

namespace LV4Zad3
{
    public class EpidemiologyChecker : IGoodBad
    {
        public bool CheckGoodBad(Dijete dijete)
        {
            return dijete.GetPereRuke;
        }
    }
}
