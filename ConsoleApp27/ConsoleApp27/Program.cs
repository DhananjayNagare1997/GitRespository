using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {  //Declairation of an array
            int[] a = new int[10];
            int i, count = 0;

            //Reading Array.
            Console.WriteLine("Enter the array Elements: ");
            for (i = 0; i<10; i++) 
            a[i] = Convert.ToInt32(Console.ReadLine());

            //Print Array.
            Console.WriteLine("Array Elements are: ");
            for (i = 0; i <10 ; i++) 
             Console.WriteLine(a[i] + " ");

             //Print Even Element of an array.
            Console.WriteLine("Even Array Elements are: ");
            for (i = 0; i < 10; i++) 
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                    Console.WriteLine(a[i] + " ");
                }
               // Console.Write(a[i] + " ");
            } 
            Console.WriteLine("Total Even Elements are: " + count);
            _ = Console.ReadKey();
        }
    }
}
