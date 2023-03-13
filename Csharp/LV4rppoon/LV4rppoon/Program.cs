using System;
using System.IO;
using System.Collections.Generic;
namespace LV4rppoon
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator(10);

            Console.WriteLine(emailValidator.IsValidAddress("dvidovic1@etfos.hr"));
            Console.WriteLine(passwordValidator.IsValidPassword("a%dxFgx3454sx"));
            RegistrationValidator registrationValidator = new RegistrationValidator();
            UserEntry userEntry;
            do
            {
                userEntry = UserEntry.ReadUserFromConsole();
            } while (registrationValidator.IsUserEntryValid(userEntry) == false);

        }
    }
}
