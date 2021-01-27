using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
    class ATM
    {

        List<int> cardNumber = new List<int>();

        /*public void CreateUser(string name, string secondName, int password)
        {
            User newUser = new User();
            newUser.Name = name;
            newUser.SecondName = secondName;
            newUser.Password = password;
            newUser.ID = ID;
            PutBase(newUser, ID);
            Console.WriteLine($"You ID: {0} and password{1}", newUser.ID, newUser.Password);
            ID++;
        }*/

        /*void PutBase(User newUser, int ID)
        {
            if (!Account.account.ContainsKey(ID))
            {
                Account.account.Add(ID, newUser);
                //return true;
            }
        }*/

        public bool SignIn(int CardNo, int PIN)
        {
            if (!DB.users.ContainsKey(CardNo))
                return false;
            else if (DB.users[CardNo].PIN != PIN)
                return false;
            cardNumber.Add(CardNo);
            return true;
        }

        public void PutMoney(int money)
        {
            if (money > 0 && cardNumber.Count > 0)
                DB.balance[cardNumber[0]] += money;
            else
                Console.WriteLine("введите положительное число");
        }

        public void WithdrawMoney(int money)
        {
            if(money <= DB.balance[cardNumber[0]] && cardNumber.Count > 0)
            {
                DB.balance[cardNumber[0]] -= money;
            }
            else
                Console.WriteLine("У Вас недостаточно средст на счете");
        }

        public int GetBalance()
        {
            if(cardNumber.Count > 0)
                return DB.balance[cardNumber[0]];
            Console.WriteLine("Enter the Card");
            return -1;
        }

        public bool Exit()
        {
            cardNumber.Clear();
            return true;
        }

        

        



        
    }
}
