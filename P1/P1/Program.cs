using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(20);
            al.Add(12);
            al.Add(100);
            al.Add(200);
            al.Add(21);
            Console.WriteLine("Elements are in ArrayList :");
            foreach(int item in al)
            {
                Console.WriteLine(item);
            }
            al.Sort();

            Console.WriteLine("After removing Elements from ArrayList elemnts are :");
            foreach (int item in al)
            {
                Console.WriteLine(item);
            }
             
            Console.ReadKey();

            /*
            int a = 10;
            double num = 10.4;
            bool b = false;

            Console.WriteLine("Value in b is: " + b);

            Console.WriteLine("Value in num is: " + num);
            Console.WriteLine("The value of A is: "+a);

            Console.ReadLine(); */
        }
    }
}
