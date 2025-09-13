using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {

            int[] a = new int[] { 10, 20, 30, 40, 50, 60 };

            Array.Clear(a, 2, 3);

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            int[] b = new int[] { 10, 20, 30 };

            Array.Resize(ref b, 2);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
