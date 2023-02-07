using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter three no: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("Largest no is: " + a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("Largest no is: " + +b);
            }
            else
            {
                Console.WriteLine("Largest no is: " + c);
            }
            Console.ReadKey();
        }
    }
}



