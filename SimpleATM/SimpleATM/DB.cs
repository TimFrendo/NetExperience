using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleATM
{
    static class DB
    {
        //static public Dictionary<User, int> account = new Dictionary<User,int>();
        static public Dictionary<int, User> account = new Dictionary<int, User>();
        static public Dictionary<int, int> balance = new Dictionary<int, int>();

        static void AddUser(string name, string secondName)
        {
            User newUser = new User() { Name = name, SecondName = secondName };
            
        }


    }
}
