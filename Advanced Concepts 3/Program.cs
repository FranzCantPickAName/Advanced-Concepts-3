using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            int[] a = new int[] { 67, 12, 99, 4, 500, 125 };

            Array.Sort(a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Array.Reverse(a);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
