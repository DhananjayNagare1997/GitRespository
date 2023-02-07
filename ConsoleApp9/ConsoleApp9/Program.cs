using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int R_Time;
            Console.WriteLine("Enter the book returned time: ");
            R_Time = Convert.ToInt32(Console.ReadKey());

            if (R_Time >= 1 && R_Time <= 5)
            {
                Console.WriteLine("Fine amount is: 1$");
            }
            else if (R_Time >= 6 && R_Time <= 10)
            {
                Console.WriteLine("Fine amount is: 2$");
            }
            else if (R_Time > 10)
            {
                Console.WriteLine("Fine amount is: 5$");
            }
            else if (R_Time > 30)
            {
                Console.WriteLine("Membership Canceled.");
            }
            else
            {
                Console.WriteLine("Enter valid input");
            }
            Console.ReadKey();
        }
    }
}
