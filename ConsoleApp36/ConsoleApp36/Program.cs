using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static int CheckPrime(int[] a)
        {
            int i;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    return a[i];
                }

            }return 0;
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
            int i,j, result=0;
            Console.WriteLine("Enter Array Elements: ");
            for (i = 0; i < a.Length; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
              CheckPrime(a);
            //result = a[i];
            for (j = 0; j < a.Length; j++)
            {
                // Console.WriteLine("Result: " +a[j])
                result = a[j];
            }
           // result = a[i];
           // Show(a);
            Console.WriteLine("Sum is: " + result);
            Console.ReadKey();
        }
    }
}
