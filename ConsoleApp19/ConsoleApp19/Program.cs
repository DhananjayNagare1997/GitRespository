using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum=0;
            i = 1;
            while (i <= 10)
            {
                sum = sum + i;
                i++;
                Console.WriteLine("Addition of No is: "+sum);
            }
            Console.ReadKey();
        }
    }
}
