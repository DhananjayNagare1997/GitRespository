using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //No Item in ArrayList
            ArrayList al = new ArrayList();
            Console.WriteLine("No Item in ArrayList ");
            Console.WriteLine("Capacity is: "+al.Capacity);
            Console.WriteLine("Count is: "+al.Count);
            //Only one Item in ArrayList
            al.Add(10);
            Console.WriteLine("One Item in ArrayList ");
            Console.WriteLine("Capacity is: " + al.Capacity);
            Console.WriteLine("Count is: " + al.Count);
            //Only two Element in ArrayList
            al.Add(20);
            Console.WriteLine("Two Item in ArrayList "); 
            Console.WriteLine("Capacity is: " + al.Capacity);
            Console.WriteLine("Count is: " + al.Count);
            al.Add(100);
            al.Add(200);
            //Only Four Element in ArrayList
            Console.WriteLine("Four Item in ArrayList ");
            Console.WriteLine("Capacity is: " + al.Capacity);
            Console.WriteLine("Count is: " + al.Count);
            //Six elements in ArrayList.
            al.Add(101);
            al.Add(201);
            Console.WriteLine("Four Item in ArrayList ");
            Console.WriteLine("Capacity is: " + al.Capacity);
            Console.WriteLine("Count is: " + al.Count);

            Console.WriteLine("Elements are: ");

            foreach (int item in al)
                Console.WriteLine(item);
            
            //Check element present in ArrayList or not.
            Console.WriteLine("Contains 101: " + al.Contains(101));

            //Sorting ArrayList.
            al.Sort();
            Console.WriteLine("Elements are: ");
            foreach (int item in al)
                Console.WriteLine(item);

            //Remove Element.
            al.Remove(200);
            Console.WriteLine("After removing 200, Arraylist's Element are: ");
            foreach (int item in al)
                Console.WriteLine(item);
            
            //Remove Element at Perticular location.
            al.RemoveAt(1);
            Console.WriteLine("After removing Arraylist's Element are: ");
            foreach (int item in al)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
