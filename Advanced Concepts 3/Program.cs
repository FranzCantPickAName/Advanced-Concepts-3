using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            double[] a = new double[6] { 10, 20, 30, 40, 50, 30 };

            int n = Array.IndexOf(a, 30);
            Console.WriteLine("30 is found at index " + n);

            int n2 = Array.IndexOf(a, 30, 3);
            Console.WriteLine("30 second occurence is found at index " + n2);

            int n3 = Array.IndexOf(a, 100);
            Console.WriteLine("100 is found at index " + n3);

            Console.ReadKey();

        }
    }
}
