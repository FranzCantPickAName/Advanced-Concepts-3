using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            string name = "Developer";
            string name_updated = name.Insert(4, "sad");
            Console.WriteLine(name_updated);

            string name_updated2 = name.Remove(2, 4);
            Console.WriteLine(name_updated2);


            Console.ReadKey();
        }
    }
}
