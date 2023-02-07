using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(100);
            al.Add(200);

            Console.WriteLine("Elements are: ");
            foreach (int item in al)

                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
