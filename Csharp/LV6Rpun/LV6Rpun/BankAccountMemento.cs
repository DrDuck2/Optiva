using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class BankAccountMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccountMemento(string ownerName, string ownerAddress, decimal balance)
        {
            this.OwnerName = ownerName;
            this.OwnerAddress = ownerAddress;
            this.Balance = balance;
        }
    }
}
