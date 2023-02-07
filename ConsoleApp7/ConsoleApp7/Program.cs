using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health, age, live, gender;
            Console.WriteLine("Enter health of person: 1-Excelent, 0-Poore");
            health = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter age of person: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person Lives In: 1-City, 0-village ");
            live = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the gender of person: 1-Male, 0-Female");
            gender = Convert.ToInt32(Console.ReadLine());

            if (health == 1 && (age >= 25 && age <= 35) && live == 1 && gender == 1)
            {
                Console.WriteLine("Premium is Rs. 4 per Thousand & his policy amount cannot exceed Rs. 2 Lakhs.");
            }
            else if (health == 1 && (age >= 25 && age <= 35) && live == 1 && gender == 0)
            {
                Console.WriteLine("Premium is Rs. 3 per Thousand & his policy amount cannot exceed Rs. 1 Lakhs.");
            }
            else if (health == 0 && (age >= 25 && age <= 35) && live == 0 && gender == 1)
            {
                Console.WriteLine("Premium is Rs. 6 per Thousand & his policy amount cannot exceed Rs: 10,000.");
            }
            else
            {
                Console.WriteLine("Person is not Insured");
            }
            Console.ReadKey();
        }
    }
}
