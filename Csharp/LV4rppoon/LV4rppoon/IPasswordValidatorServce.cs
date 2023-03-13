using System;
using System.Collections.Generic;
using System.Text;

namespace LV4rppoon
{
    public interface IPasswordValidatorService
    {
        bool IsValidPassword(String candidate);
    }
}
