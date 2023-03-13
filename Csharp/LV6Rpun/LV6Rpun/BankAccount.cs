using System;
using System.Collections.Generic;
using System.Text;

namespace LV6Rpun
{
    public class BankAccount
    {
        private string ownerName;
        private string ownerAddress;
        private decimal balance;
        public BankAccount(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }
        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }
        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public BankAccountMemento StoreState()
        {
            return new BankAccountMemento(this.ownerName, this.ownerAddress, this.balance);
        }

        public void RestoreState(BankAccountMemento previousState)
        {
            this.ownerName = previousState.OwnerName;
            this.ownerAddress = previousState.OwnerAddress;
            this.balance = previousState.Balance;
        }
    }
}
