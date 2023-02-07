using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    public class Details
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string getDetails()
        {
            return "FirstName is " + FirstName + "lastename is " + LastName;
        }
        public int add()
        {
            return 2 + 2;
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public decimal add(decimal a, decimal b, decimal c)
        {
            //return a + b;
            return Convert.ToDecimal(a+b+c);
        }
    }
    public class Student : Details 
    {
        public string StudentAddress { get; set; }
    }
    public class Teacher : Details
    {
        public string Subject { get; set; }
    }
}
