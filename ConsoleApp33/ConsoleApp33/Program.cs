using ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Program
    {
        static void Add(int[] x)
        {
            int i, sum=0;
            for (i = 0; i < 10; i++)
            sum = sum + x[i];
            Console.WriteLine("Sum is: " + sum);
        }
    static void Show(int[] x)
    {
            int i, sum = 0;
        for (i = 0; i < 10; i++)
            Console.WriteLine(x[i] + " ");
    }
    static void Main(string[] args)
        {
        int[] a = new int[10];
        int i;
        Console.WriteLine("Enter Array Elements: ");
        for (i = 0; i < 10; i++)
            a[i] = Convert.ToInt32(Console.ReadKey());
        Add(a);
        Console.ReadKey();
        }
    }
}
