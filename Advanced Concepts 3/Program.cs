using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 20, 30, 40, 50 };
            string[] b = new string[5] { "One", "Two", "Three", "Four", "Five" };

            //Console.WriteLine(a[0]);
            //Console.WriteLine(a[1]);
            //Console.WriteLine(a[2]);
            //Console.WriteLine(a[3]);
            //Console.WriteLine(a[4]);
            //Console.WriteLine();
            //Console.WriteLine(b[0]);
            //Console.WriteLine(b[1]);
            //Console.WriteLine(b[2]);
            //Console.WriteLine(b[3]);
            //Console.WriteLine(b[4]);

            //Using for loop:
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadKey();

        }
    }
}
