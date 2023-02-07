using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Rad, Area;
            Console.WriteLine("Enter the value of Radious: ");
            Rad = Convert.ToDouble(Console.ReadLine()); //Salary = Convert.ToDouble(Console.ReadLine()); 
            Area = 3.14 * Rad * Rad;
            Console.WriteLine("Area of Circle: " + Area);
            Console.ReadKey();
        }
    }
}
