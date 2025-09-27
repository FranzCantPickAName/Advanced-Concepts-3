using ClassLibrary1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Advanced_Concepts_3
{
    internal class Program
    {
        static void Main()
        {
            Sample s = new Sample();
            Tuple<string, int> person = s.GetPersonDetails();

            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.ReadKey();
        }
    }
}
