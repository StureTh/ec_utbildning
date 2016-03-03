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



        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void WithDraw(int amount)
        {

        }

        public void Deposit(int amount)
        {

        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
