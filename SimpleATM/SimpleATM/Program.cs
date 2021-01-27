using System;
using System.IO;
using System.Text.Json;

namespace SimpleATM
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { Name = "Tom", SecondName = "Filli", CardNo = 0001, PIN = 4586 };
            User user2 = new User() { Name = "Tim", SecondName = "Norman", CardNo = 0002, PIN = 2568 };
            User user3 = new User() { Name = "Harry", SecondName = "Gordan", CardNo = 0003, PIN = 9635 };
            User user4 = new User() { Name = "Kase", SecondName = "Williams", CardNo = 0004, PIN = 9785 };

            DB.users.Add(user1.CardNo, user1);
            DB.balance.Add(user1.CardNo, 0);
            DB.users.Add(user2.CardNo, user2);
            DB.balance.Add(user2.CardNo, 0);
            DB.users.Add(user3.CardNo, user3);
            DB.balance.Add(user3.CardNo, 0);
            DB.users.Add(user4.CardNo, user4);
            DB.balance.Add(user4.CardNo, 0);


            ATM atm = new ATM();


            while (true)
            {
                int cardNumber = 0;
                int PIN = 0;

                try
                {
                    Console.Write("Enter the Card: ");
                    cardNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the PIN: ");
                    PIN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception)
                {

                    Console.WriteLine("You must only number!");
                }
                                          
                    
                    bool exit = atm.SignIn(cardNumber, PIN);
                    
                    while (exit)
                    {
                        var user = DB.users[cardNumber];
                        Console.WriteLine($"Welcome Mr.(Mrs) {user.Name}  {user.SecondName}");
                        Console.WriteLine("Select 0 => Chech Balance");
                        Console.WriteLine("Select 1 => Withdraw Cash");
                        Console.WriteLine("Select 2 => Deposit Cash");
                        Console.WriteLine("Select 3 => Exit ATM");

                        try
                        {
                            Console.Write("Select Action: ");
                            int action = Convert.ToInt32(Console.ReadLine());
                            int money = 0;

                            switch (action)
                            {
                                case 0:
                                    Console.Write("You Balance: ");
                                    Console.WriteLine(atm.GetBalance());
                                    break;
                                case 1:
                                    Console.Write("Enter the number of money ");
                                    money = Convert.ToInt32(Console.ReadLine());
                                    atm.WithdrawMoney(money);
                                    break;
                                case 2:
                                    Console.Write("Enter the number of money ");
                                    money = Convert.ToInt32(Console.ReadLine());
                                    atm.PutMoney(money);
                                    break;
                                case 3:
                                    exit = !atm.Exit();
                                    break;
                            }
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Your must enter only number 0, 1, 2 or 3");
                        }
                        
                        

                    Console.WriteLine();

                    }

                if (exit) 
                    Console.WriteLine("Card or PIN Incorrect");
                Console.WriteLine();

            }


        }
    }
}
