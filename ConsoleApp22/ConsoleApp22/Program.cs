using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{ 
    //Given no is palindrome or not?
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit, N, rev = 0, temp;
            Console.WriteLine("Enter the three digit no: ");
            N = Convert.ToInt32(Console.ReadLine());
            temp = N;
            while (N > 0)
            {
                digit = N % 10;
                N = N / 10;
                rev = rev*10 + digit;
            }
            Console.WriteLine("Entered no's reverse is: " + rev);
            if (rev == temp)
            {
                Console.WriteLine("Entered no is Palindrome");
            }else
            {
                Console.WriteLine("Entered no is NotPalindrome");
            }
            Console.ReadKey();
        }
    }
}
