using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Class1 : Interface1
    {
        int a, b, c;
        public void GetData()
        {
            Console.WriteLine("Enter two values: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("Sum is: " + c);
        }
        public void Add()
        {
            c = a + b;
        }
    }
}
