using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    internal class Program
    {
        class Employee
        {
            string Name, Addres;
            int Salary;
            public void GetDetails()
            {
                Console.WriteLine("Enter name of Employee: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Address: ");
                Addres = Console.ReadLine();
                Console.WriteLine("Enter Salary of Employee: ");
                Salary = Convert.ToInt32(Console.ReadLine());
            }
            public void ShowDetails()
            {
                Console.WriteLine("Name of Employee is: "+Name);
                Console.WriteLine("Address of Employee: "+Addres);
                Console.WriteLine("Salary of Employee: "+Salary);
            }
        }

        static void Main(string[] args)
        {
            Employee obj = new Employee();
            obj.GetDetails();
            obj.ShowDetails();

            Console.ReadKey();
        }
    }
}
