using System;
using System.Collections.Generic;
//using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp33


{
    internal class Program
    {
        public void Checkprime(int[] x)
        {
            int i;
            string result;
           
           for (i = 0; i < 10; i++)
            {   
                if (x[i] % 2 == 0)
                {
                    result =( x[i] + " ");
                    Console.WriteLine("Prime No's are: "+result);
                }
            }
        }
        /*
        static int Add(int[] x)
        {
            int i, sum = 0;
            for (i = 0; i < 10; i++)
                sum = sum + x[i];
            // Console.WriteLine("Sum is: " + sum);
            return (sum);
        }
        static string Show(int[] x)
        {
            int i,sum=0;
            for (i = 0; i < 10; i++)
                // Console.WriteLine(x[i] + " ");
                sum = sum + x[i];
            return (x[i] +" ");

        } */
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int i,
                result1;
            string result2;
           
            Console.WriteLine("Enter Array Elements: ");
            for (i = 0; i < 10; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
           // result1 = Add(a);
          //  Show(a);
         //   result2 = Show(a);
           
           // Console.WriteLine("Sum is: " + result1);
           //Console.WriteLine("Array elments are: " + result2);
            Console.ReadKey();
        }
    }
}




