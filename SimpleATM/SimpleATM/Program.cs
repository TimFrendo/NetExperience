using System;
using System.IO;
using System.Text.Json;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Register n = new Register("Nurzhan", "Usipov", 1, 12345);
            n.PutBase();
            n.PutBase();
            ATM aa = new ATM(n.newUser);
            

            //User T1 = new User() { Name = "dfgf", SecondName = "fffffd", ID = 4544, Password = 2125454 };
            /*ATM aa = new ATM(T);*/
            Console.WriteLine(aa.GetBalance());
            aa.PutMoney(100);
            Console.WriteLine(aa.GetBalance());
            aa.PutMoney(10);
            Console.WriteLine(aa.GetBalance());
            aa.WithdrawMoney(100);
            Console.WriteLine(aa.GetBalance());
            aa.WithdrawMoney(100);




        }
    }
}
