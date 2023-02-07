/*// C# program to find sum of
// first n terms of the given series
using System;

class GFG
{
static int calculateSum(int n)
{
	// when n is odd
	if (n % 2 == 1)
		return (n + 1) / 2;

	// when n is not odd
	return -n / 2;
}

// Driver code
public static void Main()
{

	// no. of terms to find the sum
	int n = 8;
	Console.WriteLine(calculateSum(n));
}
}

// This code is contributed
// by inder_verma
*/
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
        {  //Addition of 1-2+3-4+5-.......-10
            int i, N, sum, sum1 = 0,sum2 = 0;
            Console.WriteLine("Enter no till sum required: ");
            N = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= N)
            {
                if (i % 2 == 0)
                {
                    sum1 = sum1 + i;
                    i++;
                    // Console.WriteLine("Sum of given serise is: " + sum1);
                }
                else
                {
                    sum2 = sum2 + i;
                    i++;
                    // Console.WriteLine("Addition of No is: " + sum2);
                }
            }
                sum = sum2 - sum1;
                Console.WriteLine("Addition of Serise is: " +sum);
                /* sum = sum + i;
                 i++;
                 Console.WriteLine("Addition of No is: " + sum);
                */
            
            Console.ReadKey();
        }
    }
}
