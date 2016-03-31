using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmV1
{
    class Account
    {
        private int balance = 0;



      

        public void WithDraw(int amount)
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
