using ConsoleApp44;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {


        static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderNo = "123";
            order.OrderValue = "1000";
            order.OrderCountry = "India";

            order.CreateOrder();

            Student student = new Student();
            student.FirstName = "Student 1";
            student.LastName = "lastname";
            student.StudentAddress="test address";
            student.getDetails();

            Console.ReadKey();

        }

    }
}
