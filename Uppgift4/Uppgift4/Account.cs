using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift4
{
    class Account
    {
        private int balance = 0;

        public void Withdraw(int amount)
        {
            balance = balance - amount;
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
