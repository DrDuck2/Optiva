using System;
using System.Collections.Generic;
using System.Text;

namespace LV4rppoon
{
    public interface IEmailValidatorService
    {
        bool IsValidAddress(String candidate);
    }
}
