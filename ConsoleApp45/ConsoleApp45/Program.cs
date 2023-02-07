using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    internal interface interface1
    {
        void GetData();
        void ShowData();
    }
    class Abc : interface1
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Abc obj = new Abc();
            obj.GetData();
            obj.Add();
            obj.ShowData();

            Console.ReadKey();
        }
    }
}
