using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; } //get methode
            set { name = value; } //set methode
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Person obj = new Person();
            obj.Name = "Dhanjay";
            Console.WriteLine("Name of person is: " + obj.Name);
            obj.Age = 23;
            Console.WriteLine("Age of person is: " + obj.Age);

            Console.ReadKey();
        }
    }
}
