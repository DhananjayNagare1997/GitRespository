using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    internal class Program
    {
       private static int checkprime(int N)
        {
            int i;
            //bool Prime = true;
           // string result;
            for (i = 2; i <= N - 1; i++)
            {
                if (N % i == 0)
                {
                   //  Prime = false;
                    return 0;
                }
            }
            if (i == N)
            {
                return 1;
            }
            return 0;

         /*   if (Prime == false)
            {
               // Console.WriteLine("Not a Prime No:");
               return;
            }
            else
            {
               // Console.WriteLine("It's a Prime No:");
            }*/
        }
        static void Main(string[] args)
        {
            int N;
            int result;
            Console.WriteLine("Enter a number to check Prime or not?: ");
            N = Convert.ToInt32(Console.ReadLine());
            result = checkprime(N);
            // Show(N);
            if (result == 0)
            {
                Console.WriteLine("It's a Not Prime No:");
            }
            else
            {
                 Console.WriteLine("It's Prime No:");
            }
            Console.ReadKey();
        }
    }
}
