using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Student
    {
        string Address, Name;
        int RollNo;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No: ");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name Of Student: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Address of Student: ");
            Address = Convert.ToString(Console.ReadLine());
        }
    }
    class Marks : Student
    {
        double sub1, sub2, sub3, sub4, avg;

        public void GetDetails()
        {
            Console.WriteLine("Enter Four Subject's Marks: ");
            sub1 = Convert.ToDouble(Console.ReadLine());
            sub1 = Convert.ToDouble(Console.ReadLine());
            sub1 = Convert.ToDouble(Console.ReadLine());
            sub1 = Convert.ToDouble(Console.ReadLine());
        }
        public void Show()
        {
            avg = (sub1 + sub2 + sub3 + sub4) / 4;
            Console.WriteLine("Avrege of No's is: " + avg);
        }
    }
}


