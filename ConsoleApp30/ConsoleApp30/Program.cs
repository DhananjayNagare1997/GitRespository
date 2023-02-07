using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        class Bank
        {
           // int ch, choise;
            private readonly double a;
            private readonly double b;
            private readonly double c;
            string OpenAccount;
            string Diposite;
            string Withdrow;

            public void O_Account()  // methode
            {
                Console.WriteLine("Open a Account:");
            }

            // methode
            public void GetD_Diposite() => Console.WriteLine("Deposite a Money:");

            // methode
            public void GetWithdrow() => Console.WriteLine("Withdrow a Money:");

            static void Main(string[] args)
            {
                //  BankAccount bank = new BankAccount();
                int ch, choise;
                Bank B = new Bank();
                /*   Console.WriteLine("Enter Name of Person: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    B.O_Account = a;
                    Console.WriteLine("Enter Amount to Deposite: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    B.O_Deposite = b;
                    Console.WriteLine("Enter Amount to Withdrow: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    B.O_Deposite = c;
                */
                do
                {
                    Console.WriteLine("0. Open Account: ");
                    Console.WriteLine("1. Diposite in Account: ");
                    Console.WriteLine("2. Withdrow from Account: ");
                    Console.WriteLine("Enter your choise: ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 0:
                            B.O_Account();
                            break;
                        case 1:
                            object deposit = B.D_Diposite();
                            break;
                        case 2:
                            B.GetWithdrow();
                            break;
                    }
                    Console.WriteLine("Do you want to repete : 1-Yes,2-No ");
                    choise = Convert.ToInt32(Console.ReadLine());
                } while (choise == 1);
                Console.ReadKey();
            }

            private object D_Diposite()
            {
                throw new NotImplementedException();
            }
        }
    } }
