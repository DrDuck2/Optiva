using System;
using System.Collections.Generic;
using System.Text;

namespace LV3Zad3
{
    public abstract class Taximetar
    {

        private  double cijenaPoKm;

        public  double  CijenaPoKm
        {
            get { return cijenaPoKm; }
        }

        public Taximetar(double cijenaPoKm)
        {
            this.cijenaPoKm = cijenaPoKm;
        }

        public bool DayNight(DateTime vrijeme)
        {
            DateTime date1 = new DateTime(0001, 0, 0, 20, 0, 0);
            DateTime date2 = new DateTime(0001, 0, 0, 6, 0, 0);
            return ((TimeSpan.Compare(vrijeme.TimeOfDay, date2.TimeOfDay) == 1 && TimeSpan.Compare(date2.TimeOfDay, vrijeme.TimeOfDay) == 1));
        }

        public abstract double FullPrice(int brojKm);
    }
}
