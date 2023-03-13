using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char character in stringToCheck)
            {
                if(Char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
