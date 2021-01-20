using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
    class ATM
    {
        readonly User user;
        int balance;
        static int ID = 42680000;
        
        /*public ATM(User user)
        {
            this.user = user;
            balance = Account.account[user];
        }*/

        public void CreateUser(string name, string secondName, int password)
        {
            User newUser = new User();
            newUser.Name = name;
            newUser.SecondName = secondName;
            newUser.Password = password;
            newUser.ID = ID;
            PutBase(newUser, ID);
            Console.WriteLine($"You ID: {0} and password{1}", newUser.ID, newUser.Password);
            ID++;
        }

        void PutBase(User newUser, int ID)
        {
            if (!Account.account.ContainsKey(ID))
            {
                Account.account.Add(ID, newUser);
                //return true;
            }
        }
        public void SignIn(int ID, int password)
        {
            if (!Account.account.ContainsKey(ID))
            {
                Console.WriteLine("User not is Base");
            }

            if (Account.account[ID].Password == password)
            {
                Console.WriteLine("Accepted");
            }
            else
            {
                Console.WriteLine("password not correctly");
            }
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
