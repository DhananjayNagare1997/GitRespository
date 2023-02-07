using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Input any digit NUmber and print largest digit of it.
 Ex: N = 12987 , Largest Digit : 9 */



            int number, r, Digit = 0;
            Console.WriteLine("Enter any digit:");
            number = Convert.ToInt32(Console.ReadLine());



            while (number > 0)  //12987=>1298=>129=>12=>1
            {
                r = number % 10; //
                if (Digit < r) // R=> 12987=>1298=>129=>12=>1
                {
                    Digit = r;
                }
                number = number / 10;
            }
            Console.WriteLine("Largest digit:" + Digit);
            
            Console.ReadLine();

        }
    }
}