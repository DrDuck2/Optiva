using System;
using System.Collections.Generic;
using System.Text;

namespace LV4rppoon
{
    public class RegistrationValidator : IRegistratioValidator
    {
        private EmailValidator emailValidator;
        private PasswordValidator passwordValidator;

        public RegistrationValidator()
        {
            emailValidator = new EmailValidator();
            passwordValidator = new PasswordValidator(10);
        }

        public bool IsUserEntryValid(UserEntry entry)
        {
            if(emailValidator.IsValidAddress(entry.Email) && passwordValidator.IsValidPassword(entry.Password) == true)
            {
                return true;
            }
            return false;
        }

    }
}
