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

            Console.WriteLine("Using foreach loop: ");
            foreach (int item in myList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Using for loop: ");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.ReadKey();
        }
    }
}
