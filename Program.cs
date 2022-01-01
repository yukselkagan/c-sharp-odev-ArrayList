using System;
using System.Collections;
using System.Collections.Generic;

namespace c_sharp_odev_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {


            ArrayList list1 = new ArrayList();
            list1.Add("John");
            list1.Add(5);
            list1.Add(true);
            list1.Add('J');



            Console.WriteLine(list1[1]);

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }




            string[] colors = { "red", "green", "blue" };
            List<int> numbers = new List<int>() { 1, 5, 80, 2, 6, 11, 90 };
            list1.AddRange(colors);
            list1.AddRange(numbers);


            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("List 2 *****************");


            ArrayList list2 = new ArrayList();
            list2.AddRange(numbers);


            list2.Sort();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine( list2.BinarySearch(11) );



            list2.Reverse();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }



            list2.Clear();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }











        }
    }
}
