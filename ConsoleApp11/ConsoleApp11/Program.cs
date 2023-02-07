using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int i;
             for (i = 0; i <= 10; i++)
                 Console.WriteLine("Hello");
             Console.ReadKey(); */
            int i;
            for (i = 1; i <= 4; i++)
            {
                Double sub1, sub2, sub3, sub4, avg;
                Console.WriteLine("Enter Four Subject Marks for Students: "+i);
                sub1 = Convert.ToDouble(Console.ReadLine());
                sub2 = Convert.ToDouble(Console.ReadLine());
                 sub3 = Convert.ToDouble(Console.ReadLine());
                sub4 = Convert.ToDouble(Console.ReadLine());
                avg = (sub1 + sub2 + sub3 + sub4) * 0.25;
                Console.WriteLine("Average of Four Subjects is: " + avg);
                if (avg >= 60)
                    Console.WriteLine("Grade A");
                else if (avg >= 50 && avg <= 59)
                    Console.WriteLine("Grade B");
                else if (avg >= 40 && avg <= 49)
                    Console.WriteLine("Grade C");
                else
                    Console.WriteLine("Faile");
             }
            Console.ReadLine();
        }
    }
}
