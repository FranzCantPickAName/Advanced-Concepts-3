using ClassLibrary1;
using System;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void DoWork()
        {
            using Sample s = new Sample();
            s.DisplayDataFromDatabase();
        }
        static void Main()
        {
            DoWork();

            Console.WriteLine("Insert other stuff here");

            Console.ReadKey();
        }
    }
}
