using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args )
        {
            int i, N;
            Boolean Prime = true;
            Console.WriteLine("Input any No: ");
            N = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= N-1; i++)
            {
                if (N % i == 0)
                {
                    Prime = false;
                }
            }
            if (Prime == false)
            {
                Console.WriteLine("Not a Prime No:");
            }else
            {
                Console.WriteLine("It's a Prime No:");
            }
            Console.ReadKey();
        }
    }
}
