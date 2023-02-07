using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double b, h, Area;


            Console.WriteLine("Enter the value of Side b: ");
            Console.WriteLine("Enter the value of Hight h : ");
            n = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());


            
                Console.WriteLine("Enter the value of n (1 to 5): ");
                n = Convert.ToInt32(Console.ReadLine());

           switch (n) { 
                


            case0:
                Area = b * h;

                Console.WriteLine("Area of Rectangle is: " + Area);

            case1:
                Area = ((1 / 2) * b * h);
               
                Console.WriteLine("Area of Triangle is: " + Area);

            case2:
                Area = ((22 / 7) * b * h);
                Console.WriteLine("Area of Ellipse is: " + Area);


            case3:
                Area = ((22 / 7) * b * h);
                Console.WriteLine("Area of Ellipse is: " + Area);


            case4:
                Area = b * b;
                Console.WriteLine("Area of Square is: " + Area);

            Console.ReadKey();
        }
            

        }
    }



}

