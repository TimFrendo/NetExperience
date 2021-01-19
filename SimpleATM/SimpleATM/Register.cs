using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
   
    class Register
    {
        public User newUser = new User();
        public int cash;
        public Register(string name, string secondName, int ID, int password)
        {
            newUser.Name = name;
            newUser.SecondName = secondName;
            newUser.ID = ID;
            newUser.Password = password;
            cash = 0;
        }

        public void PutBase()
        {
            if (!Account.account.ContainsKey(newUser))
            {
                Account.account.Add(newUser, cash);
            }

            else
            {
                Console.WriteLine("Пользователь с такими данными уже существует");
            }
        }



    }
}
