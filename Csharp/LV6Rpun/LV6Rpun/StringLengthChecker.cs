using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class StringLengthChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            if(stringToCheck.Length > 10)
            {
                return true;
            }
            return false;
        }
    }
}
