using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class PasswordValidator
    {
        private StringChecker stringChecker;

        public PasswordValidator(StringChecker stringChecker)
        {
            this.stringChecker = stringChecker;
        }
        
        public void AddToChain(StringChecker checker)
        {
            stringChecker.SetNext(checker);
            stringChecker = checker;
        }

        public bool Validate(string message)
        {
            return stringChecker.Check(message);
        }
    }
}
