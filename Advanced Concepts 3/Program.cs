using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>(10) { 10, 20, 30, 40, 50 };

            //myList.Remove(30);
            //myList.RemoveAt(2);
            //myList.RemoveRange(1,2);
            //myList.RemoveAll(n => n >= 30);
            myList.Clear();

            //List<int> otherList = new List<int>() { 50, 60, 70 };

            //myList.InsertRange(2, otherList);

            Console.WriteLine("Using foreach loop: ");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
