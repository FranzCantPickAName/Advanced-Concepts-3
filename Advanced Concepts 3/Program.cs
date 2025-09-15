using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("First list: ");
            List<int> myList = new List<int>(10) { 10, 20, 30, 40, 50, 40 };

            int n = myList.IndexOf(40);
            Console.WriteLine("40 found at index " + n);

            int n2 = myList.IndexOf(60);
            if (n2 >= 0)
            {
                Console.WriteLine("60 found at index " + n2);
            }
            else
            {
                Console.WriteLine("60 not found");
            }

            int n3 = myList.IndexOf(40, n + 1);
            Console.WriteLine("Second occurence of 40 is at index " + n3);

            Console.WriteLine("\nSecond list: ");
            List<int> myList2 = new List<int>(10) { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int n4 = myList2.BinarySearch(80);
            Console.WriteLine("Binary search: 80 found at index " + n4);

            bool b = myList2.Contains(110);
            Console.WriteLine("110 is found: " + b);

            Console.ReadKey();
        }
    }
}
