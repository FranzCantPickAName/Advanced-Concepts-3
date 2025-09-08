using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            using (Sample s = new Sample())
            {
                s.DisplayDataFromDatabase();
            }

            Console.WriteLine("Insert other stuff here");

            //Console.ReadKey();
        }
    }
}
