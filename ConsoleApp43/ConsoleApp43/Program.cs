using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Bank
    {
        int Balance;
        double Mob_No;
        string Name, Address;

        public void OpenAccount()
        {
            Console.WriteLine("Welcome To Fujitsu Bank,Kindly Enter Correct details: ");
            Console.WriteLine("Enter Name for open account: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Mobile No: ");
            Mob_No = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            Balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dear user: " + Name + " Accoun Created Sucsesfully and details are: " + Address + "Contact no" + Mob_No + "Bal is:" + Balance);
        }
        public void Deposite()
        {
            int amt;
            Console.WriteLine("Enter Amount to deposite: ");
            amt = Convert.ToInt32(Console.ReadLine());

            Balance = Balance + amt;
            Console.WriteLine("Dear user: " + Name + "After Deposite Balance is: " + Balance);
        }
        public void Withdrow()
        {
            int amt;
            Console.WriteLine("Enter Amount to Withdrow: ");
            amt = Convert.ToInt32(Console.ReadLine());

            if (amt <= Balance)
            {
                Balance = Balance - amt;
                Console.WriteLine("Dear user: " + Name + "After Withdrow Balance is: " + Balance);
            }
            else
            {
                Console.WriteLine("Unable to withdwrow: ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.OpenAccount();
            b.Deposite();
            b.Withdrow();

            Console.ReadKey();
        }
        
    }
}
