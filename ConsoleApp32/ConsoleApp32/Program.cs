using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
   // internal class Program
    //{
       // static void Main(string[] args)
      //  {
             class Bank
        {
            string Name, Address;
            int bal;
            public Bank() // Constructor
            {
                Console.WriteLine("Welcome Fujitsu bank, Kindly fill Details: ");
                Console.WriteLine("Enter name of Coustemer: ");
                // Name = Convert.ToInt32Console.ReadLine());
                Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Address of Coustomer: ");
                Address = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Opening Balance: ");
                bal = Convert.ToInt32(Console.ReadLine());
            }
            public void Deposite() //Methode(must be in lower case)
            {
                int amt;
                Console.WriteLine("Enter Amount to Deposite: ");
                amt = Convert.ToInt32(Console.ReadLine());
                bal = bal + amt;
                Console.WriteLine("Dear" + Name + "! After Deposite your Account balance is: " + bal);
            }

            public void Withdrow()
            {
                int amt;
                Console.WriteLine("Enter Amount to Withdrow: ");
                amt = Convert.ToInt32(Console.ReadLine());
                // bal = bal - amt;
                //Console.WriteLine("Dear" + Name + "! After Deposite your Account balance is: " + bal);
                if (amt > bal)
                {
                    Console.WriteLine("Insufficient Balance, So Cant Proceed: ");
                }
                else
                {
                    bal = bal - amt;
                    Console.WriteLine("Dear" + Name + "! After Deposite your Account balance is: " + bal);
                }
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Bank B1 = new Bank(); //Object creation,Bank B1 => refrence variable,
               // B1.Deposite();
                //B1.Withdrow();
                int ch, choise;

                do
                {
                   // Console.WriteLine("0. Open a Account: ");
                    Console.WriteLine("1. Deposite Money into the Account: ");
                    Console.WriteLine("2. Withdrow Money from Account: ");
                   // Console.WriteLine("3. Withdrow Money from Account: ");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            B1.Deposite(); //methode calling.
                            break;
                        case 2:
                            B1.Withdrow();
                            break;
                    }
                    Console.WriteLine("Do you want to repete: 1-Yes,0-No: ");
                    choise = Convert.ToInt32(Console.ReadLine());

                } while (choise == 1);
                Console.ReadKey();
            }
        }
    } 

