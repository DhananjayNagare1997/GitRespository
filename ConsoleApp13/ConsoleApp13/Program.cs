using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write(i + " ");
                }
                
            }
            Console.ReadKey();
        }
    }
}
