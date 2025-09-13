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

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            foreach (string i in b)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            for (int i = b.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(b[i]);
            }

            Console.ReadKey();

        }
    }
}
