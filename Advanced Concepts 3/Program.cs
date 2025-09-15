using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            List<int> marks = new List<int>() { 40, 95, 24, 70, 16, 81 };

            bool b = marks.Exists(m => m < 35);

            if (b)
            {
                Console.WriteLine("Student has failed one or more subjects.");
            }
            else
            {
                Console.WriteLine("Student has passed all subjects.");
            }

            int firstFailedMark = marks.Find(m => m < 35);
            Console.WriteLine("The first failed mark is: " + firstFailedMark);

            int firstFailedMarkIndex = marks.FindIndex(m => m < 35);
            Console.WriteLine("The first failed mark is at index: " + firstFailedMarkIndex);

            int lastFailedMark = marks.FindLast(m => m < 35);
            Console.WriteLine("The last failed mark is: " + lastFailedMark);

            int lastFailedMarkIndex = marks.FindLastIndex(m => m < 35);
            Console.WriteLine("The last failed mark is at index: " + lastFailedMarkIndex);

            List<int> allFailedMarks = marks.FindAll(m => m < 35);
            Console.WriteLine("\nFailed marks: ");
            foreach (int mark in allFailedMarks)
            {
                Console.WriteLine(mark);
            }

            Console.ReadKey();
        }
    }
}
