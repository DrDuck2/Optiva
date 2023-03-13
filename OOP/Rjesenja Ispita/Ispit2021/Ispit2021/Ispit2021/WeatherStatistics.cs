using System;
using System.Collections.Generic;
using System.Text;

namespace Ispit2021
{
    public static class WeatherStatistics
    {
        public static int ExtremeWinds(Wind[] winds)
        {
            double ExtremeSpeed = 0;
            int numOfExtremeWinds = 0;
            for (int i = 0; i < winds.Length; i++)
            {
                ExtremeSpeed += winds[i].SpeedKmh;
            }
            ExtremeSpeed /= winds.Length;

            for (int i = 0; i < winds.Length; i++)
            {
                if(winds[i].SpeedKmh > 20/100*ExtremeSpeed + ExtremeSpeed)
                {
                    numOfExtremeWinds++;
                }
            }
            return numOfExtremeWinds;
        }
    }
}
