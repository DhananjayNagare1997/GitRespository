using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
   
        class MyArray1
        {
          //Multi level Inheritance.
            public int i,j;
            public int[] arr1 = new int[10];
            public void getdata1()
            {
                Console.WriteLine("Enter the 1'st Array Elements: ");
                for (i = 0; i <arr1.Length ; i++)
                {
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }             
        }
        class MyArray2: MyArray1
        {
            //public int j;
            public int[] arr2 = new int[10];
            public void getdata2()
            {
                Console.WriteLine("Enter the 2'nd Array's Elements: ");
                for (j = 0; j < arr2.Length; j++)
                {
                    arr2[j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        class MyArray3: MyArray2
        {
           // bool found = false;
           // public new int i,j;

            public void printarray()
            {
                Console.WriteLine("Common Array Elements are: ");
                /* for (i = 0; i < arr1.Length ; i++)
                 {
                     for (j = i; j <arr2.Length; j++)
                     {
                          if (arr1[i] == arr2[j])
                              Console.WriteLine(arr1[i] + " "); 
                     }
                 }*/
               var intersect = arr1.Intersect(arr2);
                foreach (int res in intersect)
                {
                    Console.WriteLine(res);
                } 
            }
        }
       
}

 
