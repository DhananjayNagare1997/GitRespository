using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Abc
    {
        int a, b, c;
        public void Getdata()
        {
            Console.WriteLine("Enter two No's: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void Sum()
        {
            c = a + b;
            Console.WriteLine("Sum is: " + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Abc obj = new Abc();
            obj.Getdata();
            obj.Sum();
        }
    }
}
