using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch, sub, ans;
            Console.WriteLine("1. for First class: ");
            Console.WriteLine("2. for Second class: ");
            Console.WriteLine("3. for Third class: ");
            ch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no of failed Subjects: ");
            sub = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {

            case 1:
            if (sub > 3)
            {
                Console.WriteLine("No Gress:");
            } else
            {
                Console.WriteLine("Gress of 4 marks per subjects: ");
            }
            break;

            case 2:
                   if (sub > 2)
            {
                Console.WriteLine("No Gress");
            }
            else
            {
                Console.WriteLine("Gress of 5 marks per subjects: ");
            }
            break;
            if (sub > 1)
            {
                Console.WriteLine("No Gress");
            }
            else
            {
                Console.WriteLine("Gress of 5 marks per subjects: ");
            }
            break;
            }
            Console.ReadKey();
        }
    }
}
