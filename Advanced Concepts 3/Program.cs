using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            double[] a = new double[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            int n = Array.BinarySearch(a, 30);
            Console.WriteLine("30 is found at index " + n);

            int n2 = Array.BinarySearch(a, 100);
            Console.WriteLine("100 is found at index " + n2);

            Console.ReadKey();

        }
    }
}
