using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>(10) { 10, 20, 30 };

            myList.Insert(1, 100);

            List<int> otherList = new List<int>() { 50, 60, 70 };

            myList.InsertRange(2, otherList);

            Console.WriteLine("Using foreach loop: ");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
