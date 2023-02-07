using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();
            int ch;
            do
            {
                Employee emp = new Employee();
                Console.WriteLine("Enter Employee ID: ");
                emp.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                emp.Name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Employee Address: ");
                emp.Address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter Employee Salary: ");
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                lst.Add(emp);

                Console.WriteLine("Do you want to Register more Employee's: 1-Yes,0-No");
                ch = Convert.ToInt32(Console.ReadLine());
            }
            while (ch == 1);

            Console.WriteLine("Employee List is: ");
            foreach (Employee employee in lst)
            {
                Console.WriteLine("Employee Id is: "+employee.ID);
                Console.WriteLine("Employee Name is: " + employee.Name);
                Console.WriteLine("Employee Address is: " + employee.Address);
                Console.WriteLine("Employee Salary is: " + employee.Salary ); 
            }
            Console.ReadKey();
        }
    }
}
