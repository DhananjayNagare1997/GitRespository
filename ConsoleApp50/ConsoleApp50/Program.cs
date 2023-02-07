using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
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
            obj.Name = "Dhanjay";
                obj.Id = 25;
            obj.Address = "Pune";

            Console.WriteLine("Name of Person is: " + obj.Name);
            Console.WriteLine("Id of Person is: " + obj.Id);
            Console.WriteLine("Address of Persone is: " + obj.Address);

            Console.ReadKey();

        }
    }
}
