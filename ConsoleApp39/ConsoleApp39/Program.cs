using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    internal class Program
    {
        static int CheckPrime(int[] x)
        {
            int i, N;
            Boolean Prime = true;
          //  Console.WriteLine("Input any No: ");
          // N = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= N - 1; i++)
            {
                if (N % i == 0)
                {
                    Prime = false;
                }
            }
            if (Prime == false)
            {
               // Console.WriteLine("Not a Prime No:");
            }
        }
       /* static Add(int[] x)
        {
            int i, sum = 0;
            for (i = 0; i < 10; i++)
                sum = sum + x[i];
            Console.WriteLine("Sum is: " + sum);
        }
        static void Show(int[] x)
        {
            int i, sum = 0;
            for (i = 0; i < 10; i++)
                Console.WriteLine(x[i] + " ");
        } */
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i, result;
            Console.WriteLine("Enter Array Elements: ");
            for (i = 0; i < 10; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
           /* result = Add(a);
            Show(a);
            Console.WriteLine("Sum is: " + result); */
            Console.ReadKey();
        }
    }
}
