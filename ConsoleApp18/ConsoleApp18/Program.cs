using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, N;
            Console.WriteLine("Enter any no: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table is: ");
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine(N + "*" + i + "=" + (N * i));
                i++;
            }
            Console.ReadKey();
        }
    }
}
