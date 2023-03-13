using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class StringUpperCaseChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            foreach (char character in stringToCheck)
            {
                if (Char.IsUpper(character) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
