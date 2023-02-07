using MultilevelInherit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInherit
{
    //Multilevel Inheritance.
    class MyArray
    {
        public int[] a = new int[10];
        int i;
        public void GetArray()
        {
            Console.WriteLine("Enter Array Elements: ");
            for (i = 0; i < 10; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
        }

        internal void GetItem()
        {
            throw new NotImplementedException();
        }

        internal void GetSearch()
        {
            throw new NotImplementedException();
        }
    }
    class MyItem : MyArray//Inheriting the MyArray Class.
    {
        public int Item;
        public void GetItem()
        {
            Console.WriteLine("Enter Element to serch in array: ");
            Item = Convert.ToInt32(Console.ReadLine());
        }
    }
    class SearchArray : MyItem//Inheriting the MyItem Class.
    {
        bool Found = false;
        int i, temp=1;
        public void GetSearch()
        {
            for (i = 0; i < 10; i++)
            {
                if (a[i] == Item)
                {
                    Found = true;
                    temp = temp + i;
                    break;
                }
                // Console.Write(a[i] + " ");
            }
            if (Found == true)
            {
                Console.WriteLine("Elements found at Location: " + temp);
            }
            else
            {
                Console.WriteLine("Not found ");
            }
            //Console.WriteLine("Total Even Elements are: " + count);
            
        }

    }
}
class Multilevellnheri
{
    static void Main(string[] args)
    {
        SearchArray array = new SearchArray();
        array.GetArray();
        array.GetItem();
        array.GetSearch();

        Console.ReadKey();
    }
}
