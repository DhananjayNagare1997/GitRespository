using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1; i <= 20; i = i + 2)
            {
                Console.Write(i + "/" + (i + 1) + " ");
            }
            Console.ReadKey();
        }
    }
}
