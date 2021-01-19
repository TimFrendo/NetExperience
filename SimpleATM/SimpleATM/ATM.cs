using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
    class ATM
    {
        readonly User user;
        int balance;
        
        public ATM(User user)
        {
            this.user = user;
            balance = Account.account[user];
        }

        public void PutMoney(int money)
        {
            balance += money;
        }

        public void WithdrawMoney(int money)
        {
            if(money <= balance)
            {
                balance -= money;
            }
            else
                Console.WriteLine("У Вас недостаточно средст на счете");
        }

        public int GetBalance()
        {
            return balance;
        }

        

        



        
    }
}
