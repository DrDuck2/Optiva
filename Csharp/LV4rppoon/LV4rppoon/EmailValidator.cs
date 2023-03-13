using System;
using System.Collections.Generic;
using System.Text;

namespace LV4rppoon
{
    public class EmailValidator : IEmailValidatorService
    {
        public bool IsValidAddress(String candidate)
        {
            return ContainsSigns(candidate) && ContainsMoreSigns(candidate);
        }
        public bool ContainsSigns(String candidate)
        {
            if (candidate.Contains("@") && candidate.EndsWith(".com") || candidate.EndsWith(".hr"))
            {
                return true;
            }
            return false;
        }

        public bool ContainsMoreSigns(String candidate)
        {
            int SignCount = 0;
            foreach(char character in candidate)
            {
                if(character == '@')
                {
                    SignCount++;
                }
            }
            if (SignCount > 1)
            {
                return false;
            }
            return true;
        }
    }
}
