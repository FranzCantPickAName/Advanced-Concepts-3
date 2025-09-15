using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            //Console.WriteLine("First list: ");
            List<double> myNumbers = new List<double>() { 170, 150, 445, 120, 10, 4, 661 };

            myNumbers.Sort();

            foreach (double number in myNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            myNumbers.Reverse();

            foreach (double value in myNumbers)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
