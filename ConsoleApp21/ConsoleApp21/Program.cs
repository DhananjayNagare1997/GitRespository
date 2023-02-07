using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, digit, sum = 0;
            Console.WriteLine("Enter 3 digit no: ");
            N = Convert.ToInt32(Console.ReadLine());
            while (N > 0)
            {
                digit = N % 10;
                N = N / 10;
                sum = sum + digit;
            }
            Console.WriteLine("Entered no's digit sum is:" + sum);
            Console.ReadKey();
        }
    }
}
