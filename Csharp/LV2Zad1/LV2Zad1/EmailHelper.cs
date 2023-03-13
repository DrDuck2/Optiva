using System;
using System.Collections.Generic;
using System.Text;

namespace LV2Zad1
{
    public static class EmailHelper
    {
        public static bool CorrectEmail(string email)
        {
            int correctCount = 0;
            string[] gmail = { "gmail.com", "ferit.hr", "@" };
            if (email.Contains(gmail[0]) || email.Contains(gmail[1]))
            {
                 correctCount++;
            }
            if (email.Contains(gmail[2]))
            {
                 correctCount++;
            }
            return correctCount == 2;
        }
        public static bool FeritEmail(string email)
        {
            return email.Contains("ferit.hr");
        }
    }

}
