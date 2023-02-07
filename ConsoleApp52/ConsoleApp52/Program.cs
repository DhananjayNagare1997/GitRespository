using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Name = "Nagare";
            obj.Id = 35;
            Console.WriteLine("Name of Person is: " + obj.Name);
            Console.WriteLine("Id of a Person is: " + obj.Id);

            Console.ReadKey();
        }
    }
}
