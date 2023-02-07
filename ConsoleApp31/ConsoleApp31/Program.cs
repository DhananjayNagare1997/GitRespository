using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Bank
    {
        string Name, Address;
        int bal;
        public Bank() //
        {
            Console.WriteLine("Welcome Fujitsu bank, Kindly fill Address: ");
            Console.WriteLine("Enter name of Costemer: ");
            // Name = Convert.ToInt32Console.ReadLine());
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Address of Costomer: ");
            Address = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Opening Balance: ");
            bal = Convert.ToInt32(Console.ReadLine());
        }
        public void Deposite()
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
            }else
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
            Bank B1 = new Bank(); //Constructor
            B1.Deposite();
            B1.Withdrow();
            Console.ReadKey();
        }
    }
}
