using System;
using System.Collections.Generic;
using System.Text;

namespace LV2ZAD3
{
    class Termin
    {
        private string name;
        private string surname;
        private DateTime time;
        private DateTime trajanje;

        public Termin()
        {
            name = " ";
            surname = " ";
            time = new DateTime();
            trajanje = new DateTime();
        }
        public Termin(string name,string surname,string time,string trajanje)
        {
            this.name = name;
            this.surname = surname;
            this.time = DateTime.Parse(time);
            this.trajanje = DateTime.Parse(trajanje);
        }

        public string Name
        {
            get { return this.name; }
        }
        public string Surname
        {
            get { return this.surname; }
        }

        public DateTime Time
        {
            get { return this.time; }
        }

        public void Postpone(DateTime time)
        {
            this.time = time;
        }

        public static TimeSpan PostTime(Termin[] termin, int termini)
        {
            TimeSpan maxSpan = new TimeSpan(0, 0, 0);
            for(int i=0;i<termini-1;i++)
            {
                if(termin[i+1].Time.Subtract(termin[i].Time)>maxSpan)
                {
                    maxSpan = termin[i + 1].Time.Subtract(termin[i].Time);
                }
            }
            return maxSpan;
        }
        
    }
}
