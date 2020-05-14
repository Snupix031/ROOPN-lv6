using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    class BankMemento
    {
        public string OwnerName { get; private set; }
        public string OwnerAddress { get; private set; }
        public decimal Balance { get; private set; }

        public BankMemento(string ownername, string owneraddress, decimal balance)
        {
            this.OwnerName = ownername; this.OwnerAddress = owneraddress; this.Balance = balance;
        }
        public BankMemento(BankAccount account)
        {
            this.OwnerName = account.OwnerName; this.OwnerAddress = account.OwnerAddress; this.Balance = account.Balance;
        }
        public void AddPreviousState(BankAccount account)
        {
            Balance = account.Balance;
        }
    }
}
