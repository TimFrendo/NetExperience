using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
    static class DB
    {
        //static int cardNomber = 45680000;





        //static public Dictionary<User, int> account = new Dictionary<User,int>();
        static public Dictionary<int, User> users = new Dictionary<int, User>();        
        static public Dictionary<int, int> balance = new Dictionary<int, int>();
        //public Dictionary<int, int> card = new Dictionary<int, int>();
      
        

        /*public void AddUser(string name, string secondName)
        {
            User newUser = new User() { Name = name, SecondName = secondName };
            int CardNo = GenerateCard()[0];
            int PIN = GenerateCard()[1];
            account.Add(CardNo, newUser);
            balance.Add(CardNo, 0);
            card.Add(CardNo, PIN);

            Console.WriteLine($"You Card number {CardNo} and PIN {PIN}");
        }*/


/*
        private int[] GenerateCard()
        {
            Random rand = new Random();
            int[] data = new int[2];
            data[0] = cardNomber + 1;
            data[1] = rand.Next(1000, 9999);

            return data;
        }*/


    }
}
