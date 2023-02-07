using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double salary, HRA, DA;
            Console.WriteLine("Enter your salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            
            if (salary >= 45000)
            {
                HRA = salary * 0.12;
                DA = salary * 0.23;
                Console.WriteLine("HRA will be: " + HRA);
                Console.WriteLine("DA will be: " + DA);
                Console.WriteLine("Total salary will be: " +(salary+HRA+DA));
            }
            else
            {
                HRA = salary * 0.12;
                DA = salary * 0.8;
                Console.WriteLine("HRA will be: " + HRA);
                Console.WriteLine("DA will be: " + DA);
                Console.WriteLine("Total salary will be: " + (salary + HRA + DA));
            }
            Console.ReadLine();
        }
    }
}
