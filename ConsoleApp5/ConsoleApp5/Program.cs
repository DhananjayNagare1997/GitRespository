using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Double avg;
            Console.WriteLine("Enter subjects Marks: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            avg = (a + b + c + d)/4;

            if (avg >= 60)
            {
                Console.WriteLine("Grade is A and avg will be: " + avg);
            }
            else if (avg >= 50 && avg <60)
            {
                Console.WriteLine("Grade is B and avg will be: " + avg);
            }
            else if (avg >= 40 && avg < 50)
            {
                Console.WriteLine("Grade is C and avg will be: " + avg);
            }
            else
            {
                Console.WriteLine("Person will be Faile: ");
            }
            Console.ReadKey();

        }
    }
}
