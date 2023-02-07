using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Marks obj = new Marks();
            obj.GetData();
            obj.GetDetails();
            obj.Show();

            Console.ReadKey();
        }
    }
}
