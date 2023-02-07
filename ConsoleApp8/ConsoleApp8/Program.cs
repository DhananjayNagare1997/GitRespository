using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double hard, cc, ts;
            Console.WriteLine("Enter steel hardness: ");
            hard = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Steel Carbon Contain: ");
            cc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Steel Steinsile Strength: ");
            ts = Convert.ToDouble(Console.ReadLine());
            
            if (hard > 50 && cc < 0.7 && ts > 5600)
            {
                Console.WriteLine("Grade is 10");
            }
            else if (hard > 50 && cc < 0.7)
            {
                Console.WriteLine("Grade is 9");
            }
            else if (cc < 0.7 && ts > 5600)
            {
                Console.WriteLine("Grade is 8");
            }
            else if (hard > 50 && ts > 5600)
            {
                Console.WriteLine("Grade is 7");
            }
            else if (hard > 50 || cc < 0.7 || ts > 5600)
            {
                Console.WriteLine("Grade is 6");
            }
            else
            {
                Console.WriteLine("Grade is 5");
            }
            Console.ReadKey();
        }
    }
}
