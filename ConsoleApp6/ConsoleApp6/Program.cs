using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t;
            Console.WriteLine("Enter time required for complete the work: ");
            t = Convert.ToInt32(Console.ReadLine());
            if (t >= 2 && t <= 3)
            {
                Console.WriteLine("Worker should be highly Efficient: ");
            }
            else if (t >= 3 && t <= 4)
            {
                Console.WriteLine("Worker is Efficient but Have to Improve the Speed: ");
            }
            else if (t >= 4 && t <= 5)
            {
                Console.WriteLine("Efficiency was less and some training have to given to improve the speed: ");
            }
            else if (t > 5)
            {
                Console.WriteLine("Worker has to leave the compeny: ");
            }
            else
            {
                Console.WriteLine("Enter Correct Time: ");
            }
            Console.ReadLine();
        }
    }
}
