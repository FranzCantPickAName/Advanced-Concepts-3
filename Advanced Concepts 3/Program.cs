using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string x = "Hello World";
            int n = x.Length;
            char c = x[0];

            Console.WriteLine(x);
            Console.WriteLine(n);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
