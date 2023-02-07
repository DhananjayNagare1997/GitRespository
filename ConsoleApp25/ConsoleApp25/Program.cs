using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, ch,temp,A;
            Double Area, Length, width;

            do

            {
                Console.WriteLine("1. Addition of two values: ");
                Console.WriteLine("2. largest of 3 no: ");
              //  Console.WriteLine("3. Area of Rectangle: ");
                Console.WriteLine("Enter your Choise: ");
                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter a two values:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = a + b;
                        Console.WriteLine("Addition of two values is: " + c);
                        break;
                    case 2:
                        Console.WriteLine("Enter a 3 No's:");
                        a = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        c = Convert.ToInt32(Console.ReadLine());
                        if (a > b && b > c)
                        {
                            Console.WriteLine("Largest No is:" + a);
                        }
                        else if (b > a && b > c)
                        {
                            Console.WriteLine("Largest No is:" + b);

                        }
                        else
                        {
                            Console.WriteLine("Largest No is:" + c);
                        }
                        break;
                   /* case 3:
                        Console.WriteLine("Enter Length & Width values: ");
                        Length = Convert.ToDouble(Console.ReadLine());
                        width = Convert.ToDouble(Console.ReadLine());
                        Area = width;
                        Console.WriteLine("Area of Rectangle is: " + Area); */
                }
                Console.WriteLine("Do you want to continue: 1-yes,2-no");
                A = Convert.ToInt32(Console.ReadLine());
                temp = A;
            }
            while (temp == 1);
            }
        
        }
        
    }

