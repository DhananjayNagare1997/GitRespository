using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Salary, Tax, AS; //dec of req variables.
            Console.WriteLine("Enter your Salary: "); // ip from user.
            Salary = Convert.ToDouble(Console.ReadLine()); // convert to req data type.
            AS = Salary * 12;
            Tax = AS * 0.11;
            Console.WriteLine("Annule Salary of Employee is: " + AS);
            Console.WriteLine("Total Tax have to pay: " + Tax);
            Console.ReadKey();
        }
    }
}
