using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declairation of an array
            int[] a = new int[10];
            int i, Item, temp=0;
            Boolean Found = false;

            //Reading Array.
            Console.WriteLine("Enter the array Elements: ");
            for (i = 0; i < 10; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            //Print Array.
            Console.WriteLine("Array Elements are: ");
            for (i = 0; i < 10; i++)
                Console.WriteLine(a[i] + " ");

            Console.WriteLine("Enter Element serch in array: ");
            Item = Convert.ToInt32(Console.ReadLine());
            //Print Even Element of an a
           // Console.WriteLine("Even Array Elements are: ");
            for (i = 0; i < 10; i++)
            {
                if (a[i] == Item)
                {
                    Found = true;
                    temp = i;
                    break;
                }
                // Console.Write(a[i] + " ");
            }
            if (Found == true)
            {
                Console.WriteLine("Elements found at Location: " +temp);
            }else
            {
                Console.WriteLine("Not found ");
            }
            //Console.WriteLine("Total Even Elements are: " + count);
            Console.ReadKey();
        }
    }
}
